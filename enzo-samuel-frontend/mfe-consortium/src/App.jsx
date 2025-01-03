import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { Provider } from 'react-redux';
import { store } from './redux/store';
import ApolloProvider from './ApolloProvider.jsx';
import ConsortiumListPage from './pages/ConsortiumListPage.jsx';
import CreateConsortiumPage from './pages/CreateConsortiumPage.jsx';
import './index.css';

function App() {
  return (
    <ApolloProvider> {/* Envolva a aplicação com o ApolloProvider */}
      <Provider store={store}>
        <Router>
          <div>
            <Routes>
              <Route path="/create-consortium" element={<CreateConsortiumPage />} />
              <Route path="/" element={<ConsortiumListPage />} />
            </Routes>
          </div>
        </Router>
      </Provider>
    </ApolloProvider>
  );
}

export default App;