import React, { useState } from 'react';
import { useMutation, gql } from '@apollo/client';
import { Link, useNavigate } from 'react-router-dom';

const CHANGE_PASSWORD_MUTATION = gql`
  mutation ChangePassword($email: String!, $newPassword: String!) {
    changePassword(changePasswordInput: { email: $email, newPassword: $newPassword })
  }
`;

const ChangePasswordPage = () => {
  const [email, setEmail] = useState('');
  const [newPassword, setNewPassword] = useState('');
  const [changePassword] = useMutation(CHANGE_PASSWORD_MUTATION);
  const navigate = useNavigate();

  const handleChangePassword = async () => {
    try {
      await changePassword({ variables: { email, newPassword } });
      console.log('Senha alterada com sucesso');
      navigate('/');
    } catch (error) {
      console.error('Erro durante a mudança de senha:', error);
    }
  };

  return (
    <div className="flex flex-col items-center justify-center min-h-screen bg-gray-100">
      <h1 className="mb-4 text-2xl font-bold">Alterar Senha</h1>
      <div className="w-full max-w-xs">
        <div className="px-8 pt-6 pb-8 mb-4 bg-white shadow-md rounded">
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
            <label htmlFor="new-password" className="block mb-2 text-sm font-bold text-gray-700">
              Nova Senha
            </label>
            <input
              id="new-password"
              type="password"
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
              className="w-full px-3 py-2 mb-3 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
              placeholder="********"
            />
          </div>
          <div className="flex items-center justify-between">
            <button
              onClick={handleChangePassword}
              className="px-4 py-2 font-bold text-white bg-blue-500 rounded hover:bg-blue-700 focus:outline-none focus:shadow-outline"
            >
              Alterar Senha
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

export default ChangePasswordPage;