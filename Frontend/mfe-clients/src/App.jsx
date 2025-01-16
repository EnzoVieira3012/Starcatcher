import React from 'react';
import { Provider } from 'react-redux';
import { store } from './redux/store';
import ApolloProvider from './ApolloProvider.jsx';
import ClientListPage from './pages/ClientListPage.jsx';
import ClientProfilePage from './pages/ClientProfilePage.jsx';

function App() {
  return (
    <ApolloProvider>
      <Provider store={store}>
        <ClientListPage />
        <ClientProfilePage />
      </Provider>
    </ApolloProvider>
  );
}

export default App;