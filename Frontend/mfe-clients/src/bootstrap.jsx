import React from 'react';
import { createRoot } from 'react-dom/client'
import App from './App.jsx';

const mount = (el) => {
  createRoot(el).render(
    <App />
);
};

if (process.env.NODE_ENV === 'development') {
  const devRoot = document.getElementById('clients-dev-root');
  if (devRoot) {
    mount(devRoot);
  }
}

export { mount };