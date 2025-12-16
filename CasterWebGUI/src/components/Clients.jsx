import React from 'react';
import { Typography, Table } from 'antd';

const { Title } = Typography;

function Clients({ clients }) {
  const columns = [
    {
      title: 'Client ID',
      dataIndex: 'm_ClientID',
      key: 'm_ClientID',
    },
    {
      title: 'Mountpoint',
      dataIndex: 'm_Mountpoint',
      key: 'm_Mountpoint',
    },
    {
      title: 'Latitude',
      dataIndex: 'm_Latitude',
      key: 'm_Latitude',
      render: (value) => value.toFixed(6),
    },
    {
      title: 'Longitude',
      dataIndex: 'm_Longitude',
      key: 'm_Longitude',
      render: (value) => value.toFixed(6),
    },
    {
      title: 'Altitude (m)',
      dataIndex: 'm_Altitude',
      key: 'm_Altitude',
      render: (value) => value.toFixed(2),
    },
  ];

  return (
    <>
      <Title level={4}>Connected Clients</Title>
      <Table
        columns={columns}
        dataSource={clients}
        rowKey="m_ClientID"
        pagination={false}
      />
    </>
  );
}

export default Clients;
