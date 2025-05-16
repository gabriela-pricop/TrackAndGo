import { useState, FormEvent, ChangeEvent } from 'react';
import { useNavigate } from 'react-router-dom';
import { motion } from 'framer-motion';
import { Upload, MapPin, X, Check, Info } from 'lucide-react';
import { POI, POIFormData } from '../types/poi';
import { regions } from '../data/regions';
import Button from '../components/ui/Button';

import { usePOIContext } from '../contexts/POIContext';

const categories = [
  'Historical',
  'Winery',
  'Religious',
  'Museum',
  'Nature',
  'Restaurant',
  'Hotel',
  'Entertainment'
];

const initialFormData: POIFormData = {
  name: '',
  description: '',
  category: '',
  region: '',
  location: {
    lat: null,
    lng: null
  },
  images: [],
  amenities: [],
  contactInfo: {
    phone: '',
    email: '',
    website: ''
  },
  openingHours: {
    monday: '',
    tuesday: '',
    wednesday: '',
    thursday: '',
    friday: '',
    saturday: '',
    sunday: ''
  }
};

const AddPOI = () => {
  const { addPOI, pois } = usePOIContext();

  const [formData, setFormData] = useState<POIFormData>(initialFormData);
  const [imagePreviewUrls, setImagePreviewUrls] = useState<string[]>([]);
  const [currentStep, setCurrentStep] = useState(1);
  const [loading, setLoading] = useState(false);
  const [newAmenity, setNewAmenity] = useState('');
  const [errors, setErrors] = useState<Record<string, string>>({});
  const navigate = useNavigate();
  
  const handleTextChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>) => {
    const { name, value } = e.target;
    
    if (name.includes('.')) {
      const [parent, child] = name.split('.');
      setFormData(prev => ({
        ...prev,
        [parent]: {
          ...prev[parent as keyof POIFormData],
          [child]: value
        }
      }));
    } else {
      setFormData(prev => ({
        ...prev,
        [name]: value
      }));
    }
  };
  
  const handleImageChange = (e: ChangeEvent<HTMLInputElement>) => {
    if (e.target.files && e.target.files.length > 0) {
      const newImages = Array.from(e.target.files);
      setFormData(prev => ({
        ...prev,
        images: [...prev.images, ...newImages]
      }));
      
      // Create preview URLs
      const newImagePreviews = Array.from(e.target.files).map(file => URL.createObjectURL(file));
      setImagePreviewUrls(prev => [...prev, ...newImagePreviews]);
    }
  };
  
  const removeImage = (index: number) => {
    // Remove image from form data
    setFormData(prev => ({
      ...prev,
      images: prev.images.filter((_, i) => i !== index)
    }));
    
    // Remove preview URL and revoke object URL to free memory
    URL.revokeObjectURL(imagePreviewUrls[index]);
    setImagePreviewUrls(prev => prev.filter((_, i) => i !== index));
  };
  
  const addAmenity = () => {
    if (newAmenity.trim() !== '' && !formData.amenities.includes(newAmenity.trim())) {
      setFormData(prev => ({
        ...prev,
        amenities: [...prev.amenities, newAmenity.trim()]
      }));
      setNewAmenity('');
    }
  };
  
  const removeAmenity = (index: number) => {
    setFormData(prev => ({
      ...prev,
      amenities: prev.amenities.filter((_, i) => i !== index)
    }));
  };
  
  // Set map coordinates
  const handleCoordinatesChange = (field: 'lat' | 'lng', value: string) => {
    const numValue = value === '' ? null : Number(value);
    setFormData(prev => ({
      ...prev,
      location: {
        ...prev.location,
        [field]: numValue
      }
    }));
  };
  
  // Validate form fields for the current step
  const validateStep = (step: number): boolean => {
    const newErrors: Record<string, string> = {};
    
    if (step === 1) {
      if (!formData.name.trim()) newErrors.name = 'Name is required';
      if (!formData.description.trim()) newErrors.description = 'Description is required';
      if (!formData.category) newErrors.category = 'Category is required';
      if (!formData.region) newErrors.region = 'Region is required';
    } else if (step === 2) {
      if (formData.images.length === 0) newErrors.images = 'At least one image is required';
    } else if (step === 3) {
      if (formData.location.lat == null) newErrors['location.lat'] = 'Latitude is required';
      if (formData.location.lng == null) newErrors['location.lng'] = 'Longitude is required';
    }
    
    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };
  
  const nextStep = () => {
    if (validateStep(currentStep)) {
      setCurrentStep(prev => prev + 1);
    }
  };
  
  const prevStep = () => {
    setCurrentStep(prev => prev - 1);
  };
  
  const handleSubmit = async (e: FormEvent) => {
    e.preventDefault();
    
    if (!validateStep(currentStep)) return;
    
    setLoading(true);
    
    try {
      // In a real application, you would upload images and submit the form data to your backend
      console.log('Form submitted:', formData);

      // Validate latitude and longitude
      if (formData.location.lat === null || formData.location.lng === null) {
        console.error('Latitude and Longitude are required.');
        return;
      }

      // Map formData to POI
      const newPOI: POI = {
        id: (pois.length + 1).toString(),
        userId: 1,
        name: formData.name,
        description: formData.description,
        category: formData.category,
        region: formData.region,
        location: {
          lat: formData.location.lat,
          lng: formData.location.lng,
        },
        images: [
          'https://moldovalive.md/wp-content/uploads/2023/05/cariera-fetesti.jpg',
          'https://photos.pandatur.md/658c91e62f0813c30ad88f798a5efbb6.jpg',
          'https://moldovalive.md/wp-content/uploads/2023/05/6-16-920x613-1.jpg'
        ],
        createdBy: 'admin',
        createdAt: new Date().toISOString(),
        rating: 0.0,
        reviews: 0,
        amenities: formData.amenities,
        contactInfo: {
          phone: formData.contactInfo.phone,
          email: formData.contactInfo.email,
          website: formData.contactInfo.website,
        },
        openingHours: {
          monday: formData.openingHours.monday,
          tuesday: formData.openingHours.tuesday,
          wednesday: formData.openingHours.wednesday,
          thursday: formData.openingHours.thursday,
          friday: formData.openingHours.friday,
          saturday: formData.openingHours.saturday,
          sunday: formData.openingHours.sunday,
        },
      };

      addPOI(newPOI);
      
      // Simulate API call delay
      await new Promise(resolve => setTimeout(resolve, 1500));
      
      // Navigate to the POI details page (in a real app, this would be the newly created POI)
      navigate(`/poi/${newPOI.id}`);
    } catch (error) {
      console.error('Error submitting form:', error);
      setErrors({ form: 'Failed to submit form. Please try again.' });
    } finally {
      setLoading(false);
    }
  };
  
  // Cleanup function for image preview URLs
  const cleanupImagePreviews = () => {
    imagePreviewUrls.forEach(url => URL.revokeObjectURL(url));
  };
  
  return (
    <div className="min-h-screen pt-24 pb-10">
      <div className="container mx-auto px-4">
        <div className="max-w-3xl mx-auto">
          <div className="text-center mb-8">
            <h1 className="text-3xl font-bold mb-2">Add a New Point of Interest</h1>
            <p className="text-gray-600">
              Share your discoveries and help other travelers explore Moldova
            </p>
          </div>
          
          {/* Stepper */}
          <div className="mb-8">
            <div className="flex items-center justify-between">
              <div 
                className={`w-1/3 text-center relative ${currentStep >= 1 ? 'text-emerald-600' : 'text-gray-400'}`}
              >
                <div 
                  className={`w-8 h-8 mx-auto rounded-full flex items-center justify-center ${
                    currentStep > 1 ? 'bg-emerald-600 text-white' : 
                    currentStep === 1 ? 'bg-emerald-100 text-emerald-600 border-2 border-emerald-600' :
                    'bg-gray-200 text-gray-500'
                  }`}
                >
                  {currentStep > 1 ? <Check size={16} /> : "1"}
                </div>
                <div className="mt-2 text-sm font-medium">Basic Info</div>
                <div 
                  className={`absolute top-4 left-1/2 w-full h-0.5 ${
                    currentStep > 1 ? 'bg-emerald-600' : 'bg-gray-200'
                  }`}
                ></div>
              </div>
              
              <div 
                className={`w-1/3 text-center relative ${currentStep >= 2 ? 'text-emerald-600' : 'text-gray-400'}`}
              >
                <div 
                  className={`w-8 h-8 mx-auto rounded-full flex items-center justify-center ${
                    currentStep > 2 ? 'bg-emerald-600 text-white' : 
                    currentStep === 2 ? 'bg-emerald-100 text-emerald-600 border-2 border-emerald-600' :
                    'bg-gray-200 text-gray-500'
                  }`}
                >
                  {currentStep > 2 ? <Check size={16} /> : "2"}
                </div>
                <div className="mt-2 text-sm font-medium">Media</div>
                <div 
                  className={`absolute top-4 left-1/2 w-full h-0.5 ${
                    currentStep > 2 ? 'bg-emerald-600' : 'bg-gray-200'
                  }`}
                ></div>
              </div>
              
              <div 
                className={`w-1/3 text-center ${currentStep >= 3 ? 'text-emerald-600' : 'text-gray-400'}`}
              >
                <div 
                  className={`w-8 h-8 mx-auto rounded-full flex items-center justify-center ${
                    currentStep > 3 ? 'bg-emerald-600 text-white' : 
                    currentStep === 3 ? 'bg-emerald-100 text-emerald-600 border-2 border-emerald-600' :
                    'bg-gray-200 text-gray-500'
                  }`}
                >
                  {currentStep > 3 ? <Check size={16} /> : "3"}
                </div>
                <div className="mt-2 text-sm font-medium">Details</div>
              </div>
            </div>
          </div>
          
          {/* Form */}
          <div className="bg-white rounded-xl shadow-md overflow-hidden">
            <form onSubmit={handleSubmit}>
              {/* Step 1: Basic Information */}
              {currentStep === 1 && (
                <motion.div
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  exit={{ opacity: 0, x: 20 }}
                  className="p-6"
                >
                  <h2 className="text-xl font-semibold mb-4">Basic Information</h2>
                  
                  <div className="space-y-4">
                    <div>
                      <label htmlFor="name" className="block text-sm font-medium text-gray-700 mb-1">
                        Name <span className="text-red-500">*</span>
                      </label>
                      <input
                        type="text"
                        id="name"
                        name="name"
                        value={formData.name}
                        onChange={handleTextChange}
                        className={`w-full px-3 py-2 border ${errors.name ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                        placeholder="Enter the name of the point of interest"
                      />
                      {errors.name && <p className="mt-1 text-sm text-red-600">{errors.name}</p>}
                    </div>
                    
                    <div>
                      <label htmlFor="description" className="block text-sm font-medium text-gray-700 mb-1">
                        Description <span className="text-red-500">*</span>
                      </label>
                      <textarea
                        id="description"
                        name="description"
                        value={formData.description}
                        onChange={handleTextChange}
                        rows={4}
                        className={`w-full px-3 py-2 border ${errors.description ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                        placeholder="Provide a detailed description of the place"
                      ></textarea>
                      {errors.description && <p className="mt-1 text-sm text-red-600">{errors.description}</p>}
                    </div>
                    
                    <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                      <div>
                        <label htmlFor="category" className="block text-sm font-medium text-gray-700 mb-1">
                          Category <span className="text-red-500">*</span>
                        </label>
                        <select
                          id="category"
                          name="category"
                          value={formData.category}
                          onChange={handleTextChange}
                          className={`w-full px-3 py-2 border ${errors.category ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                        >
                          <option value="">Select a category</option>
                          {categories.map((category) => (
                            <option key={category} value={category}>{category}</option>
                          ))}
                        </select>
                        {errors.category && <p className="mt-1 text-sm text-red-600">{errors.category}</p>}
                      </div>
                      
                      <div>
                        <label htmlFor="region" className="block text-sm font-medium text-gray-700 mb-1">
                          Region <span className="text-red-500">*</span>
                        </label>
                        <select
                          id="region"
                          name="region"
                          value={formData.region}
                          onChange={handleTextChange}
                          className={`w-full px-3 py-2 border ${errors.region ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                        >
                          <option value="">Select a region</option>
                          {regions.map((region) => (
                            <option key={region.name} value={region.name}>{region.name}</option>
                          ))}
                        </select>
                        {errors.region && <p className="mt-1 text-sm text-red-600">{errors.region}</p>}
                      </div>
                    </div>
                  </div>
                </motion.div>
              )}
              
              {/* Step 2: Media */}
              {currentStep === 2 && (
                <motion.div
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  exit={{ opacity: 0, x: 20 }}
                  className="p-6"
                >
                  <h2 className="text-xl font-semibold mb-4">Media</h2>
                  
                  <div className="space-y-4">
                    <div>
                      <label className="block text-sm font-medium text-gray-700 mb-1">
                        Images <span className="text-red-500">*</span>
                      </label>
                      <div 
                        className={`border-2 border-dashed rounded-lg p-6 text-center ${
                          errors.images ? 'border-red-300 bg-red-50' : 'border-gray-300 hover:border-emerald-500 hover:bg-emerald-50'
                        } transition-colors`}
                      >
                        <input
                          type="file"
                          id="images"
                          name="images"
                          accept="image/*"
                          multiple
                          onChange={handleImageChange}
                          className="hidden"
                        />
                        <label htmlFor="images" className="cursor-pointer">
                          <Upload size={32} className="mx-auto mb-2 text-gray-400" />
                          <p className="text-sm text-gray-600 mb-1">Click to upload images</p>
                          <p className="text-xs text-gray-500">PNG, JPG, or JPEG (max 5MB)</p>
                        </label>
                      </div>
                      {errors.images && <p className="mt-1 text-sm text-red-600">{errors.images}</p>}
                    </div>
                    
                    {imagePreviewUrls.length > 0 && (
                      <div>
                        <label className="block text-sm font-medium text-gray-700 mb-2">
                          Uploaded Images ({imagePreviewUrls.length})
                        </label>
                        <div className="grid grid-cols-2 sm:grid-cols-3 gap-3">
                          {imagePreviewUrls.map((url, index) => (
                            <div key={index} className="relative group">
                              <img 
                                src={url} 
                                alt={`Preview ${index}`} 
                                className="w-full h-24 object-cover rounded-lg"
                              />
                              <button
                                type="button"
                                onClick={() => removeImage(index)}
                                className="absolute top-1 right-1 bg-red-500 text-white rounded-full p-1 opacity-0 group-hover:opacity-100 transition-opacity"
                              >
                                <X size={14} />
                              </button>
                            </div>
                          ))}
                        </div>
                      </div>
                    )}
                  </div>
                </motion.div>
              )}
              
              {/* Step 3: Location and Details */}
              {currentStep === 3 && (
                <motion.div
                  initial={{ opacity: 0, x: -20 }}
                  animate={{ opacity: 1, x: 0 }}
                  exit={{ opacity: 0, x: 20 }}
                  className="p-6"
                >
                  <h2 className="text-xl font-semibold mb-4">Location and Details</h2>
                  
                  <div className="space-y-6">
                    <div>
                      <h3 className="text-lg font-medium mb-2">Coordinates <span className="text-red-500">*</span></h3>
                      <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                        <div>
                          <label htmlFor="location.lat" className="block text-sm font-medium text-gray-700 mb-1">
                            Latitude
                          </label>
                          <input
                            type="text"
                            id="location.lat"
                            value={formData.location.lat === null ? '' : formData.location.lat}
                            onChange={(e) => handleCoordinatesChange('lat', e.target.value)}
                            className={`w-full px-3 py-2 border ${errors['location.lat'] ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                            placeholder="e.g. 47.0105"
                          />
                          {errors['location.lat'] && <p className="mt-1 text-sm text-red-600">{errors['location.lat']}</p>}
                        </div>
                        <div>
                          <label htmlFor="location.lng" className="block text-sm font-medium text-gray-700 mb-1">
                            Longitude
                          </label>
                          <input
                            type="text"
                            id="location.lng"
                            value={formData.location.lng === null ? '' : formData.location.lng}
                            onChange={(e) => handleCoordinatesChange('lng', e.target.value)}
                            className={`w-full px-3 py-2 border ${errors['location.lng'] ? 'border-red-300' : 'border-gray-300'} rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500`}
                            placeholder="e.g. 28.8638"
                          />
                          {errors['location.lng'] && <p className="mt-1 text-sm text-red-600">{errors['location.lng']}</p>}
                        </div>
                      </div>
                    </div>
                    
                    <div>
                      <h3 className="text-lg font-medium mb-2">Amenities</h3>
                      <div className="flex">
                        <input
                          type="text"
                          value={newAmenity}
                          onChange={(e) => setNewAmenity(e.target.value)}
                          className="flex-grow px-3 py-2 border border-gray-300 rounded-l-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                          placeholder="e.g. Parking, WiFi, Restaurant"
                        />
                        <button
                          type="button"
                          onClick={addAmenity}
                          className="px-4 py-2 bg-emerald-600 text-white rounded-r-md hover:bg-emerald-700 transition-colors"
                        >
                          Add
                        </button>
                      </div>
                      
                      {formData.amenities.length > 0 && (
                        <div className="mt-3 flex flex-wrap gap-2">
                          {formData.amenities.map((amenity, index) => (
                            <div key={index} className="flex items-center bg-emerald-100 text-emerald-800 px-2 py-1 rounded-full">
                              <span className="text-sm">{amenity}</span>
                              <button
                                type="button"
                                onClick={() => removeAmenity(index)}
                                className="ml-1 text-emerald-800 hover:text-emerald-600"
                              >
                                <X size={14} />
                              </button>
                            </div>
                          ))}
                        </div>
                      )}
                    </div>
                    
                    <div>
                      <h3 className="text-lg font-medium mb-2">Contact Information</h3>
                      <div className="space-y-3">
                        <div>
                          <label htmlFor="contactInfo.phone" className="block text-sm font-medium text-gray-700 mb-1">
                            Phone Number
                          </label>
                          <input
                            type="text"
                            id="contactInfo.phone"
                            name="contactInfo.phone"
                            value={formData.contactInfo.phone}
                            onChange={handleTextChange}
                            className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                            placeholder="e.g. +373 22 123 456"
                          />
                        </div>
                        <div>
                          <label htmlFor="contactInfo.email" className="block text-sm font-medium text-gray-700 mb-1">
                            Email
                          </label>
                          <input
                            type="email"
                            id="contactInfo.email"
                            name="contactInfo.email"
                            value={formData.contactInfo.email}
                            onChange={handleTextChange}
                            className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                            placeholder="e.g. info@example.md"
                          />
                        </div>
                        <div>
                          <label htmlFor="contactInfo.website" className="block text-sm font-medium text-gray-700 mb-1">
                            Website
                          </label>
                          <input
                            type="url"
                            id="contactInfo.website"
                            name="contactInfo.website"
                            value={formData.contactInfo.website}
                            onChange={handleTextChange}
                            className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                            placeholder="e.g. https://example.md"
                          />
                        </div>
                      </div>
                    </div>
                    
                    <div>
                      <h3 className="text-lg font-medium mb-2">Opening Hours</h3>
                      <div className="space-y-3">
                        <div className="grid grid-cols-2 gap-4">
                          <div>
                            <label htmlFor="openingHours.monday" className="block text-sm font-medium text-gray-700 mb-1">
                              Monday
                            </label>
                            <input
                              type="text"
                              id="openingHours.monday"
                              name="openingHours.monday"
                              value={formData.openingHours.monday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                          <div>
                            <label htmlFor="openingHours.tuesday" className="block text-sm font-medium text-gray-700 mb-1">
                              Tuesday
                            </label>
                            <input
                              type="text"
                              id="openingHours.tuesday"
                              name="openingHours.tuesday"
                              value={formData.openingHours.tuesday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                        </div>
                        
                        {/* Add similar fields for other days */}
                        <div className="grid grid-cols-2 gap-4">
                          <div>
                            <label htmlFor="openingHours.wednesday" className="block text-sm font-medium text-gray-700 mb-1">
                              Wednesday
                            </label>
                            <input
                              type="text"
                              id="openingHours.wednesday"
                              name="openingHours.wednesday"
                              value={formData.openingHours.wednesday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                          <div>
                            <label htmlFor="openingHours.thursday" className="block text-sm font-medium text-gray-700 mb-1">
                              Thursday
                            </label>
                            <input
                              type="text"
                              id="openingHours.thursday"
                              name="openingHours.thursday"
                              value={formData.openingHours.thursday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                        </div>
                        
                        <div className="grid grid-cols-2 gap-4">
                          <div>
                            <label htmlFor="openingHours.friday" className="block text-sm font-medium text-gray-700 mb-1">
                              Friday
                            </label>
                            <input
                              type="text"
                              id="openingHours.friday"
                              name="openingHours.friday"
                              value={formData.openingHours.friday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                          <div>
                            <label htmlFor="openingHours.saturday" className="block text-sm font-medium text-gray-700 mb-1">
                              Saturday
                            </label>
                            <input
                              type="text"
                              id="openingHours.saturday"
                              name="openingHours.saturday"
                              value={formData.openingHours.saturday}
                              onChange={handleTextChange}
                              className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                              placeholder="e.g. 9:00 - 18:00 or Closed"
                            />
                          </div>
                        </div>
                        
                        <div>
                          <label htmlFor="openingHours.sunday" className="block text-sm font-medium text-gray-700 mb-1">
                            Sunday
                          </label>
                          <input
                            type="text"
                            id="openingHours.sunday"
                            name="openingHours.sunday"
                            value={formData.openingHours.sunday}
                            onChange={handleTextChange}
                            className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                            placeholder="e.g. 9:00 - 18:00 or Closed"
                          />
                        </div>
                      </div>
                    </div>
                  </div>
                </motion.div>
              )}
              
              {/* Form navigation and submission */}
              <div className="px-6 py-4 bg-gray-50 border-t flex justify-between">
                {currentStep > 1 ? (
                  <Button 
                    type="button" 
                    variant="outline"
                    onClick={prevStep}
                  >
                    Previous
                  </Button>
                ) : (
                  <div></div>
                )}
                
                {currentStep < 3 ? (
                  <Button 
                    type="button" 
                    onClick={nextStep}
                  >
                    Next
                  </Button>
                ) : (
                  <Button 
                    type="submit"
                    isLoading={loading}
                  >
                    Submit
                  </Button>
                )}
              </div>
              
              {errors.form && (
                <div className="px-6 pb-4 bg-gray-50">
                  <p className="text-sm text-red-600 flex items-center">
                    <Info size={16} className="mr-1" />
                    {errors.form}
                  </p>
                </div>
              )}
            </form>
          </div>
        </div>
      </div>
    </div>
  );
};

export default AddPOI;