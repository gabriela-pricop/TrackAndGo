import { useState, useEffect } from 'react';
import { regions } from '../data/regions';
import { POI } from '../types/poi';

interface UseMapReturn {
  selectedRegion: string | null;
  setSelectedRegion: (region: string | null) => void;
  filteredPOIs: POI[];
  selectedCategory: string | null;
  setSelectedCategory: (category: string | null) => void;
  categories: string[];
  loading: boolean;
}

export const useMap = (pois: POI[]): UseMapReturn => {
  const [selectedRegion, setSelectedRegion] = useState<string | null>(null);
  const [selectedCategory, setSelectedCategory] = useState<string | null>(null);
  const [filteredPOIs, setFilteredPOIs] = useState<POI[]>(pois);
  const [loading, setLoading] = useState(false);
  
  // Extract unique categories from POIs
  const categories = [...new Set(pois.map(poi => poi.category))];
  
  // Filter POIs based on selected region and category
  useEffect(() => {
    setLoading(true);
    
    let filtered = pois;
    
    if (selectedRegion) {
      const regionData = regions.find(r => r.name === selectedRegion);
      if (regionData) {
        filtered = filtered.filter(poi => poi.region === selectedRegion);
      }
    }
    
    if (selectedCategory) {
      filtered = filtered.filter(poi => poi.category === selectedCategory);
    }
    
    // Simulate loading delay for better UX
    const timer = setTimeout(() => {
      setFilteredPOIs(filtered);
      setLoading(false);
    }, 300);
    
    return () => clearTimeout(timer);
  }, [selectedRegion, selectedCategory, pois]);
  
  return {
    selectedRegion,
    setSelectedRegion,
    filteredPOIs,
    selectedCategory,
    setSelectedCategory,
    categories,
    loading
  };
};