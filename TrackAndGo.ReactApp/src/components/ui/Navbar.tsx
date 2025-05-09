import { useState } from 'react';
import { Link, NavLink, useNavigate } from 'react-router-dom';
import { motion, AnimatePresence } from 'framer-motion';
import { Menu, X, User, LogOut, Map, Plus, Route, Home } from 'lucide-react';
import { useAuth } from '../../contexts/AuthContext';
import Logo from './Logo';

interface NavbarProps {
  scrolled: boolean;
}

const Navbar = ({ scrolled }: NavbarProps) => {
  const [isOpen, setIsOpen] = useState(false);
  const { currentUser, logout } = useAuth();
  const navigate = useNavigate();

  const handleLogout = async () => {
    try {
      await logout();
      navigate('/login');
    } catch (error) {
      console.error('Logout failed', error);
    }
  };

  const toggleMenu = () => setIsOpen(!isOpen);
  const closeMenu = () => setIsOpen(false);

  const navbarClasses = scrolled 
    ? 'bg-white shadow-md py-3 transition-all duration-300' 
    : 'bg-transparent py-5 transition-all duration-300';

  return (
    <header className={`fixed w-full top-0 z-50 ${navbarClasses}`}>
      <nav className="container mx-auto px-4 md:px-6">
        <div className="flex justify-between items-center">
          <Link to="/" className="flex-shrink-0">
            <Logo />
          </Link>

          {/* Desktop Menu */}
          <div className="hidden md:flex items-center space-x-8">
            <div className="flex space-x-4">
              <NavLink 
                to="/" 
                className={({ isActive }) => 
                  isActive 
                    ? 'text-emerald-600 font-medium' 
                    : 'text-gray-700 hover:text-emerald-600 transition-colors'
                }
              >
                Home
              </NavLink>
              <NavLink 
                to="/explore" 
                className={({ isActive }) => 
                  isActive 
                    ? 'text-emerald-600 font-medium' 
                    : 'text-gray-700 hover:text-emerald-600 transition-colors'
                }
              >
                Explore
              </NavLink>
              <NavLink 
                to="/routes" 
                className={({ isActive }) => 
                  isActive 
                    ? 'text-emerald-600 font-medium' 
                    : 'text-gray-700 hover:text-emerald-600 transition-colors'
                }
              >
                Routes
              </NavLink>
            </div>

            <div className="flex items-center space-x-2">
              {currentUser ? (
                <>
                  <Link 
                    to="/add-poi" 
                    className="inline-flex items-center px-3 py-2 text-sm font-medium rounded-md text-white bg-emerald-600 hover:bg-emerald-700 transition-colors"
                  >
                    <Plus size={16} className="mr-1" />
                    Add POI
                  </Link>
                  
                  <div className="relative group">
                    <button className="flex items-center space-x-2 focus:outline-none">
                      <div className="w-8 h-8 rounded-full bg-emerald-100 flex items-center justify-center text-emerald-800 font-semibold">
                        {currentUser.displayName?.charAt(0) || 'U'}
                      </div>
                    </button>
                    
                    <div className="absolute right-0 w-48 mt-2 py-2 bg-white rounded-md shadow-lg opacity-0 invisible group-hover:opacity-100 group-hover:visible transition-all duration-300 ease-in-out">
                      <Link 
                        to="/profile" 
                        className="block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                      >
                        <User size={16} className="inline mr-2" />
                        Profile
                      </Link>
                      <button 
                        onClick={handleLogout}
                        className="w-full text-left block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100"
                      >
                        <LogOut size={16} className="inline mr-2" />
                        Logout
                      </button>
                    </div>
                  </div>
                </>
              ) : (
                <>
                  <Link 
                    to="/login" 
                    className="inline-flex items-center px-4 py-2 text-sm font-medium text-emerald-600 bg-white border border-emerald-600 rounded-md hover:bg-emerald-50 transition-colors"
                  >
                    Login
                  </Link>
                  <Link 
                    to="/register" 
                    className="inline-flex items-center px-4 py-2 text-sm font-medium text-white bg-emerald-600 border border-transparent rounded-md hover:bg-emerald-700 transition-colors"
                  >
                    Register
                  </Link>
                </>
              )}
            </div>
          </div>

          {/* Mobile Menu Button */}
          <div className="md:hidden">
            <button 
              onClick={toggleMenu}
              className="inline-flex items-center justify-center p-2 rounded-md text-gray-700 hover:text-emerald-600 focus:outline-none"
            >
              {isOpen ? <X size={24} /> : <Menu size={24} />}
            </button>
          </div>
        </div>
      </nav>

      {/* Mobile Menu */}
      <AnimatePresence>
        {isOpen && (
          <motion.div 
            className="md:hidden"
            initial={{ opacity: 0, height: 0 }}
            animate={{ opacity: 1, height: 'auto' }}
            exit={{ opacity: 0, height: 0 }}
            transition={{ duration: 0.3 }}
          >
            <div className="px-2 pt-2 pb-3 space-y-1 sm:px-3 bg-white shadow-lg">
              <Link 
                to="/" 
                className="flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                onClick={closeMenu}
              >
                <Home size={18} className="mr-2" />
                Home
              </Link>
              <Link 
                to="/explore" 
                className="flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                onClick={closeMenu}
              >
                <Map size={18} className="mr-2" />
                Explore
              </Link>
              <Link 
                to="/routes" 
                className="flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                onClick={closeMenu}
              >
                <Route size={18} className="mr-2" />
                Routes
              </Link>
              
              {currentUser ? (
                <>
                  <Link 
                    to="/add-poi" 
                    className="flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                    onClick={closeMenu}
                  >
                    <Plus size={18} className="mr-2" />
                    Add POI
                  </Link>
                  <Link 
                    to="/profile" 
                    className="flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                    onClick={closeMenu}
                  >
                    <User size={18} className="mr-2" />
                    Profile
                  </Link>
                  <button 
                    onClick={() => {
                      handleLogout();
                      closeMenu();
                    }}
                    className="w-full flex items-center px-3 py-2 text-base font-medium rounded-md text-gray-700 hover:text-emerald-600 hover:bg-gray-50"
                  >
                    <LogOut size={18} className="mr-2" />
                    Logout
                  </button>
                </>
              ) : (
                <div className="flex flex-col space-y-2 pt-2">
                  <Link 
                    to="/login" 
                    className="text-center px-4 py-2 text-base font-medium text-emerald-600 bg-white border border-emerald-600 rounded-md hover:bg-emerald-50"
                    onClick={closeMenu}
                  >
                    Login
                  </Link>
                  <Link 
                    to="/register" 
                    className="text-center px-4 py-2 text-base font-medium text-white bg-emerald-600 border border-transparent rounded-md hover:bg-emerald-700"
                    onClick={closeMenu}
                  >
                    Register
                  </Link>
                </div>
              )}
            </div>
          </motion.div>
        )}
      </AnimatePresence>
    </header>
  );
};

export default Navbar;