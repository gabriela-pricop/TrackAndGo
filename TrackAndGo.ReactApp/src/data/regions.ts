// Define Moldova regions with their coordinates for mapping purposes
export const regions = [
  { 
    name: "Chișinău", 
    center: { lat: 47.0105, lng: 28.8638 },
    color: "#10B981"
  },
  { 
    name: "Bălți", 
    center: { lat: 47.7631, lng: 27.9291 },
    color: "#3B82F6"
  },
  { 
    name: "Tiraspol", 
    center: { lat: 46.8402, lng: 29.6395 },
    color: "#8B5CF6"
  },
  { 
    name: "Bender", 
    center: { lat: 46.8316, lng: 29.4816 },
    color: "#EC4899"
  },
  { 
    name: "Rîbnița", 
    center: { lat: 47.7679, lng: 29.0101 },
    color: "#F59E0B"
  },
  { 
    name: "Cahul", 
    center: { lat: 45.9045, lng: 28.1995 },
    color: "#EF4444"
  },
  { 
    name: "Ungheni", 
    center: { lat: 47.2108, lng: 27.8025 },
    color: "#6366F1"
  },
  { 
    name: "Soroca", 
    center: { lat: 48.1572, lng: 28.2839 },
    color: "#14B8A6"
  },
  { 
    name: "Orhei", 
    center: { lat: 47.3831, lng: 28.8239 },
    color: "#F97316"
  },
  { 
    name: "Comrat", 
    center: { lat: 46.2946, lng: 28.6565 },
    color: "#0EA5E9" 
  },
  { 
    name: "Edineț", 
    center: { lat: 48.1708967, lng: 27.2627958 },
    color: "#0EA5E9" 
  }
];

// Moldova country bounds for map initialization
export const moldovaBounds = {
  northeast: { lat: 48.4902, lng: 30.1354 },
  southwest: { lat: 45.4667, lng: 26.6159 }
};