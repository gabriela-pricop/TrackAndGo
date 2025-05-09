import { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { motion } from 'framer-motion';
import { ChevronRight, Map, Route as RouteIcon, Compass, Camera, Wine, Church, MapPin } from 'lucide-react';
import { samplePOIs } from '../data/samplePOIs';

const Home = () => {
  const [featuredPOIs, setFeaturedPOIs] = useState(samplePOIs.slice(0, 4));
  const [scrollY, setScrollY] = useState(0);
  
  // Parallax scrolling effect
  useEffect(() => {
    const handleScroll = () => {
      setScrollY(window.scrollY);
    };
    
    window.addEventListener('scroll', handleScroll);
    return () => window.removeEventListener('scroll', handleScroll);
  }, []);

  // Animation variants
  const containerVariants = {
    hidden: { opacity: 0 },
    visible: {
      opacity: 1,
      transition: {
        staggerChildren: 0.2
      }
    }
  };
  
  const itemVariants = {
    hidden: { y: 20, opacity: 0 },
    visible: {
      y: 0,
      opacity: 1,
      transition: {
        duration: 0.5
      }
    }
  };

  return (
    <div className="overflow-hidden">
      {/* Hero Section */}
      <section className="relative h-screen flex items-center justify-center overflow-hidden">
        <div 
          className="absolute inset-0 bg-cover bg-center bg-no-repeat"
          style={{ 
            backgroundImage: "url('https://images.pexels.com/photos/4064432/pexels-photo-4064432.jpeg')",
            transform: `translateY(${scrollY * 0.4}px)`,
            filter: 'brightness(0.75)'
          }}
        />
        
        <div className="relative container mx-auto px-4 pt-32 z-10 text-center">
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.8 }}
          >
            <h1 className="text-4xl md:text-6xl font-extrabold text-white text-shadow-lg mb-6">
              Discover the Beauty of <span className="text-emerald-400">Moldova</span>
            </h1>
            <p className="text-xl md:text-2xl text-white text-shadow mb-8 max-w-2xl mx-auto">
              Explore hidden gems, plan your adventures, and create unforgettable experiences in the heart of Eastern Europe.
            </p>
            
            <div className="flex flex-col sm:flex-row items-center justify-center gap-4">
              <Link 
                to="/explore" 
                className="px-8 py-3 bg-emerald-600 hover:bg-emerald-700 text-white font-medium rounded-full transition-all transform hover:scale-105 flex items-center justify-center"
              >
                Start Exploring <Map className="ml-2" size={18} />
              </Link>
              <Link 
                to="/routes" 
                className="px-8 py-3 bg-white bg-opacity-20 backdrop-blur-md hover:bg-opacity-30 text-white font-medium rounded-full transition-all transform hover:scale-105 flex items-center justify-center"
              >
                Plan Your Route <RouteIcon className="ml-2" size={18} />
              </Link>
            </div>
          </motion.div>
        </div>
        
        <div className="absolute bottom-10 left-0 right-0 flex justify-center">
          <motion.div
            animate={{ y: [0, 10, 0] }}
            transition={{ duration: 1.5, repeat: Infinity }}
          >
            <a href="#discover" className="text-white opacity-80 hover:opacity-100">
              <ChevronRight size={32} className="transform rotate-90" />
            </a>
          </motion.div>
        </div>
      </section>
      
      {/* Discover Section */}
      <section id="discover" className="py-20 bg-gray-50">
        <div className="container mx-auto px-4">
          <motion.div
            initial="hidden"
            whileInView="visible"
            viewport={{ once: true, margin: "-100px" }}
            variants={containerVariants}
            className="text-center max-w-3xl mx-auto mb-16"
          >
            <motion.h2 variants={itemVariants} className="text-3xl md:text-4xl font-bold mb-4">
              Discover Moldova's <span className="text-gradient">Treasures</span>
            </motion.h2>
            <motion.p variants={itemVariants} className="text-lg text-gray-600">
              From ancient monasteries and world-class wineries to breathtaking landscapes and rich cultural heritage, Moldova offers unique experiences for every traveler.
            </motion.p>
          </motion.div>
          
          <motion.div
            initial="hidden"
            whileInView="visible"
            viewport={{ once: true, margin: "-100px" }}
            variants={containerVariants}
            className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8"
          >
            <motion.div variants={itemVariants} className="bg-white rounded-xl shadow-lg overflow-hidden transform transition-all hover:scale-105">
              <div className="p-6">
                <div className="w-14 h-14 rounded-full bg-emerald-100 flex items-center justify-center mb-4">
                  <Compass className="text-emerald-600" size={28} />
                </div>
                <h3 className="text-xl font-semibold mb-2">Historic Sites</h3>
                <p className="text-gray-600 mb-4">
                  Explore ancient fortresses, archaeological complexes, and historic landmarks.
                </p>
                <Link to="/explore?category=Historical" className="text-emerald-600 font-medium flex items-center">
                  Discover <ChevronRight size={16} className="ml-1" />
                </Link>
              </div>
            </motion.div>
            
            <motion.div variants={itemVariants} className="bg-white rounded-xl shadow-lg overflow-hidden transform transition-all hover:scale-105">
              <div className="p-6">
                <div className="w-14 h-14 rounded-full bg-emerald-100 flex items-center justify-center mb-4">
                  <Wine className="text-emerald-600" size={28} />
                </div>
                <h3 className="text-xl font-semibold mb-2">Wineries</h3>
                <p className="text-gray-600 mb-4">
                  Visit world-renowned wineries and taste Moldova's exceptional wines.
                </p>
                <Link to="/explore?category=Winery" className="text-emerald-600 font-medium flex items-center">
                  Discover <ChevronRight size={16} className="ml-1" />
                </Link>
              </div>
            </motion.div>
            
            <motion.div variants={itemVariants} className="bg-white rounded-xl shadow-lg overflow-hidden transform transition-all hover:scale-105">
              <div className="p-6">
                <div className="w-14 h-14 rounded-full bg-emerald-100 flex items-center justify-center mb-4">
                  <Church className="text-emerald-600" size={28} />
                </div>
                <h3 className="text-xl font-semibold mb-2">Monasteries</h3>
                <p className="text-gray-600 mb-4">
                  Experience the tranquility and beauty of Moldova's ancient monasteries.
                </p>
                <Link to="/explore?category=Religious" className="text-emerald-600 font-medium flex items-center">
                  Discover <ChevronRight size={16} className="ml-1" />
                </Link>
              </div>
            </motion.div>
            
            <motion.div variants={itemVariants} className="bg-white rounded-xl shadow-lg overflow-hidden transform transition-all hover:scale-105">
              <div className="p-6">
                <div className="w-14 h-14 rounded-full bg-emerald-100 flex items-center justify-center mb-4">
                  <Camera className="text-emerald-600" size={28} />
                </div>
                <h3 className="text-xl font-semibold mb-2">Natural Wonders</h3>
                <p className="text-gray-600 mb-4">
                  Discover picturesque landscapes, nature reserves, and scenic viewpoints.
                </p>
                <Link to="/explore?category=Nature" className="text-emerald-600 font-medium flex items-center">
                  Discover <ChevronRight size={16} className="ml-1" />
                </Link>
              </div>
            </motion.div>
          </motion.div>
        </div>
      </section>
      
      {/* Featured Points of Interest */}
      <section className="py-20">
        <div className="container mx-auto px-4">
          <motion.div
            initial="hidden"
            whileInView="visible"
            viewport={{ once: true, margin: "-100px" }}
            variants={containerVariants}
            className="text-center max-w-3xl mx-auto mb-16"
          >
            <motion.h2 variants={itemVariants} className="text-3xl md:text-4xl font-bold mb-4">
              Featured <span className="text-gradient">Destinations</span>
            </motion.h2>
            <motion.p variants={itemVariants} className="text-lg text-gray-600">
              Explore some of Moldova's most breathtaking and popular attractions that travelers love.
            </motion.p>
          </motion.div>
          
          <motion.div
            initial="hidden"
            whileInView="visible"
            viewport={{ once: true, margin: "-100px" }}
            variants={containerVariants}
            className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8"
          >
            {featuredPOIs.map((poi) => (
              <motion.div 
                key={poi.id}
                variants={itemVariants}
                className="bg-white rounded-xl shadow-md overflow-hidden transform transition-all hover:scale-105 hover:shadow-xl"
              >
                <div className="relative h-48 overflow-hidden">
                  <img 
                    src={poi.images[0]} 
                    alt={poi.name} 
                    className="w-full h-full object-cover transition-transform duration-500 hover:scale-110"
                  />
                  <div className="absolute top-2 right-2 bg-emerald-600 text-white text-xs font-semibold px-2 py-1 rounded-full">
                    {poi.category}
                  </div>
                </div>
                <div className="p-4">
                  <div className="flex items-center mb-2">
                    <MapPin size={16} className="text-emerald-600 mr-1" />
                    <span className="text-xs text-gray-500">{poi.region}</span>
                  </div>
                  <h3 className="text-lg font-semibold mb-2">{poi.name}</h3>
                  <p className="text-gray-600 text-sm mb-4 line-clamp-2">
                    {poi.description}
                  </p>
                  <div className="flex justify-between items-center">
                    <div className="flex items-center">
                      <div className="flex items-center">
                        <span className="text-yellow-500">★</span>
                        <span className="ml-1 text-sm font-medium">{poi.rating}</span>
                      </div>
                      <span className="mx-1 text-gray-400">•</span>
                      <span className="text-sm text-gray-500">{poi.reviews} reviews</span>
                    </div>
                    <Link 
                      to={`/poi/${poi.id}`} 
                      className="text-emerald-600 font-medium text-sm flex items-center"
                    >
                      Details <ChevronRight size={14} className="ml-1" />
                    </Link>
                  </div>
                </div>
              </motion.div>
            ))}
          </motion.div>
          
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            whileInView={{ opacity: 1, y: 0 }}
            viewport={{ once: true }}
            transition={{ duration: 0.5 }}
            className="text-center mt-12"
          >
            <Link 
              to="/explore" 
              className="inline-flex items-center px-6 py-3 bg-emerald-600 hover:bg-emerald-700 text-white font-medium rounded-full transition-all"
            >
              Explore All Destinations <ChevronRight size={18} className="ml-1" />
            </Link>
          </motion.div>
        </div>
      </section>
      
      {/* App Features */}
      <section className="py-20 bg-gradient-to-br from-emerald-50 to-sky-50">
        <div className="container mx-auto px-4">
          <motion.div
            initial="hidden"
            whileInView="visible"
            viewport={{ once: true, margin: "-100px" }}
            variants={containerVariants}
            className="text-center max-w-3xl mx-auto mb-16"
          >
            <motion.h2 variants={itemVariants} className="text-3xl md:text-4xl font-bold mb-4">
              Plan Your Perfect <span className="text-gradient">Adventure</span>
            </motion.h2>
            <motion.p variants={itemVariants} className="text-lg text-gray-600">
              TrackAndGo offers powerful tools to help you discover, plan, and enjoy your Moldovan journey.
            </motion.p>
          </motion.div>
          
          <div className="grid grid-cols-1 lg:grid-cols-2 gap-16 items-center">
            <motion.div
              initial={{ opacity: 0, x: -50 }}
              whileInView={{ opacity: 1, x: 0 }}
              viewport={{ once: true }}
              transition={{ duration: 0.7 }}
              className="order-2 lg:order-1"
            >
              <div className="space-y-8">
                <div className="flex items-start">
                  <div className="w-12 h-12 rounded-full bg-emerald-100 flex items-center justify-center mr-4 mt-1 flex-shrink-0">
                    <Map className="text-emerald-600" size={24} />
                  </div>
                  <div>
                    <h3 className="text-xl font-semibold mb-2">Interactive Map</h3>
                    <p className="text-gray-600">
                      Explore Moldova through our interactive map. Discover points of interest by region or category, see detailed information, and plan your visits.
                    </p>
                  </div>
                </div>
                
                <div className="flex items-start">
                  <div className="w-12 h-12 rounded-full bg-emerald-100 flex items-center justify-center mr-4 mt-1 flex-shrink-0">
                    <RouteIcon className="text-emerald-600" size={24} />
                  </div>
                  <div>
                    <h3 className="text-xl font-semibold mb-2">Custom Routes</h3>
                    <p className="text-gray-600">
                      Create personalized travel routes by selecting your starting point and destination. Get detailed directions and discover attractions along your path.
                    </p>
                  </div>
                </div>
                
                <div className="flex items-start">
                  <div className="w-12 h-12 rounded-full bg-emerald-100 flex items-center justify-center mr-4 mt-1 flex-shrink-0">
                    <Compass className="text-emerald-600" size={24} />
                  </div>
                  <div>
                    <h3 className="text-xl font-semibold mb-2">Local Recommendations</h3>
                    <p className="text-gray-600">
                      Receive personalized recommendations based on your location. Discover nearby attractions, restaurants, and accommodations within your desired radius.
                    </p>
                  </div>
                </div>
              </div>
            </motion.div>
            
            <motion.div
              initial={{ opacity: 0, x: 50 }}
              whileInView={{ opacity: 1, x: 0 }}
              viewport={{ once: true }}
              transition={{ duration: 0.7 }}
              className="order-1 lg:order-2"
            >
              <div className="relative">
                <div className="absolute -inset-4 bg-gradient-to-r from-emerald-500 to-sky-500 rounded-xl blur-lg opacity-20 animate-pulse"></div>
                <div className="relative bg-white rounded-xl shadow-lg overflow-hidden">
                  <img 
                    src="https://images.pexels.com/photos/7412095/pexels-photo-7412095.jpeg" 
                    alt="Moldova landscape" 
                    className="w-full h-80 object-cover"
                  />
                  <div className="absolute inset-0 bg-gradient-to-t from-black/60 to-transparent flex items-end">
                    <div className="p-6 text-white">
                      <h3 className="text-2xl font-bold mb-2">Explore Moldova</h3>
                      <p className="text-sm text-gray-200">Discover the beauty of Eastern Europe's hidden gem</p>
                    </div>
                  </div>
                </div>
              </div>
            </motion.div>
          </div>
        </div>
      </section>
      
      {/* Call to Action */}
      <section className="py-16 bg-emerald-600 text-white">
        <div className="container mx-auto px-4 text-center">
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            whileInView={{ opacity: 1, y: 0 }}
            viewport={{ once: true }}
            transition={{ duration: 0.7 }}
          >
            <h2 className="text-3xl md:text-4xl font-bold mb-6">Ready to Explore Moldova?</h2>
            <p className="text-xl text-emerald-100 mb-8 max-w-2xl mx-auto">
              Sign up today and start planning your perfect Moldovan adventure with TrackAndGo.
            </p>
            <div className="flex flex-col sm:flex-row items-center justify-center gap-4">
              <Link 
                to="/register" 
                className="px-8 py-3 bg-white text-emerald-600 font-medium rounded-full transition-all transform hover:scale-105 hover:bg-gray-100"
              >
                Sign Up Free
              </Link>
              <Link 
                to="/explore" 
                className="px-8 py-3 bg-emerald-700 hover:bg-emerald-800 text-white font-medium rounded-full transition-all transform hover:scale-105"
              >
                Start Exploring
              </Link>
            </div>
          </motion.div>
        </div>
      </section>
    </div>
  );
};

export default Home;