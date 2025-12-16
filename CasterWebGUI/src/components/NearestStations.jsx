import React, { useState } from 'react';
import { Form, InputNumber, Button, Typography, Table, Radio, Spin } from 'antd';

const { Title } = Typography;

function NearestStations({ onQuery, querying, results }) {
  const [form] = Form.useForm();
  const [mode, setMode] = useState('radius');

  const columns = [
    { title: 'Name', dataIndex: 'name', key: 'name' },
    { title: 'Latitude', dataIndex: 'lat', key: 'lat' },
    { title: 'Longitude', dataIndex: 'lon', key: 'lon' },
    { title: 'Distance (km)', dataIndex: 'distance', key: 'distance', render: (text) => Number(text).toFixed(2) },
  ];

  const handleModeChange = (e) => {
    setMode(e.target.value);
    form.resetFields(['count', 'radius']);
  };

  const handleSubmit = (values) => {
    const { lat, lon, count, radius } = values;
    onQuery({ lat, lon, count, radius, mode });
  };

  return (
    <>
      <Title level={4}>Find Nearest Base Stations</Title>


      <Form
        form={form}
        layout="vertical"
        onFinish={handleSubmit}
        style={{ maxWidth: 400 }}
      >
        <Form.Item label="Latitude" name="lat" rules={[{ required: true }]}>
          <InputNumber min={-90} max={90} style={{ width: '100%' }} placeholder="e.g., 1.3521" />
        </Form.Item>

        <Form.Item label="Longitude" name="lon" rules={[{ required: true }]}>
          <InputNumber min={-180} max={180} style={{ width: '100%' }} placeholder="e.g., 103.8198" />
        </Form.Item>

      <Radio.Group onChange={handleModeChange} value={mode} style={{ marginBottom: 16 }}>
        <Radio value="radius">By Radius (km)</Radio>
        <Radio value="count">By Number</Radio>
      </Radio.Group>

        {mode === 'radius' && (
          <Form.Item label="Radius (km)" name="radius" rules={[{ required: true }]}>
            <InputNumber min={0} max={1000000} step={1} style={{ width: '100%' }} />
          </Form.Item>
        )}

        {mode === 'count' && (
          <Form.Item label="Number of Base Stations" name="count" rules={[{ required: true }]}>
            <InputNumber min={1} max={100} style={{ width: '100%' }} />
          </Form.Item>
        )}

        <Form.Item>
          <Button type="primary" htmlType="submit" loading={querying}>
            Submit
          </Button>
        </Form.Item>
      </Form>

      {querying ? (
        <Spin tip="Loading nearest stations..." />
      ) : results.length > 0 ? (
        <>
          <Title level={5} style={{ marginTop: '1rem' }}>
            Nearest Stations ({results.length})
          </Title>
          <Table dataSource={results} columns={columns} rowKey="name" pagination={false} />
        </>
      ) : null}
    </>
  );
}

export default NearestStations;
