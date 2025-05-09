import { useState, useEffect } from 'react';
import Map, { Marker, Popup } from 'react-map-gl';
import 'mapbox-gl/dist/mapbox-gl.css';
import { POI } from '../../types/poi';
import { regions, moldovaBounds } from '../../data/regions';
import LoadingSpinner from '../ui/LoadingSpinner';

const MAPBOX_TOKEN = 'pk.eyJ1IjoiaXZhbXB5eXkiLCJhIjoiY21hY3phcnE1MDk5eTJrc2gyZXRxcXk2MyJ9.WSIdw9c4xM9PWhQvKvoB0g';

interface MoldovaMapProps {
  pois: POI[];
  selectedRegion: string | null;
  setSelectedRegion: (region: string | null) => void;
  loading?: boolean;
}

const MoldovaMap = ({ pois, selectedRegion, setSelectedRegion, loading = false }: MoldovaMapProps) => {
  const [viewport, setViewport] = useState({
    latitude: 47.0105,
    longitude: 28.8638,
    zoom: 7
  });
  const [selectedPOI, setSelectedPOI] = useState<POI | null>(null);

  useEffect(() => {
    if (selectedRegion) {
      const region = regions.find(r => r.name === selectedRegion);
      if (region) {
        setViewport({
          latitude: region.center.lat,
          longitude: region.center.lng,
          zoom: 10
        });
      }
    } else {
      setViewport({
        latitude: 47.0105,
        longitude: 28.8638,
        zoom: 7
      });
    }
  }, [selectedRegion]);

  return (
    <div className="relative h-full w-full">
      {loading && (
        <div className="absolute inset-0 z-10 bg-white bg-opacity-70 flex items-center justify-center">
          <LoadingSpinner size="md" />
        </div>
      )}
      
      <Map
        {...viewport}
        onMove={evt => setViewport(evt.viewState)}
        style={{ width: '100%', height: '100%' }}
        mapStyle="mapbox://styles/mapbox/streets-v12"
        mapboxAccessToken={MAPBOX_TOKEN}
      >
        {pois.map((poi) => (
          <Marker
            key={poi.id}
            latitude={poi.location.lat}
            longitude={poi.location.lng}
            onClick={e => {
              e.originalEvent.stopPropagation();
              setSelectedPOI(poi);
            }}
          >
            <div className="cursor-pointer text-emerald-600 hover:text-emerald-700 transition-colors">
              <svg
                viewBox="0 0 24 24"
                width="24"
                height="24"
                stroke="currentColor"
                strokeWidth="2"
                fill="none"
                strokeLinecap="round"
                strokeLinejoin="round"
              >
                <path d="M21 10c0 7-9 13-9 13s-9-6-9-13a9 9 0 0 1 18 0z"></path>
                <circle cx="12" cy="10" r="3"></circle>
              </svg>
            </div>
          </Marker>
        ))}

        {selectedPOI && (
          <Popup
            latitude={selectedPOI.location.lat}
            longitude={selectedPOI.location.lng}
            onClose={() => setSelectedPOI(null)}
            closeButton={true}
            closeOnClick={false}
            anchor="bottom"
          >
            <div className="min-w-[200px] p-2">
              <h3 className="font-semibold text-base">{selectedPOI.name}</h3>
              <p className="text-sm text-gray-600 mb-2">
                <span className="inline-block bg-emerald-100 text-emerald-800 text-xs px-2 py-0.5 rounded-full mr-1">
                  {selectedPOI.category}
                </span>
                <span className="text-gray-500">{selectedPOI.region}</span>
              </p>
              <p className="text-sm line-clamp-2 mb-2">{selectedPOI.description}</p>
              <a 
                href={`/poi/${selectedPOI.id}`}
                className="text-emerald-600 text-sm font-medium hover:text-emerald-700"
              >
                View Details
              </a>
            </div>
          </Popup>
        )}
      </Map>
    </div>
  );
};

export default MoldovaMap;