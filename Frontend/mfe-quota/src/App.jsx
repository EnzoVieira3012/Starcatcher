import React from 'react';
import QuotaListPage from './pages/QuotaListPage.jsx';
import ApolloProvider from './ApolloProvider.jsx';

function App() {
  return (
    <ApolloProvider>
          <QuotaListPage />
    </ApolloProvider>
  );
}

export default App;