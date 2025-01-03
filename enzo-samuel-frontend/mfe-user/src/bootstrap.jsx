import React from 'react';
import ReactDOM from 'react-dom';
import App from './App.jsx';

const mount = (el) => {
  ReactDOM.render(<App />, el);
};

if (process.env.NODE_ENV === 'development') {
  const devRoot = document.getElementById('_user-dev-root');
  if (devRoot) {
    mount(devRoot);
  }
}

export { mount };