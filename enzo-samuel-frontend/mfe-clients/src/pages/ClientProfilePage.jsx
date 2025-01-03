import React, { useState } from 'react';
import { useQuery, useMutation, gql } from '@apollo/client';
import { useParams, useNavigate } from 'react-router-dom';

// Defina a query para listar cotas de um cliente
const GET_QUOTAS_BY_CLIENT_ID = gql`
  query GetQuotasByClientId($clientId: Int!) {
    getQuotasByClientId(clientId: $clientId) {
      id
      consortiumId
      status
    }
  }
`;

// Defina a mutation completa para atualizar um cliente
const UPDATE_CLIENT = gql`
  mutation UpdateClient($updateClientInput: UpdateClientInput!) {
    updateClient(updateClientInput: $updateClientInput) {
      id
      name
      email
    }
  }
`;

const ClientProfilePage = () => {
  const { id } = useParams(); // Obter o ID do cliente dos parâmetros da URL
  const navigate = useNavigate();
  const { loading, error, data } = useQuery(GET_QUOTAS_BY_CLIENT_ID, {
    variables: { clientId: parseInt(id) },
  });

  const [updateClient] = useMutation(UPDATE_CLIENT);
  const [editMode, setEditMode] = useState(false);
  const [name, setName] = useState('');
  const [email, setEmail] = useState('');

  if (loading) return <p>Carregando...</p>;
  if (error) return <p>Erro ao carregar cotas do cliente</p>;

  const handleQuotaClick = (quotaId) => {
    navigate(`/installments/${quotaId}`);
  };

  const handleEditClick = () => {
    setEditMode(true);
  };

  const handleUpdateClient = async () => {
    try {
      await updateClient({
        variables: { updateClientInput: { id: parseInt(id), name, email } },
      });
      console.log('Cliente atualizado com sucesso');
      setEditMode(false); // Fechar o formulário de edição após a atualização
    } catch (error) {
      console.error('Erro ao atualizar cliente:', error);
    }
  };

  return (
    <div className="flex flex-col min-h-screen bg-gray-100 p-8">
      <h1 className="text-2xl font-bold mb-6">Carteira do Cliente {id}</h1>
      <button
        onClick={handleEditClick}
        className="mb-4 bg-blue-500 text-white px-4 py-2 font-bold rounded hover:bg-blue-700"
      >
        Editar Cliente
      </button>
      <div className="bg-white shadow-md rounded overflow-hidden">
        <table className="min-w-full">
          <thead>
            <tr>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                ID
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                ID do Consórcio
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Status
              </th>
            </tr>
          </thead>
          <tbody>
            {data.getQuotasByClientId.map((quota) => (
              <tr key={quota.id} className="hover:bg-gray-100 cursor-pointer" onClick={() => handleQuotaClick(quota.id)}>
                <td className="px-6 py-4 border-b border-gray-200">{quota.id}</td>
                <td className="px-6 py-4 border-b border-gray-200">{quota.consortiumId}</td>
                <td className="px-6 py-4 border-b border-gray-200">
                  {quota.status === 'Disponivel' ? 'Disponível' : 'Vinculado'}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {/* Formulário de Edição do Cliente */}
      {editMode && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
          <div className="bg-white p-6 rounded shadow-md w-full max-w-md">
            <h2 className="text-xl font-bold mb-4">Editar Cliente</h2>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="name">
                Nome
              </label>
              <input
                id="name"
                type="text"
                value={name}
                onChange={(e) => setName(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                placeholder="Nome do Cliente"
              />
            </div>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="email">
                Email
              </label>
              <input
                id="email"
                type="email"
                value={email}
                onChange={(e) => setEmail(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
                placeholder="Email do Cliente"
              />
            </div>
            <button
              onClick={handleUpdateClient}
              className="bg-blue-500 text-white px-4 py-2 rounded hover:bg-blue-700"
            >
              Atualizar Cliente
            </button>
            <button
              onClick={() => setEditMode(false)}
              className="mt-2 text-red-500 hover:text-red-700"
            >
              Cancelar
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default ClientProfilePage;