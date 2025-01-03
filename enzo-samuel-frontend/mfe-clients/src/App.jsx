import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { Provider } from 'react-redux';
import { store } from './redux/store';
import ApolloProvider from './ApolloProvider.jsx';
import ClientListPage from './pages/ClientListPage.jsx';
import ClientProfilePage from './pages/ClientProfilePage.jsx';
import './index.css';

function App() {
  return (
    <ApolloProvider>
      <Provider store={store}>
        <Router>
          <div>
            <Routes>
              <Route path="/client/:id" element={<ClientProfilePage />} />
              <Route path="/" element={<ClientListPage />} />
            </Routes>
          </div>
        </Router>
      </Provider>
    </ApolloProvider>
  );
}

export default App;