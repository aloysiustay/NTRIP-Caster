import React, { useState } from 'react';
import {
  Table,
  Typography,
  Spin,
  Input,
  Form,
  InputNumber,
  Button,
  Radio,
  Space,
  message,
} from 'antd';
import axios from 'axios';
import { BASE_API_URL } from '../Config';

const { Title } = Typography;

function AvailableStations({ stations, loading }) {
  const [filterMode, setFilterMode] = useState('name'); // 'name' | 'latlon'
  const [mode, setMode] = useState('radius'); // for latlon filter
  const [form] = Form.useForm();
  const [filteredStations, setFilteredStations] = useState([]);
  const [querying, setQuerying] = useState(false);

  // ------------------------------------
  // 🔹 Table Columns
  // ------------------------------------
  const columns = [
    { title: 'Name', dataIndex: 'm_Name', key: 'm_Name' },
    {
      title: 'Identifier',
      dataIndex: 'm_Identifier',
      key: 'm_Identifier',
      render: (text) => (
        <div
          style={{
            whiteSpace: 'normal',
            wordBreak: 'break-word',
            maxWidth: 100,
          }}
        >
          {text}
        </div>
      ),
    },
    { title: 'Format', dataIndex: 'm_Format', key: 'm_Format' },
    {
      title: 'Types',
      dataIndex: 'm_FormatDetails',
      key: 'm_FormatDetails',
      render: (text) => (
        <div
          style={{
            whiteSpace: 'normal',
            wordBreak: 'break-word',
            maxWidth: 400,
          }}
        >
          {text}
        </div>
      ),
    },
    { title: 'Carrier', dataIndex: 'm_Carrier', key: 'm_Carrier' },
    { title: 'NavSystem', dataIndex: 'm_NavSystem', key: 'm_NavSystem' },
    { title: 'Network', dataIndex: 'm_Network', key: 'm_Network' },
    { title: 'Country', dataIndex: 'm_Country', key: 'm_Country' },
    { title: 'Latitude', dataIndex: 'm_Lat', key: 'm_Lat' },
    { title: 'Longitude', dataIndex: 'm_Lon', key: 'm_Lon' },
  ];

  // ------------------------------------
  // 🔹 Filter by name (client-side)
  // ------------------------------------
  const handleNameSearch = (e) => {
    const value = e.target.value.trim().toLowerCase();
    if (!value) {
      setFilteredStations([]);
      return;
    }

    const filtered = stations.filter(
      (s) =>
        s.m_Name.toLowerCase().includes(value) ||
        s.m_Identifier.toLowerCase().includes(value)
    );
    setFilteredStations(filtered);
  };

  // ------------------------------------
  // 🔹 Filter by coordinates (server-side)
  // ------------------------------------
  const handleLatLonSubmit = async (values) => {
    setQuerying(true);
    try {
      const baseParams = { lat: values.lat, lon: values.lon };
      const url =
        mode === 'count'
          ? `${BASE_API_URL}/api/Caster/nearestMountpoints`
          : `${BASE_API_URL}/api/Caster/nearestMountpointsWithinRadius`;
      const queryParams =
        mode === 'count'
          ? { ...baseParams, numMountpoints: values.count }
          : { ...baseParams, radiusInMeters: values.radius * 1000 }; // km → meters

      const res = await axios.get(url, { params: queryParams });
      const resultArray = Object.values(res.data);
      setFilteredStations(resultArray);
    } catch (err) {
      console.error('Query failed:', err);
      message.error('Failed to query nearby base stations.');
    } finally {
      setQuerying(false);
    }
  };

  // ------------------------------------
  // 🔹 Display logic
  // ------------------------------------
  const displayedData =
    filteredStations.length > 0 ? filteredStations : stations;

  return (
    <>
      <Title level={4}>
        Available Stations {loading ? '' : `(${displayedData.length})`}
      </Title>

      <div style={{ marginBottom: 16 }}>
        <Radio.Group
          value={filterMode}
          onChange={(e) => {
            setFilterMode(e.target.value);
            setFilteredStations([]);
            form.resetFields();
          }}
        >
          <Radio.Button value="name">Filter by Name</Radio.Button>
          <Radio.Button value="latlon">Filter by Coordinates</Radio.Button>
        </Radio.Group>
      </div>

      {/* -------------------- */}
      {/* 🔸 Name Filter UI */}
      {/* -------------------- */}
      {filterMode === 'name' && (
        <Input
          placeholder="Search by name or identifier..."
          onChange={handleNameSearch}
          style={{ width: 300, marginBottom: 16 }}
          allowClear
        />
      )}

      {/* -------------------- */}
      {/* 🔸 Coordinate Filter UI */}
      {/* -------------------- */}
      {filterMode === 'latlon' && (
        <Form
          form={form}
          layout="inline"
          onFinish={handleLatLonSubmit}
          style={{ marginBottom: 16, flexWrap: 'wrap' }}
        >
          <Form.Item
            label="Lat"
            name="lat"
            rules={[{ required: true, message: 'Enter latitude' }]}
          >
            <InputNumber min={-90} max={90} step={0.0001} />
          </Form.Item>

          <Form.Item
            label="Lon"
            name="lon"
            rules={[{ required: true, message: 'Enter longitude' }]}
          >
            <InputNumber min={-180} max={180} step={0.0001} />
          </Form.Item>

          <Radio.Group
            value={mode}
            onChange={(e) => {
              setMode(e.target.value);
              form.resetFields(['radius', 'count']);
            }}
            style={{ margin: '0 16px' }}
          >
            <Radio value="radius">By Range (km)</Radio>
            <Radio value="count">By Number</Radio>
          </Radio.Group>

          {mode === 'radius' ? (
            <Form.Item
              label="Range (km)"
              name="radius"
              rules={[{ required: true, message: 'Enter range' }]}
            >
              <InputNumber min={1} max={1000000} />
            </Form.Item>
          ) : (
            <Form.Item
              label="Number"
              name="count"
              rules={[{ required: true, message: 'Enter number' }]}
            >
              <InputNumber min={1} max={100} />
            </Form.Item>
          )}

          <Form.Item>
            <Button type="primary" htmlType="submit" loading={querying}>
              Search
            </Button>
          </Form.Item>
        </Form>
      )}

      {/* -------------------- */}
      {/* 🔸 Table Display */}
      {/* -------------------- */}
      {loading || querying ? (
        <Spin tip={loading ? 'Loading stations...' : 'Querying nearby stations...'} />
      ) : (
        <Table
          dataSource={displayedData}
          columns={columns}
          rowKey={(record) => record.m_Name || record.name}
          pagination={{ pageSize: 10 }}
        />
      )}
    </>
  );
}

export default AvailableStations;