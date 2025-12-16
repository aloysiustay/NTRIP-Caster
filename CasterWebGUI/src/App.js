import React, { useEffect, useState } from 'react';
import { Layout, Tabs, Spin, message } from 'antd';
import axios from 'axios';

import BaseStationTabs from './components/BaseStationTabs';
import Clients from './components/Clients';
import { BASE_API_URL } from './Config';

const { Header, Content, Footer } = Layout;
const { TabPane } = Tabs;

function App() {
  const [stations, setStations] = useState([]);
  const [loading, setLoading] = useState(true);
  const [nearbyStations, setNearbyStations] = useState([]);
  const [querying, setQuerying] = useState(false);

  // 🔹 Clients state
  const [clients, setClients] = useState([]);
  const [clientsLoading, setClientsLoading] = useState(true);

  // ------------------------------
  // 🔹 Fetch Base Stations
  // ------------------------------
  useEffect(() => {
    axios
      .get(`${BASE_API_URL}/api/Caster/mountpointList`)
      .then((res) => setStations(res.data.stations || []))
      .catch((err) => console.error('Failed to fetch stations:', err))
      .finally(() => setLoading(false));
  }, []);

  // ------------------------------
  // 🔹 Fetch Clients
  // ------------------------------
  useEffect(() => {
    const fetchClients = async () => {
      try {
        const res = await axios.get(`${BASE_API_URL}/api/Caster/clientList`);
        setClients(res.data.sessionInfo || []);
      } catch (err) {
        console.error('Failed to fetch clients:', err);
        message.error('Unable to load clients.');
      } finally {
        setClientsLoading(false);
      }
    };

    fetchClients();
  }, []);

  return (
    <Layout style={{ minHeight: '100vh' }}>
      <Header style={{ color: 'white', fontSize: '20px' }}>
        NTRIP Caster Web GUI
      </Header>

      <Content style={{ padding: '2rem' }}>
        <Tabs defaultActiveKey="1">
          <TabPane tab="Base Station" key="1">
            <BaseStationTabs
              stations={stations}
              loading={loading}
              querying={querying}
              results={nearbyStations}
            />
          </TabPane>

          <TabPane tab="Clients" key="2">
            {clientsLoading ? (
              <Spin tip="Loading clients..." />
            ) : (
              <Clients clients={clients} />
            )}
          </TabPane>
        </Tabs>
      </Content>

      <Footer style={{ textAlign: 'center' }}>
        NTRIP Caster Web GUI ©2025
      </Footer>
    </Layout>
  );
}

export default App;