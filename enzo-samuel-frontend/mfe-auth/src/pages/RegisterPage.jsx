import React, { useState } from 'react';
import { useMutation, gql } from '@apollo/client';
import { Link } from 'react-router-dom';

const REGISTER_MUTATION = gql`
  mutation Register($name: String!, $email: String!, $password: String!) {
    register(registerInput: { name: $name, email: $email, password: $password }) {
      token
    }
  }
`;

const RegisterPage = () => {
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [register] = useMutation(REGISTER_MUTATION);

  const handleRegister = async () => {
    try {
      const { data } = await register({ variables: { name, email, password } });
      if (data.register.token) {
        console.log('Cadastro bem-sucedido:', data.register.token);
        // Redirecionar para a dashboard do usuário em localhost:4005
        window.location.href = 'http://localhost:4005/dashboard';
      }
    } catch (error) {
      console.error('Erro durante o cadastro:', error);
    }
  };

  return (
    <div className="flex flex-col items-center justify-center min-h-screen bg-gray-100">
      <h1 className="mb-4 text-2xl font-bold">Cadastro</h1>
      <div className="w-full max-w-xs">
        <div className="px-8 pt-6 pb-8 mb-4 bg-white shadow-md rounded">
          <div className="mb-4">
            <label htmlFor="name" className="block mb-2 text-sm font-bold text-gray-700">
              Nome
            </label>
            <input
              id="name"
              type="text"
              value={name}
              onChange={(e) => setName(e.target.value)}
              className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
              placeholder="Nome"
            />
          </div>
          <div className="mb-4">
            <label htmlFor="email" className="block mb-2 text-sm font-bold text-gray-700">
              Email
            </label>
            <input
              id="email"
              type="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
              placeholder="Email"
            />
          </div>
          <div className="mb-4">
            <label htmlFor="password" className="block mb-2 text-sm font-bold text-gray-700">
              Senha
            </label>
            <input
              id="password"
              type="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              className="w-full px-3 py-2 mb-3 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
              placeholder="********"
            />
          </div>
          <div className="flex items-center justify-between">
            <button
              onClick={handleRegister}
              className="px-4 py-2 font-bold text-white bg-blue-500 rounded hover:bg-blue-700 focus:outline-none focus:shadow-outline"
            >
              Criar Conta
            </button>
          </div>
        </div>
        <Link to="/" className="text-sm text-center text-blue-500 hover:text-blue-800">
          Voltar para o Login
        </Link>
      </div>
    </div>
  );
};

export default RegisterPage;