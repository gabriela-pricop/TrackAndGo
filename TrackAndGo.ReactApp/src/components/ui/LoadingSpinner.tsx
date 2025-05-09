import { motion } from 'framer-motion';

interface LoadingSpinnerProps {
  size?: 'sm' | 'md' | 'lg';
  fullScreen?: boolean;
}

const LoadingSpinner = ({ size = 'md', fullScreen = false }: LoadingSpinnerProps) => {
  const sizeClasses = {
    sm: 'w-6 h-6',
    md: 'w-12 h-12',
    lg: 'w-16 h-16',
  };

  const containerClasses = fullScreen 
    ? 'fixed inset-0 flex items-center justify-center bg-white bg-opacity-80 z-50' 
    : 'flex items-center justify-center p-4';

  return (
    <div className={containerClasses}>
      <div className="relative">
        <motion.div
          className={`${sizeClasses[size]} rounded-full border-4 border-gray-200`}
          animate={{ rotate: 360 }}
          transition={{ duration: 1, repeat: Infinity, ease: "linear" }}
        >
          <div className="absolute top-0 left-0 w-full h-full rounded-full border-4 border-emerald-500 border-t-transparent"></div>
        </motion.div>
        <div className="absolute inset-0 flex items-center justify-center">
          <motion.div 
            className="bg-emerald-500 rounded-full"
            initial={{ scale: 0.5 }}
            animate={{ scale: [0.5, 0.8, 0.5] }}
            transition={{ duration: 1.5, repeat: Infinity, ease: "easeInOut" }}
            style={{ width: '30%', height: '30%' }}
          />
        </div>
      </div>
    </div>
  );
};

export default LoadingSpinner;