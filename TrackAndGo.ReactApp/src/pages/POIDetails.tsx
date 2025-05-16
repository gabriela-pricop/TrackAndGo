import { useState, useEffect } from 'react';
import { useParams, Link } from 'react-router-dom';
import { 
  MapPin, Star, Clock, Phone, Mail, Globe, Share2, 
  Heart, Calendar, ChevronLeft, ChevronRight, Info, 
  Hotel, Utensils, GlassWater 
} from 'lucide-react';
import { motion } from 'framer-motion';
import { samplePOIs } from '../data/samplePOIs';
import { POI } from '../types/poi';
import Button from '../components/ui/Button';
import POICard from '../components/pois/POICard';
import LoadingSpinner from '../components/ui/LoadingSpinner';
import { usePOIContext } from '../contexts/POIContext';

const POIDetails = () => {
  const { id } = useParams<{ id: string }>();
  const { pois } = usePOIContext();
  const [poi, setPoi] = useState<POI | null>(null);
  const [loading, setLoading] = useState(true);
  const [currentImageIndex, setCurrentImageIndex] = useState(0);
  const [similarPOIs, setSimilarPOIs] = useState<POI[]>([]);
  const [activeTab, setActiveTab] = useState<'info' | 'map' | 'nearby'>('info');
  const [showFullDescription, setShowFullDescription] = useState(false);
  
  useEffect(() => {
    // Simulate loading
    setLoading(true);
    
    // Find POI by ID
    const foundPOI = pois.find(p => p.id === id);
    
    // Find similar POIs (same category or region)
    let similar: POI[] = [];
    if (foundPOI) {
      similar = pois
        .filter(p => p.id !== id && (p.category === foundPOI.category || p.region === foundPOI.region))
        .slice(0, 3);
    }
    
    // Simulate API delay
    setTimeout(() => {
      setPoi(foundPOI || null);
      setSimilarPOIs(similar);
      setLoading(false);
    }, 500);
  }, [id, pois]);
  
  const handlePrevImage = () => {
    if (poi) {
      setCurrentImageIndex((prevIndex) => (
        prevIndex === 0 ? poi.images.length - 1 : prevIndex - 1
      ));
    }
  };
  
  const handleNextImage = () => {
    if (poi) {
      setCurrentImageIndex((prevIndex) => (
        prevIndex === poi.images.length - 1 ? 0 : prevIndex + 1
      ));
    }
  };
  
  if (loading) {
    return (
      <div className="min-h-screen pt-24 pb-10 flex items-center justify-center">
        <LoadingSpinner size="lg" />
      </div>
    );
  }
  
  if (!poi) {
    return (
      <div className="min-h-screen pt-24 pb-10">
        <div className="container mx-auto px-4 text-center">
          <Info size={48} className="mx-auto mb-4 text-gray-300" />
          <h2 className="text-2xl font-bold mb-4">Point of Interest Not Found</h2>
          <p className="text-gray-600 mb-8">The point of interest you're looking for doesn't exist or has been removed.</p>
          <Link to="/explore" className="text-emerald-600 hover:text-emerald-700 font-medium">
            Back to Explore
          </Link>
        </div>
      </div>
    );
  }
  
  return (
    <div className="min-h-screen pt-20 pb-10">
      <div className="container mx-auto px-4">
        {/* Back navigation */}
        <div className="mb-6">
          <Link 
            to="/explore" 
            className="inline-flex items-center text-emerald-600 hover:text-emerald-700 font-medium"
          >
            <ChevronLeft size={18} className="mr-1" />
            Back to Explore
          </Link>
        </div>
        
        <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
          {/* Left Column: Main Content */}
          <div className="lg:col-span-2">
            {/* Image gallery */}
            <div className="relative rounded-xl overflow-hidden mb-6 bg-gray-100 shadow-md">
              <div className="relative h-64 md:h-96">
                <motion.img 
                  key={currentImageIndex}
                  src={poi.images[currentImageIndex]} 
                  alt={poi.name} 
                  className="w-full h-full object-cover"
                  initial={{ opacity: 0 }}
                  animate={{ opacity: 1 }}
                  transition={{ duration: 0.5 }}
                />
                
                {/* Image navigation */}
                {poi.images.length > 1 && (
                  <>
                    <button 
                      onClick={handlePrevImage}
                      className="absolute left-2 top-1/2 transform -translate-y-1/2 bg-black bg-opacity-50 rounded-full p-2 text-white hover:bg-opacity-70 transition-all"
                      aria-label="Previous image"
                    >
                      <ChevronLeft size={20} />
                    </button>
                    <button 
                      onClick={handleNextImage}
                      className="absolute right-2 top-1/2 transform -translate-y-1/2 bg-black bg-opacity-50 rounded-full p-2 text-white hover:bg-opacity-70 transition-all"
                      aria-label="Next image"
                    >
                      <ChevronRight size={20} />
                    </button>
                    <div className="absolute bottom-2 left-0 right-0 flex justify-center space-x-2">
                      {poi.images.map((_, index) => (
                        <button
                          key={index}
                          onClick={() => setCurrentImageIndex(index)}
                          className={`w-2 h-2 rounded-full ${currentImageIndex === index ? 'bg-white' : 'bg-white bg-opacity-50'}`}
                          aria-label={`Go to image ${index + 1}`}
                        />
                      ))}
                    </div>
                  </>
                )}
                
                {/* Category badge */}
                <div className="absolute top-4 left-4 bg-emerald-600 text-white text-sm font-semibold px-3 py-1 rounded-full">
                  {poi.category}
                </div>
              </div>
            </div>
            
            {/* Main content */}
            <div className="bg-white rounded-xl shadow-md p-6 mb-6">
              <div className="mb-6">
                <div className="flex items-center mb-2">
                  <MapPin size={16} className="text-emerald-600 mr-1" />
                  <span className="text-sm text-gray-500">{poi.region}, Moldova</span>
                </div>
                
                <h1 className="text-2xl md:text-3xl font-bold mb-2">{poi.name}</h1>
                
                <div className="flex items-center mb-4 text-sm">
                  {poi.rating && (
                    <div className="flex items-center mr-4">
                      <Star size={16} className="text-yellow-500 mr-1" />
                      <span className="font-medium">{poi.rating}</span>
                      <span className="mx-1 text-gray-400">•</span>
                      <span className="text-gray-500">{poi.reviews} reviews</span>
                    </div>
                  )}
                  <div className="flex items-center">
                    <Calendar size={16} className="text-gray-400 mr-1" />
                    <span className="text-gray-500">Added on {new Date(poi.createdAt).toLocaleDateString()}</span>
                  </div>
                </div>
                
                <div className="flex flex-wrap gap-2 mb-6">
                  <button className="inline-flex items-center px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-600 transition-colors">
                    <Heart size={16} className="mr-1" />
                    Save
                  </button>
                  <button className="inline-flex items-center px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-600 transition-colors">
                    <Share2 size={16} className="mr-1" />
                    Share
                  </button>
                </div>
                
                <div className="mb-4">
                  <p className={`text-gray-700 ${!showFullDescription && 'line-clamp-4'}`}>
                    {poi.description}
                  </p>
                  {poi.description.length > 250 && (
                    <button 
                      onClick={() => setShowFullDescription(!showFullDescription)}
                      className="mt-2 text-emerald-600 text-sm font-medium hover:text-emerald-700"
                    >
                      {showFullDescription ? 'Show less' : 'Read more'}
                    </button>
                  )}
                </div>
              </div>
              
              {/* Tabs */}
              <div className="border-b border-gray-200 mb-4">
                <div className="flex space-x-8">
                  <button 
                    onClick={() => setActiveTab('info')}
                    className={`py-2 text-sm font-medium border-b-2 ${activeTab === 'info' ? 'border-emerald-500 text-emerald-600' : 'border-transparent text-gray-500 hover:text-gray-700'}`}
                  >
                    Details
                  </button>
                  <button 
                    onClick={() => setActiveTab('map')}
                    className={`py-2 text-sm font-medium border-b-2 ${activeTab === 'map' ? 'border-emerald-500 text-emerald-600' : 'border-transparent text-gray-500 hover:text-gray-700'}`}
                  >
                    Location & Map
                  </button>
                  <button 
                    onClick={() => setActiveTab('nearby')}
                    className={`py-2 text-sm font-medium border-b-2 ${activeTab === 'nearby' ? 'border-emerald-500 text-emerald-600' : 'border-transparent text-gray-500 hover:text-gray-700'}`}
                  >
                    Nearby
                  </button>
                </div>
              </div>
              
              {/* Tab content */}
              {activeTab === 'info' && (
                <div>
                  {/* Amenities */}
                  {poi.amenities && poi.amenities.length > 0 && (
                    <div className="mb-6">
                      <h2 className="text-lg font-semibold mb-3">Amenities</h2>
                      <div className="grid grid-cols-2 md:grid-cols-3 gap-3">
                        {poi.amenities.map((amenity, index) => (
                          <div key={index} className="flex items-center">
                            <div className="w-8 h-8 rounded-full bg-emerald-100 flex items-center justify-center mr-2">
                              <Info size={16} className="text-emerald-600" />
                            </div>
                            <span className="text-gray-700">{amenity}</span>
                          </div>
                        ))}
                      </div>
                    </div>
                  )}
                  
                  {/* Opening hours */}
                  {poi.openingHours && (
                    <div className="mb-6">
                      <h2 className="text-lg font-semibold mb-3">Opening Hours</h2>
                      <div className="grid grid-cols-1 md:grid-cols-2 gap-2">
                        {poi.openingHours.monday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Monday</span>
                            <span className="font-medium">{poi.openingHours.monday}</span>
                          </div>
                        )}
                        {poi.openingHours.tuesday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Tuesday</span>
                            <span className="font-medium">{poi.openingHours.tuesday}</span>
                          </div>
                        )}
                        {poi.openingHours.wednesday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Wednesday</span>
                            <span className="font-medium">{poi.openingHours.wednesday}</span>
                          </div>
                        )}
                        {poi.openingHours.thursday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Thursday</span>
                            <span className="font-medium">{poi.openingHours.thursday}</span>
                          </div>
                        )}
                        {poi.openingHours.friday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Friday</span>
                            <span className="font-medium">{poi.openingHours.friday}</span>
                          </div>
                        )}
                        {poi.openingHours.saturday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Saturday</span>
                            <span className="font-medium">{poi.openingHours.saturday}</span>
                          </div>
                        )}
                        {poi.openingHours.sunday && (
                          <div className="flex justify-between">
                            <span className="text-gray-600">Sunday</span>
                            <span className="font-medium">{poi.openingHours.sunday}</span>
                          </div>
                        )}
                      </div>
                    </div>
                  )}
                </div>
              )}
              
              {activeTab === 'map' && (
                <div>
                  <div className="bg-gray-200 h-64 rounded-lg mb-4 overflow-hidden">
                    <iframe 
                      title={`Map of ${poi.name}`}
                      src={`https://www.google.com/maps?q=${poi.location.lat},${poi.location.lng}&output=embed`}
                      width="100%"
                      height="100%"
                      style={{ border: 0 }}
                      allowFullScreen
                      loading="lazy"
                      referrerPolicy="no-referrer-when-downgrade"
                    ></iframe>
                  </div>
                  
                  <div className="flex flex-col md:flex-row md:justify-between md:items-center gap-4">
                    <div>
                      <h3 className="font-semibold mb-1">Address</h3>
                      <p className="text-gray-600">
                        {poi.name}, {poi.region}, Moldova
                      </p>
                    </div>
                    <div className="flex gap-2">
                      <Button variant="outline" size="sm">
                        Get Directions
                      </Button>
                      <Button size="sm">
                        Plan Route
                      </Button>
                    </div>
                  </div>
                </div>
              )}
              
              {activeTab === 'nearby' && (
                <div>
                  <div className="mb-4 grid grid-cols-3 gap-2">
                    <button className="flex flex-col items-center justify-center p-3 border border-gray-200 rounded-lg hover:border-emerald-500 hover:text-emerald-600 transition-colors">
                      <Hotel size={24} className="mb-2" />
                      <span className="text-sm font-medium">Hotels</span>
                    </button>
                    <button className="flex flex-col items-center justify-center p-3 border border-gray-200 rounded-lg hover:border-emerald-500 hover:text-emerald-600 transition-colors">
                      <Utensils size={24} className="mb-2" />
                      <span className="text-sm font-medium">Restaurants</span>
                    </button>
                    <button className="flex flex-col items-center justify-center p-3 border border-gray-200 rounded-lg hover:border-emerald-500 hover:text-emerald-600 transition-colors">
                      <GlassWater size={24} className="mb-2" />
                      <span className="text-sm font-medium">Cafés</span>
                    </button>
                  </div>
                  
                  <div className="text-center py-8">
                    <p className="text-gray-500 mb-4">Select a category to see nearby places</p>
                    <Button variant="outline" size="sm">
                      Show All Nearby Places
                    </Button>
                  </div>
                </div>
              )}
            </div>
            
            {/* Similar POIs */}
            {similarPOIs.length > 0 && (
              <div className="bg-white rounded-xl shadow-md p-6">
                <h2 className="text-xl font-semibold mb-4">Similar Places</h2>
                <div className="space-y-4">
                  {similarPOIs.map(similarPoi => (
                    <POICard key={similarPoi.id} poi={similarPoi} compact />
                  ))}
                </div>
              </div>
            )}
          </div>
          
          {/* Right Column: Sidebar */}
          <div className="lg:col-span-1">
            {/* Contact Information */}
            <div className="bg-white rounded-xl shadow-md p-6 mb-6">
              <h2 className="text-lg font-semibold mb-4">Contact Information</h2>
              
              <div className="space-y-4">
                {poi.contactInfo?.phone && (
                  <div className="flex items-start">
                    <Phone size={20} className="text-emerald-600 mr-3 mt-0.5" />
                    <div>
                      <p className="text-sm font-medium">Phone</p>
                      <a href={`tel:${poi.contactInfo.phone}`} className="text-gray-600 hover:text-emerald-600">
                        {poi.contactInfo.phone}
                      </a>
                    </div>
                  </div>
                )}
                
                {poi.contactInfo?.email && (
                  <div className="flex items-start">
                    <Mail size={20} className="text-emerald-600 mr-3 mt-0.5" />
                    <div>
                      <p className="text-sm font-medium">Email</p>
                      <a href={`mailto:${poi.contactInfo.email}`} className="text-gray-600 hover:text-emerald-600">
                        {poi.contactInfo.email}
                      </a>
                    </div>
                  </div>
                )}
                
                {poi.contactInfo?.website && (
                  <div className="flex items-start">
                    <Globe size={20} className="text-emerald-600 mr-3 mt-0.5" />
                    <div>
                      <p className="text-sm font-medium">Website</p>
                      <a href={poi.contactInfo.website} target="_blank" rel="noopener noreferrer" className="text-gray-600 hover:text-emerald-600 truncate block">
                        {poi.contactInfo.website.replace(/^https?:\/\//, '')}
                      </a>
                    </div>
                  </div>
                )}
                
                {!poi.contactInfo?.phone && !poi.contactInfo?.email && !poi.contactInfo?.website && (
                  <p className="text-gray-500 text-sm">No contact information available.</p>
                )}
              </div>
            </div>
            
            {/* Opening hours (mobile) */}
            <div className="md:hidden bg-white rounded-xl shadow-md p-6 mb-6">
              <h2 className="text-lg font-semibold mb-3">Opening Hours</h2>
              {poi.openingHours ? (
                <div className="space-y-2">
                  {poi.openingHours.monday && (
                    <div className="flex justify-between">
                      <span className="text-gray-600">Monday</span>
                      <span className="font-medium">{poi.openingHours.monday}</span>
                    </div>
                  )}
                  {/* Add other days here */}
                </div>
              ) : (
                <p className="text-gray-500 text-sm">No opening hours available.</p>
              )}
            </div>
            
            {/* Actions */}
            <div className="bg-white rounded-xl shadow-md p-6 mb-6">
              <h2 className="text-lg font-semibold mb-4">Plan Your Visit</h2>
              
              <div className="space-y-3">
                <Button fullWidth>
                  Get Directions
                </Button>
                <Button variant="outline" fullWidth>
                  Add to Itinerary
                </Button>
                <Button variant="outline" fullWidth>
                  See Nearby Accommodations
                </Button>
              </div>
            </div>
            
            {/* Weather */}
            <div className="bg-white rounded-xl shadow-md p-6 mb-6">
              <h2 className="text-lg font-semibold mb-3">Weather</h2>
              <div className="flex items-center justify-between">
                <div className="flex items-center">
                  <div className="w-12 h-12 rounded-full bg-sky-100 flex items-center justify-center mr-3">
                    <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" viewBox="0 0 24 24" fill="none" stroke="currentColor" strokeWidth="2" strokeLinecap="round" strokeLinejoin="round" className="text-sky-500">
                      <circle cx="12" cy="12" r="5" />
                      <line x1="12" y1="1" x2="12" y2="3" />
                      <line x1="12" y1="21" x2="12" y2="23" />
                      <line x1="4.22" y1="4.22" x2="5.64" y2="5.64" />
                      <line x1="18.36" y1="18.36" x2="19.78" y2="19.78" />
                      <line x1="1" y1="12" x2="3" y2="12" />
                      <line x1="21" y1="12" x2="23" y2="12" />
                      <line x1="4.22" y1="19.78" x2="5.64" y2="18.36" />
                      <line x1="18.36" y1="5.64" x2="19.78" y2="4.22" />
                    </svg>
                  </div>
                  <div>
                    <div className="font-semibold">22°C</div>
                    <div className="text-sm text-gray-500">Sunny</div>
                  </div>
                </div>
                <div className="text-right">
                  <div className="text-sm text-gray-600">
                    <div>H: 24°C</div>
                    <div>L: 18°C</div>
                  </div>
                </div>
              </div>
            </div>
            
            {/* Related categories */}
            <div className="bg-white rounded-xl shadow-md p-6">
              <h2 className="text-lg font-semibold mb-3">Explore More</h2>
              <div className="flex flex-wrap gap-2">
                <Link to={`/explore?category=${poi.category}`} className="px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-700 transition-colors">
                  {poi.category}
                </Link>
                <Link to={`/explore?region=${poi.region}`} className="px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-700 transition-colors">
                  {poi.region}
                </Link>
                <Link to="/explore" className="px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-700 transition-colors">
                  Popular
                </Link>
                <Link to="/explore" className="px-3 py-1.5 bg-gray-100 hover:bg-gray-200 rounded-full text-sm font-medium text-gray-700 transition-colors">
                  Top Rated
                </Link>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default POIDetails;