import { Outlet } from 'react-router-dom';
import { motion } from 'framer-motion';
import Logo from '../components/ui/Logo';

const AuthLayout = () => {
  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-br from-emerald-50 to-sky-50 py-12 sm:px-6 lg:px-8">
      <motion.div 
        className="max-w-md w-full space-y-8 p-10 bg-white rounded-xl shadow-lg"
        initial={{ opacity: 0, y: 20 }}
        animate={{ opacity: 1, y: 0 }}
        exit={{ opacity: 0, y: -20 }}
        transition={{ duration: 0.5 }}
      >
        <div className="flex flex-col items-center">
          <Logo className="h-16 w-auto" />
        </div>
        
        <div className="mt-8">
          <Outlet />
        </div>
      </motion.div>
    </div>
  );
};

export default AuthLayout;