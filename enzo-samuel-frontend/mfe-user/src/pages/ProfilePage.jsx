import React, { useState } from 'react';
import { useQuery, useMutation, gql } from '@apollo/client';
import Header from '../components/Header';

// Defina a query GraphQL para obter dados do usuário
const GET_USER_INFO = gql`
  query {
    me {
      name
      email
    }
  }
`;

// Defina as mutations GraphQL
const CHANGE_NAME_MUTATION = gql`
  mutation ChangeName($newName: String!) {
    changeName(changeNameInput: { newName: $newName })
  }
`;

const CHANGE_EMAIL_MUTATION = gql`
  mutation ChangeEmail($newEmail: String!) {
    changeEmail(changeEmailInput: { newEmail: $newEmail })
  }
`;

const CHANGE_PASSWORD_MUTATION = gql`
  mutation ChangePassword($email: String!, $newPassword: String!) {
    changePassword(changePasswordInput: { email: $email, newPassword: $newPassword })
  }
`;

const DELETE_ACCOUNT_MUTATION = gql`
  mutation DeleteAccount($password: String!) {
    deleteAccount(deleteAccountInput: { password: $password })
  }
`;

const ProfilePage = () => {
  const { loading, error, data } = useQuery(GET_USER_INFO);

  const [changeName] = useMutation(CHANGE_NAME_MUTATION);
  const [changeEmail] = useMutation(CHANGE_EMAIL_MUTATION);
  const [changePassword] = useMutation(CHANGE_PASSWORD_MUTATION);
  const [deleteAccount] = useMutation(DELETE_ACCOUNT_MUTATION);

  const [newName, setNewName] = useState('');
  const [newEmail, setNewEmail] = useState('');
  const [newPassword, setNewPassword] = useState('');
  const [confirmPassword, setConfirmPassword] = useState('');
  const [passwordToDelete, setPasswordToDelete] = useState('');

  if (loading) return <p>Carregando...</p>;
  if (error) return <p>Erro ao carregar dados do usuário</p>;

  const { name, email } = data.me;

  const handleNameChange = () => {
    changeName({ variables: { newName } })
      .then(() => console.log('Nome alterado com sucesso'))
      .catch(err => console.error('Erro ao alterar nome:', err));
  };

  const handleEmailChange = () => {
    changeEmail({ variables: { newEmail } })
      .then(() => console.log('Email alterado com sucesso'))
      .catch(err => console.error('Erro ao alterar email:', err));
  };

  const handlePasswordChange = () => {
    if (newPassword !== confirmPassword) {
      console.error('As senhas não coincidem');
      return;
    }
    changePassword({ variables: { email, newPassword } })
      .then(() => console.log('Senha alterada com sucesso'))
      .catch(err => console.error('Erro ao alterar senha:', err));
  };

  const handleDeleteAccount = () => {
    if (passwordToDelete !== confirmPassword) {
      console.error('As senhas não coincidem');
      return;
    }
    deleteAccount({ variables: { password: passwordToDelete } })
      .then(() => console.log('Conta deletada com sucesso'))
      .catch(err => console.error('Erro ao deletar conta:', err));
  };

  return (
    <div className="flex flex-col min-h-screen bg-gray-100">
      <Header />
      <main className="flex-grow flex flex-col items-center justify-center py-8">
        <div className="bg-white shadow-md rounded p-6 w-full max-w-md">
          <h2 className="text-2xl font-bold mb-4">Perfil do Usuário</h2>
          <div className="mb-2">
            <strong>Nome:</strong>
            <span className="ml-2">{name}</span>
          </div>
          <div className="mb-4">
            <strong>Email:</strong>
            <span className="ml-2">{email}</span>
          </div>
          <div className="mb-2 flex items-center">
            <button
              onClick={handleNameChange}
              className="flex-grow px-4 py-2 bg-blue-500 text-white font-bold rounded hover:bg-blue-700"
            >
              Alterar Nome
            </button>
            <input
              type="text"
              value={newName}
              onChange={(e) => setNewName(e.target.value)}
              placeholder="Novo Nome"
              className="ml-2 px-2 py-1 border rounded"
            />
          </div>
          <div className="mb-2 flex items-center">
            <button
              onClick={handleEmailChange}
              className="flex-grow px-4 py-2 bg-blue-500 text-white font-bold rounded hover:bg-blue-700"
            >
              Alterar Email
            </button>
            <input
              type="email"
              value={newEmail}
              onChange={(e) => setNewEmail(e.target.value)}
              placeholder="Novo Email"
              className="ml-2 px-2 py-1 border rounded"
            />
          </div>
          <div className="mb-2 flex items-center">
            <button
              onClick={handlePasswordChange}
              className="flex-grow px-4 py-2 bg-blue-500 text-white font-bold rounded hover:bg-blue-700"
            >
              Alterar Senha
            </button>
            <input
              type="password"
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
              placeholder="Nova Senha"
              className="ml-2 px-2 py-1 border rounded"
            />
            <input
              type="password"
              value={confirmPassword}
              onChange={(e) => setConfirmPassword(e.target.value)}
              placeholder="Confirmar Senha"
              className="ml-2 px-2 py-1 border rounded"
            />
          </div>
          <div className="mb-2 flex items-center">
            <button
              onClick={handleDeleteAccount}
              className="flex-grow px-4 py-2 bg-red-700 text-white font-bold rounded hover:bg-red-900"
            >
              Deletar Conta
            </button>
            <input
              type="password"
              value={passwordToDelete}
              onChange={(e) => setPasswordToDelete(e.target.value)}
              placeholder="Senha"
              className="ml-2 px-2 py-1 border rounded"
            />
            <input
              type="password"
              value={confirmPassword}
              onChange={(e) => setConfirmPassword(e.target.value)}
              placeholder="Confirmar Senha"
              className="ml-2 px-2 py-1 border rounded"
            />
          </div>
        </div>
      </main>
    </div>
  );
};

export default ProfilePage;