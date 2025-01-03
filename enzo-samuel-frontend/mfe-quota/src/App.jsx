import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import { Provider } from 'react-redux';
import { store } from './redux/store';
import ApolloProvider from './ApolloProvider.jsx';
import QuotaListPage from './pages/QuotaListPage.jsx';
import './index.css';

function App() {
  return (
    <ApolloProvider> {/* Envolva a aplicação com o ApolloProvider */}
      <Provider store={store}> {/* Envolva a aplicação com o Redux Provider */}
        <Router>
          <div>
            <Routes>
              <Route path="/quota/:id" element={<QuotaListPage />} />
              {/* Defina a rota para a lista de cotas */}
            </Routes>
          </div>
        </Router>
      </Provider>
    </ApolloProvider>
  );
}

export default App;