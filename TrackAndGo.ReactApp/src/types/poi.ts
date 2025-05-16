export interface POI {
  id: string;
  userId: number,
  name: string;
  description: string;
  category: string;
  region: string;
  location: {
    lat: number;
    lng: number;
  };
  images: string[];
  createdBy: string;
  createdAt: string;
  rating?: number;
  reviews?: number;
  amenities?: string[];
  contactInfo?: {
    phone?: string;
    email?: string;
    website?: string;
  };
  openingHours?: {
    monday?: string;
    tuesday?: string;
    wednesday?: string;
    thursday?: string;
    friday?: string;
    saturday?: string;
    sunday?: string;
  };
}

export interface POIFormData {
  name: string;
  description: string;
  category: string;
  region: string;
  location: {
    lat: number | null;
    lng: number | null;
  };
  images: File[];
  amenities: string[];
  contactInfo: {
    phone: string;
    email: string;
    website: string;
  };
  openingHours: {
    monday: string;
    tuesday: string;
    wednesday: string;
    thursday: string;
    friday: string;
    saturday: string;
    sunday: string;
  };
}