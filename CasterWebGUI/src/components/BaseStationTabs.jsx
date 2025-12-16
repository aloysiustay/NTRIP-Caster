import React from 'react';
import { Tabs } from 'antd';
import AvailableStations from './AvailableStations';
import NearestStations from './NearestStations';
import MapPage from './MapPage';

const { TabPane } = Tabs;

function BaseStationTabs({ stations, loading, onQuery, querying, results }) {
  return (
    <Tabs defaultActiveKey="1-1">
      <TabPane tab="Available Stations" key="1-1">
        <AvailableStations stations={stations} loading={loading} />
      </TabPane>
      <TabPane tab="Map" key="1-2">
        <MapPage stations={stations} />
      </TabPane>
      <TabPane tab="Find Nearest" key="1-3">
        <NearestStations onQuery={onQuery} querying={querying} results={results} />
      </TabPane>
    </Tabs>
  );
}

export default BaseStationTabs;
