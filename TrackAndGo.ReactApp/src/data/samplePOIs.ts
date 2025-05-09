import { POI } from '../types/poi';

export const samplePOIs: POI[] = [
  {
    id: '1',
    name: 'Orheiul Vechi',
    description: 'An archaeological complex located in Moldova featuring ancient cave monasteries and stunning landscapes. This historical site dates back to the Dacian tribes and features cave monasteries carved into the limestone cliffs.',
    category: 'Historical',
    region: 'Orhei',
    location: {
      lat: 47.3008,
      lng: 28.9683
    },
    images: [
      'https://images.pexels.com/photos/4064432/pexels-photo-4064432.jpeg',
      'https://images.pexels.com/photos/7412095/pexels-photo-7412095.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-01-15T12:00:00Z',
    rating: 4.8,
    reviews: 120,
    amenities: ['Parking', 'Tour guides', 'Souvenir shop'],
    contactInfo: {
      phone: '+373 23 556 789',
      email: 'info@orheivechi.md',
      website: 'https://orheivechi.md'
    },
    openingHours: {
      monday: '9:00 - 17:00',
      tuesday: '9:00 - 17:00',
      wednesday: '9:00 - 17:00',
      thursday: '9:00 - 17:00',
      friday: '9:00 - 17:00',
      saturday: '10:00 - 18:00',
      sunday: '10:00 - 18:00'
    }
  },
  {
    id: '2',
    name: 'Cricova Winery',
    description: 'One of the largest underground wine cellars in the world with over 120 km of tunnels. Cricova is famous for its sparkling wine production and unique underground storage facilities.',
    category: 'Winery',
    region: 'Chișinău',
    location: {
      lat: 47.1384,
      lng: 28.8625
    },
    images: [
      'https://images.pexels.com/photos/2702805/pexels-photo-2702805.jpeg',
      'https://images.pexels.com/photos/2912108/pexels-photo-2912108.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-01-20T10:30:00Z',
    rating: 4.9,
    reviews: 205,
    amenities: ['Wine tasting', 'Restaurant', 'Tours', 'Gift shop'],
    contactInfo: {
      phone: '+373 22 453 689',
      email: 'tourism@cricova.md',
      website: 'https://cricova.md'
    },
    openingHours: {
      monday: '10:00 - 16:00',
      tuesday: '10:00 - 16:00',
      wednesday: '10:00 - 16:00',
      thursday: '10:00 - 16:00',
      friday: '10:00 - 16:00',
      saturday: '10:00 - 17:00',
      sunday: '10:00 - 15:00'
    }
  },
  {
    id: '3',
    name: 'Soroca Fortress',
    description: 'A historic fortress built by Ștefan cel Mare in 1499. This circular fortress sits on the banks of the Dniester River and was part of a defensive system against Ottoman invasions.',
    category: 'Historical',
    region: 'Soroca',
    location: {
      lat: 48.1569,
      lng: 28.2858
    },
    images: [
      'https://images.pexels.com/photos/4846455/pexels-photo-4846455.jpeg',
      'https://images.pexels.com/photos/6766680/pexels-photo-6766680.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-02-05T14:20:00Z',
    rating: 4.6,
    reviews: 98,
    amenities: ['Museum', 'Gift shop', 'Guide services'],
    contactInfo: {
      phone: '+373 23 022 343',
      email: 'info@sorocafortress.md',
      website: 'https://sorocafortress.md'
    },
    openingHours: {
      monday: 'Closed',
      tuesday: '9:00 - 17:00',
      wednesday: '9:00 - 17:00',
      thursday: '9:00 - 17:00',
      friday: '9:00 - 17:00',
      saturday: '10:00 - 18:00',
      sunday: '10:00 - 18:00'
    }
  },
  {
    id: '4',
    name: 'Căpriana Monastery',
    description: 'One of the oldest monasteries in Moldova, founded in the 15th century. Located in a picturesque forest setting, this monastery has been a spiritual center for centuries.',
    category: 'Religious',
    region: 'Chișinău',
    location: {
      lat: 47.1167,
      lng: 28.5333
    },
    images: [
      'https://images.pexels.com/photos/6467735/pexels-photo-6467735.jpeg',
      'https://images.pexels.com/photos/6510322/pexels-photo-6510322.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-02-10T11:45:00Z',
    rating: 4.7,
    reviews: 85,
    amenities: ['Prayer area', 'Religious artifacts', 'Peaceful gardens'],
    contactInfo: {
      phone: '+373 22 596 784',
      email: 'info@capriana.md',
      website: 'https://capriana.md'
    }
  },
  {
    id: '5',
    name: 'National Museum of History',
    description: 'The most important history museum in Moldova, showcasing artifacts from prehistoric times to the present day. The museum collection includes over 300,000 artifacts documenting Moldova\'s rich heritage.',
    category: 'Museum',
    region: 'Chișinău',
    location: {
      lat: 47.0229,
      lng: 28.8353
    },
    images: [
      'https://images.pexels.com/photos/2218786/pexels-photo-2218786.jpeg',
      'https://images.pexels.com/photos/2123337/pexels-photo-2123337.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-02-15T09:15:00Z',
    rating: 4.5,
    reviews: 112,
    amenities: ['Audio guides', 'Gift shop', 'Temporary exhibitions'],
    contactInfo: {
      phone: '+373 22 244 325',
      email: 'office@muzeuistorie.md',
      website: 'https://www.muzeuistorie.md'
    },
    openingHours: {
      monday: 'Closed',
      tuesday: '10:00 - 18:00',
      wednesday: '10:00 - 18:00',
      thursday: '10:00 - 18:00',
      friday: '10:00 - 18:00',
      saturday: '10:00 - 19:00',
      sunday: '10:00 - 19:00'
    }
  },
  {
    id: '6',
    name: 'Purcari Winery',
    description: 'Founded in 1827, Purcari is one of Moldova\'s oldest and most prestigious wineries. Famous for its "Negru de Purcari" red wine that was a favorite of Queen Victoria.',
    category: 'Winery',
    region: 'Ștefan Vodă',
    location: {
      lat: 46.6255,
      lng: 29.8493
    },
    images: [
      'https://images.pexels.com/photos/1554896/pexels-photo-1554896.jpeg',
      'https://images.pexels.com/photos/2702805/pexels-photo-2702805.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-02-18T16:30:00Z',
    rating: 4.9,
    reviews: 145,
    amenities: ['Wine tasting', 'Restaurant', 'Hotel', 'Vineyard tours'],
    contactInfo: {
      phone: '+373 22 856 022',
      email: 'tourism@purcari.md',
      website: 'https://chateau.purcari.md'
    }
  },
  {
    id: '7',
    name: 'Saharna Monastery',
    description: 'A spectacular monastery complex situated near natural waterfalls and rock formations. The area is considered sacred due to a reported apparition of St. Maria.',
    category: 'Religious',
    region: 'Rezina',
    location: {
      lat: 47.6903,
      lng: 28.9712
    },
    images: [
      'https://images.pexels.com/photos/7412095/pexels-photo-7412095.jpeg',
      'https://images.pexels.com/photos/6467735/pexels-photo-6467735.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-03-05T13:40:00Z',
    rating: 4.7,
    reviews: 92,
    amenities: ['Hiking trails', 'Waterfall views', 'Religious services'],
    contactInfo: {
      phone: '+373 25 498 721',
      email: 'contact@saharna.md',
      website: 'https://saharna.md'
    }
  },
  {
    id: '8',
    name: 'Țîpova Monastery',
    description: 'A cave monastery carved into a massive limestone cliff overlooking the Dniester River. Dating back to the 10th century with incredible views of the surrounding landscape.',
    category: 'Religious',
    region: 'Rezina',
    location: {
      lat: 47.6056,
      lng: 28.9886
    },
    images: [
      'https://images.pexels.com/photos/6510322/pexels-photo-6510322.jpeg',
      'https://images.pexels.com/photos/4064432/pexels-photo-4064432.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-03-12T10:20:00Z',
    rating: 4.8,
    reviews: 78,
    amenities: ['Hiking paths', 'River views', 'Cave exploration'],
    contactInfo: {
      phone: '+373 25 433 687',
      email: 'info@tipova.md',
      website: 'https://tipova.md'
    }
  },
  {
    id: '9',
    name: 'Gagauzian National Museum of History and Ethnography',
    description: 'A museum showcasing the culture, history, and traditions of the Gagauz people, a Turkic ethnic group in southern Moldova.',
    category: 'Museum',
    region: 'Comrat',
    location: {
      lat: 46.2946,
      lng: 28.6565
    },
    images: [
      'https://images.pexels.com/photos/2123337/pexels-photo-2123337.jpeg',
      'https://images.pexels.com/photos/2218786/pexels-photo-2218786.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-03-20T14:15:00Z',
    rating: 4.4,
    reviews: 65,
    amenities: ['Cultural exhibits', 'Traditional crafts', 'Guided tours'],
    contactInfo: {
      phone: '+373 29 822 456',
      email: 'museum@gagauzia.md',
      website: 'https://gagauzmuseum.md'
    }
  },
  {
    id: '10',
    name: 'Mileștii Mici Winery',
    description: 'Home to the world\'s largest wine collection according to the Guinness Book of Records, with underground galleries stretching for over 200 km.',
    category: 'Winery',
    region: 'Chișinău',
    location: {
      lat: 46.9456,
      lng: 28.8583
    },
    images: [
      'https://images.pexels.com/photos/2912108/pexels-photo-2912108.jpeg',
      'https://images.pexels.com/photos/1554896/pexels-photo-1554896.jpeg'
    ],
    createdBy: 'admin',
    createdAt: '2023-04-01T11:30:00Z',
    rating: 4.8,
    reviews: 185,
    amenities: ['Underground tours', 'Wine tasting', 'Restaurant', 'Events venue'],
    contactInfo: {
      phone: '+373 22 382 333',
      email: 'wine@milestii-mici.md',
      website: 'https://milestii-mici.md'
    }
  }
];