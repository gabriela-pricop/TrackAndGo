import { POI } from '../types/poi';

export const samplePOIs: POI[] = [
  {
    id: '1',
    userId: 2,
    name: 'Orheiul Vechi',
    description: 'An archaeological complex located in Moldova featuring ancient cave monasteries and stunning landscapes. This historical site dates back to the Dacian tribes and features cave monasteries carved into the limestone cliffs.',
    category: 'Historical',
    region: 'Orhei',
    location: {
      lat: 47.3020554,
      lng: 28.9693441
    },
    images: [
      'https://visit.chisinau.md/wp-content/uploads/2021/12/orheiul-vechi-e1638951548942.jpg',
      'https://www.travel.md/wp-content/uploads/2011/08/orheiul_vechi_trebujeni_moldova_rocks.jpg',
      'https://hamal.md/wp-content/uploads/2023/07/orheiul-vechi.jpg',
      'https://stephenthegreat.travel/storage//gallery//1693386901.jpeg'
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
    userId: 2,
    name: 'Cricova Winery',
    description: 'One of the largest underground wine cellars in the world with over 120 km of tunnels. Cricova is famous for its sparkling wine production and unique underground storage facilities.',
    category: 'Winery',
    region: 'Chisinau',
    location: {
      lat: 47.1485724,
      lng: 28.857793
    },
    images: [
      'https://visit.chisinau.md/wp-content/uploads/2021/09/1-7.jpg',
      'https://winetravelawards.com/wp-content/uploads/2021/12/cmax9672.jpg',
      'https://winetravelawards.com/wp-content/uploads/2021/12/ds_3111.jpg'
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
    userId: 2,
    name: 'Soroca Fortress',
    description: 'A historic fortress built by Ștefan cel Mare in 1499. This circular fortress sits on the banks of the Dniester River and was part of a defensive system against Ottoman invasions.',
    category: 'Historical',
    region: 'Soroca',
    location: {
      lat: 48.1610156,
      lng: 28.3031396
    },
    images: [
      'https://moldova.md/sites/default/files/soroca.png',
      'https://www.himoldova.md/upl/posts_md/The_Soroca_fortress.jpg'
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
    userId: 2,
    name: 'Capriana Monastery',
    description: 'One of the oldest monasteries in Moldova, founded in the 15th century. Located in a picturesque forest setting, this monastery has been a spiritual center for centuries.',
    category: 'Religious',
    region: 'Straseni',
    location: {
      lat: 47.1162679,
      lng: 28.5079614
    },
    images: [
      'https://visit.chisinau.md/wp-content/uploads/2021/09/4-8.jpg',
      'https://visit.chisinau.md/wp-content/uploads/2021/09/4-7.jpg',
      'https://www.himoldova.md/upl/posts_md/monastiri_Capriana_Moldova-7.jpg'
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
    userId: 2,
    name: 'National Museum of History',
    description: 'The most important history museum in Moldova, showcasing artifacts from prehistoric times to the present day. The museum collection includes over 300,000 artifacts documenting Moldova\'s rich heritage.',
    category: 'Museum',
    region: 'Chisinau',
    location: {
      lat: 47.0225901,
      lng: 28.8255566
    },
    images: [
      'https://visit.chisinau.md/wp-content/uploads/2021/09/pe2-1.jpg',
      'https://www.nationalmuseum.md/img/sala_bronz.jpg',
      'https://d37rmf1ynyg9aw.cloudfront.net/fit-in/1280x1280/data/v4/resources/images/bf301a44-8f66-419d-9c6e-add6e25912e7.jpg'
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
    userId: 2,
    name: 'Purcari Winery',
    description: 'Founded in 1827, Purcari is one of Moldova\'s oldest and most prestigious wineries. Famous for its "Negru de Purcari" red wine that was a favorite of Queen Victoria.',
    category: 'Winery',
    region: 'Stefan Voda',
    location: {
      lat: 46.5289308,
      lng: 29.852519
    },
    images: [
      'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/28/07/15/55/chateau-purcari.jpg?w=900&h=500&s=1',
      'https://purcariwineries.com/wp-content/uploads/2023/10/purcari-1-1.jpg',
      'https://www.canadianliquorstore.ca/cdn/shop/files/image.jpg?v=1691620429&width=2400'
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
    userId: 2,
    name: 'Saharna Monastery',
    description: 'A spectacular monastery complex situated near natural waterfalls and rock formations. The area is considered sacred due to a reported apparition of St. Maria.',
    category: 'Religious',
    region: 'Rezina',
    location: {
      lat: 47.694733,
      lng: 28.9472864
    },
    images: [
      'https://6d6f6c646f7661.ultracdn.net/wp-content/uploads/2020/11/manastirea-saharna.jpg',
      'https://www.himoldova.md/upl/posts_md/saharna-31.jpg',
      'https://old.pandatur.md/wp-content/uploads/2021/06/104e7f82-e49f-4060-8fc8-effc2f44e1cc-gipsy-hole-saharna-scaled.jpg'
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
    userId: 2,
    name: 'Tipova Monastery',
    description: 'A cave monastery carved into a massive limestone cliff overlooking the Dniester River. Dating back to the 10th century with incredible views of the surrounding landscape.',
    category: 'Religious',
    region: 'Rezina',
    location: {
      lat: 47.601768,
      lng: 28.9871857
    },
    images: [
      'https://www.dinotruck.com/wp-content/uploads/2021/08/20210818_115518.jpg',
      'https://www.travel.md/wp-content/uploads/2011/08/tipova_monastery_31.jpg'
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
    userId: 1,
    name: 'Gagauzian National Museum of History and Ethnography',
    description: 'A museum showcasing the culture, history, and traditions of the Gagauz people, a Turkic ethnic group in southern Moldova.',
    category: 'Museum',
    region: 'Comrat',
    location: {
      lat: 46.1688252,
      lng: 28.5723535
    },
    images: [
      'https://discovergagauzia.md/wp-content/uploads/2019/08/discovergagauzia_atractions_museum_besalma3-1024x683.jpg',
      'https://gagauzia.travel.blog/wp-content/uploads/2019/06/64805719_398658137732717_3988300686830862336_n-3.jpg'
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
    userId: 2,
    name: 'Milestii Mici Winery',
    description: 'Home to the world\'s largest wine collection according to the Guinness Book of Records, with underground galleries stretching for over 200 km.',
    category: 'Winery',
    region: 'Ialoveni',
    location: {
      lat: 46.9209294,
      lng: 28.8020971
    },
    images: [
      'https://www.milestii-mici.md/images/2017/11/08/havuz.jpg',
      'https://upload.wikimedia.org/wikipedia/commons/3/35/Mile%C5%9Ftii_Mici_%283944427747%29.jpg',
      'https://winetravelawards.com/wp-content/uploads/2021/12/ds_7247_1500.jpg'
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