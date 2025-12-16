// MapPage.jsx
import React, { useEffect, useRef, useState } from 'react';
import {
  Viewer,
  Cartesian3,
  Color,
  buildModuleUrl,
  ScreenSpaceEventHandler,
  ScreenSpaceEventType,
  SceneMode,
  createWorldTerrainAsync,
  VerticalOrigin,
  HeightReference,
  LabelStyle,
  Cartesian2
} from 'cesium';
import 'cesium/Build/Cesium/Widgets/widgets.css';

buildModuleUrl.setBaseUrl('/Cesium/');

export default function MapPage({ stations = [] }) {
  const viewerRef = useRef(null);
  const [terrainProvider, setTerrainProvider] = useState(null);

  useEffect(() => {
    // load terrain asynchronously
    (async () => {
      try {
        const tp = await createWorldTerrainAsync();
        setTerrainProvider(tp);
      } catch (err) {
        console.error('Error creating terrain provider:', err);
      }
    })();
  }, []);

  useEffect(() => {
    if (!terrainProvider) return;

    const viewer = new Viewer(viewerRef.current, {
      terrainProvider,
      animation: false,
      timeline: false,
      geocoder: false,
      fullscreenButton: false,
      sceneMode: SceneMode.SCENE2D
    });

    stations
      .filter(s => s.m_Lat != null && s.m_Lon != null)
      .forEach(s => {
        viewer.entities.add({
          id: s.m_Name,
          name: s.m_Name,
          position: Cartesian3.fromDegrees(s.m_Lon, s.m_Lat),
          //point: { pixelSize: 10, color: Color.BLACK },
          billboard: {
            image: '/icons/marker.png', // 👈 place your custom icon in public/icons/
            scale: 0.05,
            verticalOrigin: VerticalOrigin.BOTTOM, // anchor bottom
            heightReference: HeightReference.NONE, // optional, keep on ground
            disableDepthTestDistance: Number.POSITIVE_INFINITY
          },
          label: {
            text: s.m_Name, // 👈 what to show beside the icon
            font: '14px sans-serif',
            fillColor: Color.WHITE,
            outlineColor: Color.BLACK,
            outlineWidth: 2,
            style: LabelStyle.FILL_AND_OUTLINE,
            verticalOrigin: VerticalOrigin.TOP,
            pixelOffset: new Cartesian2(0, -40), // move label above marker
          },
          description: `
            <strong>${s.m_Name}</strong><br/>
            Identifier: ${s.m_Identifier}<br/>
            Format: ${s.m_Format}<br/>
            Country: ${s.m_Country}<br/>
            Lat: ${s.m_Lat}<br/>
            Lon: ${s.m_Lon}
          `
        });
      });

    return () => viewer.destroy();
  }, [terrainProvider, stations]);

  return <div ref={viewerRef} style={{ width: '100%', height: '100vh' }} />;
}
