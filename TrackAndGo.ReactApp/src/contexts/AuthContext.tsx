import { createContext, useContext, useState, useEffect, ReactNode } from 'react';

// Mock user data
const MOCK_USER = {
  email: 'test@trackandgo.md',
  password: 'test123',
  displayName: 'Test User',
  photoURL: null,
  bio: 'Travel enthusiast exploring Moldova',
  interests: ['Hiking', 'Wine Tasting', 'Photography']
};

interface UserData {
  email: string | null;
  displayName: string | null;
  photoURL: string | null;
  bio?: string;
  interests?: string[];
}

interface AuthContextType {
  currentUser: UserData | null;
  loading: boolean;
  register: (email: string, password: string, name: string) => Promise<void>;
  login: (email: string, password: string) => Promise<void>;
  logout: () => Promise<void>;
  updateUserProfile: (data: Partial<UserData>) => Promise<void>;
}

const AuthContext = createContext<AuthContextType | null>(null);

export const useAuth = () => {
  const context = useContext(AuthContext);
  if (!context) throw new Error('useAuth must be used within an AuthProvider');
  return context;
};

export const AuthProvider = ({ children }: { children: ReactNode }) => {
  const [currentUser, setCurrentUser] = useState<UserData | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    // Check local storage for saved user data
    const savedUser = localStorage.getItem('user');
    if (savedUser) {
      setCurrentUser(JSON.parse(savedUser));
    }
    setLoading(false);
  }, []);

  const login = async (email: string, password: string) => {
    // Simple authentication check
    if (email === MOCK_USER.email && password === MOCK_USER.password) {
      setCurrentUser(MOCK_USER);
      localStorage.setItem('user', JSON.stringify(MOCK_USER));
    } else {
      throw new Error('Invalid credentials');
    }
  };

  const register = async (email: string, password: string, name: string) => {
    // Simple registration
    const newUser = {
      email,
      displayName: name,
      photoURL: null,
      bio: '',
      interests: []
    };
    setCurrentUser(newUser);
    localStorage.setItem('user', JSON.stringify(newUser));
  };

  const logout = async () => {
    setCurrentUser(null);
    localStorage.removeItem('user');
  };

  const updateUserProfile = async (data: Partial<UserData>) => {
    if (!currentUser) throw new Error('No user logged in');
    
    const updatedUser = { ...currentUser, ...data };
    setCurrentUser(updatedUser);
    localStorage.setItem('user', JSON.stringify(updatedUser));
  };

  const value = {
    currentUser,
    loading,
    register,
    login,
    logout,
    updateUserProfile,
  };

  return (
    <AuthContext.Provider value={value}>
      {!loading && children}
    </AuthContext.Provider>
  );
};