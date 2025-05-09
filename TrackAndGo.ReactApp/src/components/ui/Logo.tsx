import { Compass } from 'lucide-react';

interface LogoProps {
  className?: string;
}

const Logo = ({ className = 'h-8 w-auto' }: LogoProps) => {
  return (
    <div className={`flex items-center ${className}`}>
      <div className="relative">
        <Compass 
          className="text-emerald-600 animate-pulse" 
          size={className === 'h-8 w-auto' ? 32 : 48} 
        />
        <div className="absolute inset-0 bg-emerald-500 rounded-full opacity-20 animate-ping-slow"></div>
      </div>
      <span className="ml-2 font-bold text-gray-800 text-xl">TrackAndGo</span>
    </div>
  );
};

export default Logo;