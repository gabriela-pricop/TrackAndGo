import React, { createContext, useContext, useEffect, useState } from 'react';
import { POI } from '../types/poi';
import { samplePOIs } from '../data/samplePOIs';

interface POIContextType {
  pois: POI[];
  addPOI: (poi: POI) => void;
}

const POIContext = createContext<POIContextType | undefined>(undefined);

const LOCAL_STORAGE_KEY = 'poiList';

const loadInitialPOIs = (): POI[] => {
    const stored = localStorage.getItem(LOCAL_STORAGE_KEY);
    const storedPOIs: POI[] = stored ? JSON.parse(stored) : [];
  
    // Add sample POIs that are not already present (based on ID)
    const merged = [...storedPOIs];
    samplePOIs.forEach(sample => {
      const alreadyExists = storedPOIs.some(p => p.id === sample.id);
      if (!alreadyExists) {
        merged.push(sample);
      }
    });
  
    return merged;
  };

export const POIProvider: React.FC<{ children: React.ReactNode }> = ({ children }) => {
  const [pois, setPois] = useState<POI[]>(loadInitialPOIs());

  const addPOI = (poi: POI) => {
    setPois(prev => [...prev, poi]);
  };

  useEffect(() => {
    localStorage.setItem(LOCAL_STORAGE_KEY, JSON.stringify(pois));
  }, [pois]);

  return (
    <POIContext.Provider value={{ pois, addPOI }}>
      {children}
    </POIContext.Provider>
  );
};

export const usePOIContext = () => {
  const context = useContext(POIContext);
  if (!context) throw new Error('usePOIContext must be used within a POIProvider');
  return context;
};
