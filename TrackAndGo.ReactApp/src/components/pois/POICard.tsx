import { Link } from 'react-router-dom';
import { MapPin, Star, Clock, Phone, Globe, ChevronRight } from 'lucide-react';
import { motion } from 'framer-motion';
import { POI } from '../../types/poi';

interface POICardProps {
  poi: POI;
  compact?: boolean;
}

const POICard = ({ poi, compact = false }: POICardProps) => {
  return (
    <motion.div 
      className="bg-white rounded-lg shadow-sm border border-gray-100 overflow-hidden hover:shadow-md transition-all"
      whileHover={{ y: -5 }}
    >
      <div className="flex flex-col md:flex-row">
        <div className={`relative ${compact ? 'md:w-1/4' : 'md:w-2/5'}`}>
          <Link to={`/poi/${poi.id}`}>
            <img 
              src={poi.images[0]} 
              alt={poi.name} 
              className="w-full h-48 md:h-full object-cover transition-transform duration-500 hover:scale-105"
            />
          </Link>
          <div className="absolute top-2 right-2 bg-emerald-600 text-white text-xs font-semibold px-2 py-1 rounded-full">
            {poi.category}
          </div>
        </div>
        
        <div className={`p-4 flex flex-col justify-between ${compact ? 'md:w-3/4' : 'md:w-3/5'}`}>
          <div>
            <div className="flex items-center mb-2">
              <MapPin size={16} className="text-emerald-600 mr-1 flex-shrink-0" />
              <span className="text-xs text-gray-500">{poi.region}</span>
            </div>
            
            <Link to={`/poi/${poi.id}`} className="hover:text-emerald-600">
              <h3 className="text-lg font-semibold mb-2">{poi.name}</h3>
            </Link>
            
            {!compact && (
              <p className="text-gray-600 text-sm mb-4 line-clamp-2">
                {poi.description}
              </p>
            )}
            
            <div className="space-y-1 mb-4">
              {poi.rating && (
                <div className="flex items-center text-sm">
                  <Star size={14} className="text-yellow-500 mr-1" />
                  <span className="font-medium">{poi.rating}</span>
                  <span className="mx-1 text-gray-400">•</span>
                  <span className="text-gray-500">{poi.reviews} reviews</span>
                </div>
              )}
              
              {!compact && poi.openingHours?.monday && (
                <div className="flex items-center text-sm text-gray-600">
                  <Clock size={14} className="mr-1 text-gray-400" />
                  <span>Today: {poi.openingHours.monday}</span>
                </div>
              )}
              
              {!compact && poi.contactInfo?.phone && (
                <div className="flex items-center text-sm text-gray-600">
                  <Phone size={14} className="mr-1 text-gray-400" />
                  <span>{poi.contactInfo.phone}</span>
                </div>
              )}
              
              {!compact && poi.contactInfo?.website && (
                <div className="flex items-center text-sm text-gray-600">
                  <Globe size={14} className="mr-1 text-gray-400" />
                  <a href={poi.contactInfo.website} target="_blank" rel="noopener noreferrer" className="text-emerald-600 hover:underline truncate">
                    {poi.contactInfo.website.replace(/^https?:\/\//, '')}
                  </a>
                </div>
              )}
            </div>
          </div>
          
          <div className="flex items-center justify-between mt-auto">
            {!compact && poi.amenities && (
              <div className="flex flex-wrap gap-1">
                {poi.amenities.slice(0, 3).map((amenity, index) => (
                  <span key={index} className="text-xs bg-gray-100 text-gray-600 px-2 py-0.5 rounded-full">
                    {amenity}
                  </span>
                ))}
                {poi.amenities.length > 3 && (
                  <span className="text-xs text-gray-500">+{poi.amenities.length - 3} more</span>
                )}
              </div>
            )}
            
            <Link 
              to={`/poi/${poi.id}`} 
              className="text-emerald-600 font-medium text-sm flex items-center"
            >
              {compact ? 'View' : 'View Details'} <ChevronRight size={14} className="ml-1" />
            </Link>
          </div>
        </div>
      </div>
    </motion.div>
  );
};

export default POICard;