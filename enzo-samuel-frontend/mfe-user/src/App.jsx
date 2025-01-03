import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import DashboardPage from './pages/DashboardPage.jsx';
import ProfilePage from './pages/ProfilePage.jsx';
import ApolloProvider from './ApolloProvider.jsx';
import './index.css';

function App() {
  return (
    <ApolloProvider>
      <Router>
        <div>
          <Routes>
            <Route path="/dashboard" element={<DashboardPage />} />
            <Route path="/profile" element={<ProfilePage />} />
            <Route path="/" element={<DashboardPage />} />
          </Routes>
        </div>
      </Router>
    </ApolloProvider>
  );
}

export default App;