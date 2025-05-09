import { Link } from 'react-router-dom';
import { MapPin, Mail, Phone, Compass, Facebook, Instagram, Twitter } from 'lucide-react';
import Logo from './Logo';

const Footer = () => {
  return (
    <footer className="bg-gray-900 text-white pt-16 pb-8">
      <div className="container mx-auto px-4 md:px-6">
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-8">
          <div>
            <Logo className="h-10 w-auto" />
            <p className="mt-4 text-gray-300">
              Discover Moldova's hidden gems with TrackAndGo - your ultimate travel companion for exploring the beauty of Moldova.
            </p>
            <div className="mt-6 flex space-x-4">
              <a 
                href="#" 
                className="text-gray-400 hover:text-white transition-colors"
                aria-label="Facebook"
              >
                <Facebook size={20} />
              </a>
              <a 
                href="#" 
                className="text-gray-400 hover:text-white transition-colors"
                aria-label="Instagram"
              >
                <Instagram size={20} />
              </a>
              <a 
                href="#" 
                className="text-gray-400 hover:text-white transition-colors"
                aria-label="Twitter"
              >
                <Twitter size={20} />
              </a>
            </div>
          </div>
          
          <div>
            <h3 className="text-lg font-semibold mb-4">Quick Links</h3>
            <ul className="space-y-2">
              <li>
                <Link to="/" className="text-gray-300 hover:text-white transition-colors">
                  Home
                </Link>
              </li>
              <li>
                <Link to="/explore" className="text-gray-300 hover:text-white transition-colors">
                  Explore
                </Link>
              </li>
              <li>
                <Link to="/routes" className="text-gray-300 hover:text-white transition-colors">
                  Routes
                </Link>
              </li>
              <li>
                <Link to="/add-poi" className="text-gray-300 hover:text-white transition-colors">
                  Add POI
                </Link>
              </li>
            </ul>
          </div>
          
          <div>
            <h3 className="text-lg font-semibold mb-4">Explore</h3>
            <ul className="space-y-2">
              <li>
                <a href="#" className="text-gray-300 hover:text-white transition-colors flex items-center">
                  <Compass size={16} className="mr-2" />
                  Tourist Attractions
                </a>
              </li>
              <li>
                <a href="#" className="text-gray-300 hover:text-white transition-colors flex items-center">
                  <Compass size={16} className="mr-2" />
                  Wineries
                </a>
              </li>
              <li>
                <a href="#" className="text-gray-300 hover:text-white transition-colors flex items-center">
                  <Compass size={16} className="mr-2" />
                  Monasteries
                </a>
              </li>
              <li>
                <a href="#" className="text-gray-300 hover:text-white transition-colors flex items-center">
                  <Compass size={16} className="mr-2" />
                  Natural Landmarks
                </a>
              </li>
            </ul>
          </div>
          
          <div>
            <h3 className="text-lg font-semibold mb-4">Contact</h3>
            <ul className="space-y-4">
              <li className="flex items-start">
                <MapPin size={20} className="mr-2 text-emerald-500 flex-shrink-0 mt-1" />
                <span className="text-gray-300">
                  Stefan cel Mare Boulevard, 
                  <br />Chisinau, Moldova
                </span>
              </li>
              <li className="flex items-center">
                <Mail size={20} className="mr-2 text-emerald-500 flex-shrink-0" />
                <a href="mailto:info@trackandgo.md" className="text-gray-300 hover:text-white transition-colors">
                  info@trackandgo.md
                </a>
              </li>
              <li className="flex items-center">
                <Phone size={20} className="mr-2 text-emerald-500 flex-shrink-0" />
                <a href="tel:+37322123456" className="text-gray-300 hover:text-white transition-colors">
                  +373 22 123 456
                </a>
              </li>
            </ul>
          </div>
        </div>
        
        <div className="mt-12 pt-8 border-t border-gray-800 text-center text-gray-400 text-sm">
          <p>© {new Date().getFullYear()} TrackAndGo. All rights reserved.</p>
        </div>
      </div>
    </footer>
  );
};

export default Footer;