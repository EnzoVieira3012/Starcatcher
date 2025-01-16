import React from 'react';
import ConsortiumListPage from './pages/ConsortiumListPage.jsx';
import CreateConsortiumPage from './pages/CreateConsortiumPage.jsx';
import ApolloProvider from './ApolloProvider.jsx';

function App() {
  return (
    <ApolloProvider>
          <ConsortiumListPage />
          <CreateConsortiumPage />
    </ApolloProvider>
  );
}

export default App;