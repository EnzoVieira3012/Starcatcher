import React from 'react';
import DashboardPage from './pages/DashboardPage.jsx';
import ProfilePage from './pages/ProfilePage.jsx';
import ApolloProvider from './ApolloProvider.jsx';

function App() {
  return (
    <ApolloProvider>
      <ProfilePage />
      <DashboardPage />
    </ApolloProvider>
  );
}

export default App;