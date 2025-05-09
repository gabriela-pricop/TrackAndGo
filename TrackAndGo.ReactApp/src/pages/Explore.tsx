import { useState, useEffect } from 'react';
import { motion } from 'framer-motion';
import { MapPin, Filter, Search } from 'lucide-react';
import { samplePOIs } from '../data/samplePOIs';
import { POI } from '../types/poi';
import { useMap } from '../hooks/useMap';
import MoldovaMap from '../components/map/MoldovaMap';
import POICard from '../components/pois/POICard';
import LoadingSpinner from '../components/ui/LoadingSpinner';

const Explore = () => {
  const [pois, setPois] = useState<POI[]>(samplePOIs);
  const [searchTerm, setSearchTerm] = useState('');
  const [showFilters, setShowFilters] = useState(false);
  const { 
    selectedRegion,
    setSelectedRegion,
    filteredPOIs,
    selectedCategory,
    setSelectedCategory,
    categories,
    loading
  } = useMap(pois);

  // Handle search
  const searchResults = searchTerm.trim() === '' 
    ? filteredPOIs 
    : filteredPOIs.filter(poi => 
        poi.name.toLowerCase().includes(searchTerm.toLowerCase()) ||
        poi.description.toLowerCase().includes(searchTerm.toLowerCase())
      );

  // Handle category filter
  const handleCategoryFilter = (category: string) => {
    if (selectedCategory === category) {
      setSelectedCategory(null);
    } else {
      setSelectedCategory(category);
    }
  };

  // Clear all filters
  const clearFilters = () => {
    setSelectedRegion(null);
    setSelectedCategory(null);
    setSearchTerm('');
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
          <h1 className="text-3xl md:text-4xl font-bold mb-2">Explore Moldova</h1>
          <p className="text-gray-600">
            Discover the most beautiful places and attractions in Moldova
          </p>
        </div>
        
        <div className="flex flex-col lg:flex-row gap-8">
          {/* Left column: Map and filters */}
          <div className="lg:w-1/2">
            <div className="bg-white rounded-xl shadow-md overflow-hidden h-[400px] md:h-[500px] mb-6">
              <MoldovaMap 
                pois={searchResults}
                selectedRegion={selectedRegion}
                setSelectedRegion={setSelectedRegion}
                loading={loading}
              />
            </div>
            
            <div className="bg-white rounded-xl shadow-md p-4 mb-6">
              <div className="flex items-center justify-between mb-4">
                <h2 className="text-lg font-semibold">Search & Filter</h2>
                <button 
                  onClick={() => setShowFilters(!showFilters)}
                  className="flex items-center text-gray-600 hover:text-emerald-600"
                >
                  <Filter size={18} className="mr-1" />
                  {showFilters ? 'Hide Filters' : 'Show Filters'}
                </button>
              </div>
              
              <div className="relative mb-4">
                <input
                  type="text"
                  placeholder="Search for attractions, wineries, monasteries..."
                  value={searchTerm}
                  onChange={(e) => setSearchTerm(e.target.value)}
                  className="w-full pl-10 pr-4 py-2 border border-gray-300 rounded-lg focus:outline-none focus:ring-2 focus:ring-emerald-500 focus:border-transparent"
                />
                <Search className="absolute left-3 top-2.5 text-gray-400" size={18} />
              </div>
              
              {showFilters && (
                <motion.div
                  initial={{ height: 0, opacity: 0 }}
                  animate={{ height: 'auto', opacity: 1 }}
                  exit={{ height: 0, opacity: 0 }}
                  transition={{ duration: 0.3 }}
                  className="space-y-4"
                >
                  <div>
                    <h3 className="text-sm font-medium text-gray-700 mb-2">Categories</h3>
                    <div className="flex flex-wrap gap-2">
                      {categories.map((category) => (
                        <button
                          key={category}
                          onClick={() => handleCategoryFilter(category)}
                          className={`category-filter-button ${selectedCategory === category ? 'active' : ''}`}
                        >
                          {category}
                        </button>
                      ))}
                    </div>
                  </div>
                  
                  {(selectedRegion || selectedCategory || searchTerm) && (
                    <div className="pt-2 border-t border-gray-100">
                      <button
                        onClick={clearFilters}
                        className="text-emerald-600 hover:text-emerald-700 text-sm font-medium"
                      >
                        Clear all filters
                      </button>
                    </div>
                  )}
                </motion.div>
              )}
            </div>
            
            <div className="bg-white rounded-xl shadow-md p-4">
              <h2 className="text-lg font-semibold mb-2">Current Filters</h2>
              
              <div className="space-y-2">
                {selectedRegion && (
                  <div className="flex items-center text-sm">
                    <MapPin size={16} className="text-emerald-600 mr-2" />
                    <span className="font-medium">Region:</span>
                    <span className="ml-2 bg-emerald-100 text-emerald-800 px-2 py-0.5 rounded-full flex items-center">
                      {selectedRegion}
                      <button 
                        onClick={() => setSelectedRegion(null)}
                        className="ml-1 text-emerald-800 hover:text-emerald-600"
                      >
                        ×
                      </button>
                    </span>
                  </div>
                )}
                
                {selectedCategory && (
                  <div className="flex items-center text-sm">
                    <Filter size={16} className="text-emerald-600 mr-2" />
                    <span className="font-medium">Category:</span>
                    <span className="ml-2 bg-emerald-100 text-emerald-800 px-2 py-0.5 rounded-full flex items-center">
                      {selectedCategory}
                      <button 
                        onClick={() => setSelectedCategory(null)}
                        className="ml-1 text-emerald-800 hover:text-emerald-600"
                      >
                        ×
                      </button>
                    </span>
                  </div>
                )}
                
                {searchTerm && (
                  <div className="flex items-center text-sm">
                    <Search size={16} className="text-emerald-600 mr-2" />
                    <span className="font-medium">Search:</span>
                    <span className="ml-2 bg-emerald-100 text-emerald-800 px-2 py-0.5 rounded-full flex items-center">
                      {searchTerm}
                      <button 
                        onClick={() => setSearchTerm('')}
                        className="ml-1 text-emerald-800 hover:text-emerald-600"
                      >
                        ×
                      </button>
                    </span>
                  </div>
                )}
                
                {!selectedRegion && !selectedCategory && !searchTerm && (
                  <p className="text-gray-500 text-sm">No filters applied. Use the map or filter options to refine results.</p>
                )}
              </div>
            </div>
          </div>
          
          {/* Right column: POI list */}
          <div className="lg:w-1/2">
            <div className="bg-white rounded-xl shadow-md p-6">
              <div className="flex items-center justify-between mb-6">
                <h2 className="text-xl font-semibold">
                  {searchResults.length} {searchResults.length === 1 ? 'Result' : 'Results'}
                </h2>
                
                <div className="text-sm text-gray-500">
                  {selectedRegion && `Region: ${selectedRegion}`}
                  {selectedRegion && selectedCategory && ' • '}
                  {selectedCategory && `Category: ${selectedCategory}`}
                </div>
              </div>
              
              {loading ? (
                <div className="py-12">
                  <LoadingSpinner size="md" />
                </div>
              ) : searchResults.length > 0 ? (
                <motion.div
                  variants={containerVariants}
                  initial="hidden"
                  animate="visible"
                  className="space-y-6"
                >
                  {searchResults.map((poi) => (
                    <motion.div key={poi.id} variants={itemVariants}>
                      <POICard poi={poi} />
                    </motion.div>
                  ))}
                </motion.div>
              ) : (
                <div className="py-12 text-center text-gray-500">
                  <Search size={48} className="mx-auto mb-4 text-gray-300" />
                  <h3 className="text-lg font-medium mb-2">No results found</h3>
                  <p>Try adjusting your search or filters to find what you're looking for.</p>
                  <button
                    onClick={clearFilters}
                    className="mt-4 text-emerald-600 font-medium hover:text-emerald-700"
                  >
                    Clear all filters
                  </button>
                </div>
              )}
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Explore;