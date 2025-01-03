import React from 'react';
import { Link } from 'react-router-dom';

const Header = () => {
  return (
    <header className="bg-blue-600 text-white py-4">
      <div className="container mx-auto px-4 flex justify-between">
        <h1 className="text-xl font-bold">Cabeçalho</h1>
        <div className="text-xl">
          <Link to="/profile" className="hover:underline">
            Perfil
          </Link>
        </div>
      </div>
    </header>
  );
};

export default Header;