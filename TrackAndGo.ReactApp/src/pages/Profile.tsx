import { useState, useRef, ChangeEvent, FormEvent } from 'react';
import { motion } from 'framer-motion';
import { User, MapPin, Edit2, Upload, LogOut, Calendar, Camera } from 'lucide-react';
import { useAuth } from '../contexts/AuthContext';
import { POI } from '../types/poi';
import { samplePOIs } from '../data/samplePOIs';
import Button from '../components/ui/Button';
import POICard from '../components/pois/POICard';
import LoadingSpinner from '../components/ui/LoadingSpinner';

const Profile = () => {
  const { currentUser, updateUserProfile, logout } = useAuth();
  const [editMode, setEditMode] = useState(false);
  const [loading, setLoading] = useState(false);
  const [userPOIs, setUserPOIs] = useState<POI[]>(
    // For demo purposes, we'll use the first 3 sample POIs
    samplePOIs.slice(0, 3)
  );
  
  // Form state
  const [formData, setFormData] = useState({
    displayName: currentUser?.displayName || '',
    email: currentUser?.email || '',
    bio: currentUser?.bio || '',
    interests: currentUser?.interests || []
  });
  
  // New interest input
  const [newInterest, setNewInterest] = useState('');
  
  // File input ref
  const fileInputRef = useRef<HTMLInputElement>(null);
  
  // Handle text change
  const handleChange = (e: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    setFormData(prev => ({
      ...prev,
      [name]: value
    }));
  };
  
  // Handle profile picture change
  const handleProfilePictureChange = (e: ChangeEvent<HTMLInputElement>) => {
    if (e.target.files && e.target.files[0]) {
      // In a real app, you would upload the file to storage and get the URL
      console.log('File selected:', e.target.files[0]);
    }
  };
  
  // Trigger file input click
  const triggerFileInput = () => {
    if (fileInputRef.current) {
      fileInputRef.current.click();
    }
  };
  
  // Add interest
  const addInterest = () => {
    if (newInterest.trim() && !formData.interests.includes(newInterest.trim())) {
      setFormData(prev => ({
        ...prev,
        interests: [...prev.interests, newInterest.trim()]
      }));
      setNewInterest('');
    }
  };
  
  // Remove interest
  const removeInterest = (interestToRemove: string) => {
    setFormData(prev => ({
      ...prev,
      interests: prev.interests.filter(interest => interest !== interestToRemove)
    }));
  };
  
  // Save profile
  const handleSubmit = async (e: FormEvent) => {
    e.preventDefault();
    setLoading(true);
    
    try {
      await updateUserProfile({
        displayName: formData.displayName,
        bio: formData.bio,
        interests: formData.interests
      });
      setEditMode(false);
    } catch (error) {
      console.error('Error updating profile:', error);
    } finally {
      setLoading(false);
    }
  };
  
  // Handle logout
  const handleLogout = async () => {
    try {
      await logout();
    } catch (error) {
      console.error('Error logging out:', error);
    }
  };
  
  if (!currentUser) {
    return (
      <div className="min-h-screen pt-24 pb-10 flex items-center justify-center">
        <LoadingSpinner size="lg" />
      </div>
    );
  }
  
  return (
    <div className="min-h-screen pt-24 pb-10">
      <div className="container mx-auto px-4">
        <div className="max-w-5xl mx-auto">
          <div className="bg-white rounded-xl shadow-md overflow-hidden">
            {/* Profile header */}
            <div className="relative h-48 bg-gradient-to-r from-emerald-500 to-sky-500">
              {editMode ? (
                <button
                  onClick={triggerFileInput}
                  className="absolute right-4 top-4 bg-white bg-opacity-80 p-2 rounded-full hover:bg-opacity-100 transition-all"
                >
                  <Camera size={20} className="text-gray-700" />
                </button>
              ) : (
                <button
                  onClick={() => setEditMode(true)}
                  className="absolute right-4 top-4 bg-white bg-opacity-80 p-2 rounded-full hover:bg-opacity-100 transition-all"
                >
                  <Edit2 size={20} className="text-gray-700" />
                </button>
              )}
            </div>
            
            <div className="relative px-6 py-8">
              <div className="absolute -top-16 left-6">
                <div className="relative">
                  <div className="w-32 h-32 rounded-full bg-gray-200 border-4 border-white overflow-hidden">
                    {currentUser.photoURL ? (
                      <img 
                        src={currentUser.photoURL} 
                        alt={currentUser.displayName || 'User'} 
                        className="w-full h-full object-cover"
                      />
                    ) : (
                      <div className="w-full h-full flex items-center justify-center bg-emerald-100 text-emerald-600">
                        <User size={48} />
                      </div>
                    )}
                  </div>
                  
                  {editMode && (
                    <button 
                      onClick={triggerFileInput}
                      className="absolute bottom-0 right-0 bg-emerald-600 text-white p-2 rounded-full hover:bg-emerald-700 transition-colors"
                    >
                      <Upload size={16} />
                    </button>
                  )}
                  
                  <input
                    type="file"
                    ref={fileInputRef}
                    onChange={handleProfilePictureChange}
                    accept="image/*"
                    className="hidden"
                  />
                </div>
              </div>
              
              {editMode ? (
                <form onSubmit={handleSubmit} className="pt-16">
                  <div className="space-y-4">
                    <div>
                      <label htmlFor="displayName" className="block text-sm font-medium text-gray-700 mb-1">
                        Name
                      </label>
                      <input
                        type="text"
                        id="displayName"
                        name="displayName"
                        value={formData.displayName}
                        onChange={handleChange}
                        className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                      />
                    </div>
                    
                    <div>
                      <label htmlFor="email" className="block text-sm font-medium text-gray-700 mb-1">
                        Email
                      </label>
                      <input
                        type="email"
                        id="email"
                        name="email"
                        value={formData.email}
                        readOnly
                        className="w-full px-3 py-2 border border-gray-200 bg-gray-50 rounded-md text-gray-500"
                      />
                      <p className="mt-1 text-xs text-gray-500">Email cannot be changed</p>
                    </div>
                    
                    <div>
                      <label htmlFor="bio" className="block text-sm font-medium text-gray-700 mb-1">
                        Bio
                      </label>
                      <textarea
                        id="bio"
                        name="bio"
                        value={formData.bio}
                        onChange={handleChange}
                        rows={4}
                        className="w-full px-3 py-2 border border-gray-300 rounded-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                        placeholder="Tell us about yourself..."
                      ></textarea>
                    </div>
                    
                    <div>
                      <label className="block text-sm font-medium text-gray-700 mb-1">
                        Interests
                      </label>
                      <div className="flex">
                        <input
                          type="text"
                          value={newInterest}
                          onChange={(e) => setNewInterest(e.target.value)}
                          className="flex-grow px-3 py-2 border border-gray-300 rounded-l-md focus:outline-none focus:ring-2 focus:ring-emerald-500"
                          placeholder="Add your interests (e.g., hiking, wine tasting)"
                        />
                        <button
                          type="button"
                          onClick={addInterest}
                          className="px-4 py-2 bg-emerald-600 text-white rounded-r-md hover:bg-emerald-700 transition-colors"
                        >
                          Add
                        </button>
                      </div>
                      
                      {formData.interests.length > 0 && (
                        <div className="mt-3 flex flex-wrap gap-2">
                          {formData.interests.map((interest, index) => (
                            <div key={index} className="flex items-center bg-emerald-100 text-emerald-800 px-2 py-1 rounded-full">
                              <span className="text-sm">{interest}</span>
                              <button
                                type="button"
                                onClick={() => removeInterest(interest)}
                                className="ml-1 text-emerald-800 hover:text-emerald-600"
                              >
                                ×
                              </button>
                            </div>
                          ))}
                        </div>
                      )}
                    </div>
                    
                    <div className="flex justify-end space-x-3 pt-4">
                      <Button
                        type="button"
                        variant="outline"
                        onClick={() => setEditMode(false)}
                      >
                        Cancel
                      </Button>
                      <Button
                        type="submit"
                        isLoading={loading}
                      >
                        Save Changes
                      </Button>
                    </div>
                  </div>
                </form>
              ) : (
                <div className="pt-16">
                  <h1 className="text-2xl font-bold mb-1">
                    {currentUser.displayName || 'User'}
                  </h1>
                  
                  <div className="flex items-center text-gray-600 mb-4">
                    <MapPin size={16} className="mr-1" />
                    <span>Moldova</span>
                    <span className="mx-2">•</span>
                    <Calendar size={16} className="mr-1" />
                    <span>Joined January 2023</span>
                  </div>
                  
                  {currentUser.bio && (
                    <p className="text-gray-700 mb-6">
                      {currentUser.bio}
                    </p>
                  )}
                  
                  {currentUser.interests && currentUser.interests.length > 0 && (
                    <div className="mb-6">
                      <h2 className="text-lg font-medium mb-2">Interests</h2>
                      <div className="flex flex-wrap gap-2">
                        {currentUser.interests.map((interest, index) => (
                          <span key={index} className="px-3 py-1 bg-emerald-100 text-emerald-800 rounded-full text-sm">
                            {interest}
                          </span>
                        ))}
                      </div>
                    </div>
                  )}
                  
                  <div className="flex space-x-3">
                    <Button
                      onClick={() => setEditMode(true)}
                      variant="outline"
                      size="sm"
                    >
                      Edit Profile
                    </Button>
                    <Button
                      onClick={handleLogout}
                      variant="outline"
                      size="sm"
                    >
                      <LogOut size={16} className="mr-1" />
                      Logout
                    </Button>
                  </div>
                </div>
              )}
            </div>
          </div>
          
          {/* User's POIs */}
          <div className="mt-8">
            <div className="flex items-center justify-between mb-6">
              <h2 className="text-2xl font-bold">Your Points of Interest</h2>
              <Button
                variant="outline"
                size="sm"
                onClick={() => window.location.href = '/add-poi'}
              >
                Add New POI
              </Button>
            </div>
            
            {userPOIs.length > 0 ? (
              <motion.div
                initial={{ opacity: 0 }}
                animate={{ opacity: 1 }}
                className="space-y-4"
              >
                {userPOIs.map((poi) => (
                  <POICard key={poi.id} poi={poi} />
                ))}
              </motion.div>
            ) : (
              <div className="bg-white rounded-xl shadow-md p-8 text-center">
                <MapPin size={48} className="mx-auto mb-4 text-gray-300" />
                <h3 className="text-xl font-semibold mb-2">No Points of Interest Yet</h3>
                <p className="text-gray-600 mb-6">
                  You haven't added any points of interest yet. Share your discoveries and help other travelers explore Moldova.
                </p>
                <Button onClick={() => window.location.href = '/add-poi'}>
                  Add Your First POI
                </Button>
              </div>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default Profile;