import React from 'react';
import PropTypes from 'prop-types';
import { ApolloClient, InMemoryCache, ApolloProvider as Provider } from '@apollo/client';

const client = new ApolloClient({
  uri: 'http://localhost:3000/graphql', // Certifique-se de substituir pela URL correta do seu servidor GraphQL
  cache: new InMemoryCache(),
});

const ApolloProvider = ({ children }) => {
  return <Provider client={client}>{children}</Provider>;
};

// Definindo a validação de props usando PropTypes
ApolloProvider.propTypes = {
  children: PropTypes.node.isRequired,
};

export default ApolloProvider;