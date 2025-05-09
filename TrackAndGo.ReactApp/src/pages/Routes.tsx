import { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { 
  MapPin, Route as RouteIcon, Navigation, ArrowRight, Search,
  Info, Plus, Minus, RefreshCw, MapIcon, X, ChevronRight
} from 'lucide-react';
import { samplePOIs } from '../data/samplePOIs';
import { regions } from '../data/regions';
import { POI } from '../types/poi';
import MoldovaMap from '../components/map/MoldovaMap';
import Button from '../components/ui/Button';
import POICard from '../components/pois/POICard';
import LoadingSpinner from '../components/ui/LoadingSpinner';

// Route point type
interface RoutePoint {
  name: string;
  location: {
    lat: number;
    lng: number;
  };
}

// Waypoint type for route display
interface Waypoint {
  location: {
    lat: number;
    lng: number;
  };
  name: string;
}

// Route type
interface Route {
  startPoint: RoutePoint;
  endPoint: RoutePoint;
  waypoints: Waypoint[];
  distance: string;
  duration: string;
}

const RoutesPage = () => {
  const [startPoint, setStartPoint] = useState<RoutePoint | null>(null);
  const [endPoint, setEndPoint] = useState<RoutePoint | null>(null);
  const [route, setRoute] = useState<Route | null>(null);
  const [loading, setLoading] = useState(false);
  const [searchTerm, setSearchTerm] = useState('');
  const [searchType, setSearchType] = useState<'start' | 'end'>('start');
  const [searchResults, setSearchResults] = useState<POI[]>([]);
  const [showSearchResults, setShowSearchResults] = useState(false);
  const [nearbyPOIs, setNearbyPOIs] = useState<POI[]>([]);
  const [mapCenter, setMapCenter] = useState<[number, number]>([47.0105, 28.8638]); // Moldova center
  const [mapZoom, setMapZoom] = useState(8);
  
  // Points for searching (regions + POIs)
  const allPoints = [
    ...regions.map(region => ({
      name: region.name,
      location: {
        lat: region.center.lat,
        lng: region.center.lng
      },
      type: 'region'
    })),
    ...samplePOIs.map(poi => ({
      name: poi.name,
      location: {
        lat: poi.location.lat,
        lng: poi.location.lng
      },
      type: 'poi',
      id: poi.id
    }))
  ];
  
  // Handle search
  const handleSearch = (term: string, type: 'start' | 'end') => {
    setSearchTerm(term);
    setSearchType(type);
    
    if (term.trim() === '') {
      setSearchResults([]);
      setShowSearchResults(false);
      return;
    }
    
    // Search for POIs matching the term
    const results = samplePOIs.filter(poi => 
      poi.name.toLowerCase().includes(term.toLowerCase()) ||
      poi.description.toLowerCase().includes(term.toLowerCase()) ||
      poi.region.toLowerCase().includes(term.toLowerCase())
    ).slice(0, 5);
    
    setSearchResults(results);
    setShowSearchResults(true);
  };
  
  // Select point as start or end
  const selectPoint = (poi: POI, type: 'start' | 'end') => {
    const point: RoutePoint = {
      name: poi.name,
      location: {
        lat: poi.location.lat,
        lng: poi.location.lng
      }
    };
    
    if (type === 'start') {
      setStartPoint(point);
    } else {
      setEndPoint(point);
    }
    
    setShowSearchResults(false);
    setSearchTerm('');
    
    // If both points are selected, center the map between them
    if ((type === 'start' && endPoint) || (type === 'end' && startPoint)) {
      const otherPoint = type === 'start' ? endPoint : startPoint;
      if (otherPoint) {
        const centerLat = (point.location.lat + otherPoint.location.lat) / 2;
        const centerLng = (point.location.lng + otherPoint.location.lng) / 2;
        setMapCenter([centerLat, centerLng]);
        setMapZoom(9);
      }
    }
  };
  
  // Clear point
  const clearPoint = (type: 'start' | 'end') => {
    if (type === 'start') {
      setStartPoint(null);
    } else {
      setEndPoint(null);
    }
    
    if (route) {
      setRoute(null);
      setNearbyPOIs([]);
    }
  };
  
  // Clear route
  const clearRoute = () => {
    setRoute(null);
    setNearbyPOIs([]);
  };
  
  // Calculate route
  const calculateRoute = () => {
    if (!startPoint || !endPoint) return;
    
    setLoading(true);
    
    // Simulate route calculation with a delay
    setTimeout(() => {
      // Generate random waypoints for demonstration
      const numWaypoints = Math.floor(Math.random() * 3) + 2; // 2-4 waypoints
      const waypoints: Waypoint[] = [];
      
      // Create waypoints between start and end
      for (let i = 1; i <= numWaypoints; i++) {
        const ratio = i / (numWaypoints + 1);
        const lat = startPoint.location.lat + (endPoint.location.lat - startPoint.location.lat) * ratio;
        const lng = startPoint.location.lng + (endPoint.location.lng - startPoint.location.lng) * ratio;
        
        const nearestPOI = samplePOIs.reduce((nearest, poi) => {
          const distance = Math.sqrt(
            Math.pow(poi.location.lat - lat, 2) + 
            Math.pow(poi.location.lng - lng, 2)
          );
          
          if (!nearest || distance < nearest.distance) {
            return { poi, distance };
          }
          return nearest;
        }, null as { poi: POI, distance: number } | null);
        
        if (nearestPOI) {
          waypoints.push({
            location: {
              lat: nearestPOI.poi.location.lat,
              lng: nearestPOI.poi.location.lng
            },
            name: nearestPOI.poi.name
          });
        } else {
          waypoints.push({
            location: { lat, lng },
            name: `Waypoint ${i}`
          });
        }
      }
      
      // Calculate simulated distance and duration
      const directDistance = Math.sqrt(
        Math.pow(endPoint.location.lat - startPoint.location.lat, 2) + 
        Math.pow(endPoint.location.lng - startPoint.location.lng, 2)
      ) * 111; // Rough conversion to km (1 degree ≈ 111 km)
      
      const distance = `${(directDistance * 1.2).toFixed(1)} km`; // Add 20% for non-direct route
      const duration = `${Math.ceil(directDistance * 1.2 / 60)} hours ${Math.round((directDistance * 1.2 % 60) / 60 * 60)} min`;
      
      // Create route
      const newRoute: Route = {
        startPoint,
        endPoint,
        waypoints,
        distance,
        duration
      };
      
      setRoute(newRoute);
      
      // Find nearby POIs along the route (for demo purposes, select POIs near waypoints)
      const poiIdsAlongRoute = new Set<string>();
      waypoints.forEach(waypoint => {
        const nearbyPOIs = samplePOIs
          .filter(poi => {
            const distance = Math.sqrt(
              Math.pow(poi.location.lat - waypoint.location.lat, 2) + 
              Math.pow(poi.location.lng - waypoint.location.lng, 2)
            ) * 111; // Convert to km
            return distance < 15; // POIs within 15km
          })
          .slice(0, 2);
        
        nearbyPOIs.forEach(poi => poiIdsAlongRoute.add(poi.id));
      });
      
      const routePOIs = samplePOIs.filter(poi => poiIdsAlongRoute.has(poi.id));
      setNearbyPOIs(routePOIs);
      
      // Center map to fit route
      const centerLat = (startPoint.location.lat + endPoint.location.lat) / 2;
      const centerLng = (startPoint.location.lng + endPoint.location.lng) / 2;
      setMapCenter([centerLat, centerLng]);
      setMapZoom(8); // Zoom out to see the full route
      
      setLoading(false);
    }, 1500);
  };
  
  // Use my current location
  const useCurrentLocation = () => {
    if (navigator.geolocation) {
      setLoading(true);
      navigator.geolocation.getCurrentPosition(
        (position) => {
          const { latitude, longitude } = position.coords;
          
          // Find nearest region
          const nearestRegion = regions.reduce((nearest, region) => {
            const distance = Math.sqrt(
              Math.pow(region.center.lat - latitude, 2) + 
              Math.pow(region.center.lng - longitude, 2)
            );
            
            if (!nearest || distance < nearest.distance) {
              return { region, distance };
            }
            return nearest;
          }, null as { region: typeof regions[0], distance: number } | null);
          
          if (nearestRegion) {
            const point: RoutePoint = {
              name: `Your location (near ${nearestRegion.region.name})`,
              location: {
                lat: latitude,
                lng: longitude
              }
            };
            
            setStartPoint(point);
            setMapCenter([latitude, longitude]);
            setMapZoom(10);
          }
          
          setLoading(false);
        },
        (error) => {
          console.error('Error getting location:', error);
          setLoading(false);
          // Use Chișinău as fallback
          const chisinau = regions.find(r => r.name === 'Chișinău');
          if (chisinau) {
            const point: RoutePoint = {
              name: 'Chișinău (default)',
              location: {
                lat: chisinau.center.lat,
                lng: chisinau.center.lng
              }
            };
            setStartPoint(point);
          }
        }
      );
    }
  };
  
  // Animation variants
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        staggerChildren: 0.1
      }
    }
  };
  
  const itemVariants = {
    hidden: { y: 20, opacity: 0 },
    visible: {
      y: 0,
      opacity: 1,
      transition: {
        duration: 0.3
      }
    }
  };
  
  return (
    <div className="min-h-screen pt-20 pb-10">
      <div className="container mx-auto px-4">
        <div className="mb-8">
          <motion.h1 
            className="text-3xl md:text-4xl font-bold mb-2"
            initial={{ opacity: 0, y: -20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.5 }}
          >
            Plan Your Route in Moldova
          </motion.h1>
          <motion.p 
            className="text-gray-600"
            initial={{ opacity: 0 }}
            animate={{ opacity: 1 }}
            transition={{ duration: 0.5, delay: 0.2 }}
          >
            Discover the best way to explore Moldova's attractions with custom routes
          </motion.p>
        </div>
        
        <div className="flex flex-col lg:flex-row gap-8">
          {/* Left column: Map and controls */}
          <div className="lg:w-2/3">
            <motion.div 
              className="bg-white rounded-xl shadow-md overflow-hidden"
              initial={{ opacity: 0, y: 20 }}
              animate={{ opacity: 1, y: 0 }}
              transition={{ duration: 0.5 }}
            >
              <div className="h-[500px] md:h-[600px]">
                {/* This would be replaced with actual route rendering */}
                <MoldovaMap 
                  pois={nearbyPOIs}
                  selectedRegion={null}
                  setSelectedRegion={() => {}}
                  loading={loading}
                />
              </div>
            </motion.div>
            
            {/* Route information */}
            {route && (
              <motion.div 
                className="mt-6 bg-white rounded-xl shadow-md p-6"
                initial={{ opacity: 0, height: 0 }}
                animate={{ opacity: 1, height: 'auto' }}
                transition={{ duration: 0.5 }}
              >
                <div className="flex justify-between items-center mb-4">
                  <h2 className="text-xl font-semibold">Route Details</h2>
                  <button 
                    onClick={clearRoute}
                    className="text-gray-500 hover:text-red-500 transition-colors"
                  >
                    <RefreshCw size={18} />
                  </button>
                </div>
                
                <div className="flex items-center mb-4">
                  <div className="font-medium text-gray-700 flex-grow">
                    <div className="flex items-center mb-2">
                      <div className="w-8 h-8 rounded-full bg-emerald-100 flex items-center justify-center mr-2">
                        <MapPin size={16} className="text-emerald-600" />
                      </div>
                      <span>{route.startPoint.name}</span>
                    </div>
                    
                    <div className="flex items-center relative pl-4 ml-4 my-3">
                      <div className="absolute left-0 top-0 bottom-0 w-0.5 bg-emerald-200 rounded-full"></div>
                      <div className="font-medium text-sm text-gray-500">
                        {route.waypoints.length} stops • {route.distance} • {route.duration}
                      </div>
                    </div>
                    
                    <div className="flex items-center">
                      <div className="w-8 h-8 rounded-full bg-emerald-100 flex items-center justify-center mr-2">
                        <MapPin size={16} className="text-emerald-600" />
                      </div>
                      <span>{route.endPoint.name}</span>
                    </div>
                  </div>
                  
                  <div className="flex flex-col items-end">
                    <div className="text-2xl font-bold text-emerald-600 mb-1">{route.distance}</div>
                    <div className="text-sm text-gray-500">{route.duration}</div>
                  </div>
                </div>
                
                <div className="mt-4 pt-4 border-t border-gray-100">
                  <h3 className="font-medium mb-2">Waypoints:</h3>
                  <div className="space-y-2">
                    {route.waypoints.map((waypoint, index) => (
                      <div key={index} className="flex items-center text-sm text-gray-700">
                        <div className="w-6 h-6 rounded-full bg-gray-100 flex items-center justify-center mr-2 text-xs font-medium">
                          {index + 1}
                        </div>
                        <span>{waypoint.name}</span>
                      </div>
                    ))}
                  </div>
                </div>
              </motion.div>
            )}
          </div>
          
          {/* Right column: Route controls */}
          <div className="lg:w-1/3">
            <motion.div 
              className="bg-white rounded-xl shadow-md p-6 mb-6"
              initial={{ opacity: 0, x: 20 }}
              animate={{ opacity: 1, x: 0 }}
              transition={{ duration: 0.5 }}
            >
              <h2 className="text-xl font-semibold mb-4">Create Your Route</h2>
              
              <div className="space-y-6">
                {/* Start point */}
                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    Start Point
                  </label>
                  <div className="relative">
                    {startPoint ? (
                      <div className="flex items-center justify-between px-3 py-2 border border-gray-300 rounded-md">
                        <div className="flex items-center">
                          <MapPin size={16} className="text-emerald-600 mr-2" />
                          <span>{startPoint.name}</span>
                        </div>
                        <button 
                          onClick={() => clearPoint('start')}
                          className="text-gray-400 hover:text-red-500"
                        >
                          <X size={16} />
                        </button>
                      </div>
                    ) : (
                      <div className="flex">
                        <input
                          type="text"
                          placeholder="Search for a starting point..."
                          value={searchType === 'start' ? searchTerm : ''}
                          onChange={(e) => handleSearch(e.target.value, 'start')}
                          onFocus={() => setSearchType('start')}
                          className="flex-grow px-3 py-2 border border-gray-300 rounded-l-md focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent"
                        />
                        <button
                          onClick={useCurrentLocation}
                          className="px-3 py-2 bg-emerald-600 text-white rounded-r-md hover:bg-emerald-700 transition-colors"
                          title="Use my current location"
                        >
                          <Navigation size={16} />
                        </button>
                      </div>
                    )}
                    
                    {searchType === 'start' && showSearchResults && (
                      <div className="absolute z-10 w-full mt-1 bg-white rounded-md shadow-lg max-h-60 overflow-y-auto">
                        {searchResults.length > 0 ? (
                          <ul className="py-1">
                            {searchResults.map((poi) => (
                              <li key={poi.id} className="px-3 py-2 hover:bg-gray-100 cursor-pointer" onClick={() => selectPoint(poi, 'start')}>
                                <div className="flex items-center">
                                  <MapPin size={16} className="text-emerald-600 mr-2" />
                                  <div>
                                    <div className="font-medium">{poi.name}</div>
                                    <div className="text-xs text-gray-500">{poi.region}, Moldova</div>
                                  </div>
                                </div>
                              </li>
                            ))}
                          </ul>
                        ) : (
                          <div className="px-3 py-2 text-gray-500">No results found</div>
                        )}
                      </div>
                    )}
                  </div>
                </div>
                
                {/* End point */}
                <div>
                  <label className="block text-sm font-medium text-gray-700 mb-1">
                    End Point
                  </label>
                  <div className="relative">
                    {endPoint ? (
                      <div className="flex items-center justify-between px-3 py-2 border border-gray-300 rounded-md">
                        <div className="flex items-center">
                          <MapPin size={16} className="text-emerald-600 mr-2" />
                          <span>{endPoint.name}</span>
                        </div>
                        <button 
                          onClick={() => clearPoint('end')}
                          className="text-gray-400 hover:text-red-500"
                        >
                          <X size={16} />
                        </button>
                      </div>
                    ) : (
                      <div className="flex">
                        <input
                          type="text"
                          placeholder="Search for an end point..."
                          value={searchType === 'end' ? searchTerm : ''}
                          onChange={(e) => handleSearch(e.target.value, 'end')}
                          onFocus={() => setSearchType('end')}
                          className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent"
                        />
                      </div>
                    )}
                    
                    {searchType === 'end' && showSearchResults && (
                      <div className="absolute z-10 w-full mt-1 bg-white rounded-md shadow-lg max-h-60 overflow-y-auto">
                        {searchResults.length > 0 ? (
                          <ul className="py-1">
                            {searchResults.map((poi) => (
                              <li key={poi.id} className="px-3 py-2 hover:bg-gray-100 cursor-pointer" onClick={() => selectPoint(poi, 'end')}>
                                <div className="flex items-center">
                                  <MapPin size={16} className="text-emerald-600 mr-2" />
                                  <div>
                                    <div className="font-medium">{poi.name}</div>
                                    <div className="text-xs text-gray-500">{poi.region}, Moldova</div>
                                  </div>
                                </div>
                              </li>
                            ))}
                          </ul>
                        ) : (
                          <div className="px-3 py-2 text-gray-500">No results found</div>
                        )}
                      </div>
                    )}
                  </div>
                </div>
                
                {/* Calculate button */}
                <div>
                  <Button
                    onClick={calculateRoute}
                    disabled={!startPoint || !endPoint || loading}
                    isLoading={loading}
                    fullWidth
                  >
                    {loading ? 'Calculating...' : 'Calculate Route'} 
                    {!loading && <RouteIcon size={16} className="ml-2" />}
                  </Button>
                </div>
              </div>
            </motion.div>
            
            {/* Nearby attractions */}
            <motion.div 
              className="bg-white rounded-xl shadow-md p-6"
              initial={{ opacity: 0, x: 20 }}
              animate={{ opacity: 1, x: 0 }}
              transition={{ duration: 0.5, delay: 0.2 }}
            >
              <h2 className="text-xl font-semibold mb-4">
                {nearbyPOIs.length > 0 ? 'Attractions Along Your Route' : 'Popular Attractions'}
              </h2>
              
              {loading ? (
                <div className="py-12 flex justify-center">
                  <LoadingSpinner size="md" />
                </div>
              ) : nearbyPOIs.length > 0 ? (
                <motion.div
                  variants={containerVariants}
                  initial="hidden"
                  animate="visible"
                  className="space-y-4"
                >
                  {nearbyPOIs.map((poi) => (
                    <motion.div key={poi.id} variants={itemVariants}>
                      <POICard poi={poi} compact />
                    </motion.div>
                  ))}
                </motion.div>
              ) : (
                <div className="space-y-4">
                  {samplePOIs.slice(0, 3).map((poi) => (
                    <POICard key={poi.id} poi={poi} compact />
                  ))}
                </div>
              )}
              
              <div className="mt-4 text-center">
                <a href="/explore" className="text-emerald-600 font-medium flex items-center justify-center hover:text-emerald-700 transition-colors">
                  Explore all attractions <ChevronRight size={16} className="ml-1" />
                </a>
              </div>
            </motion.div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default RoutesPage;