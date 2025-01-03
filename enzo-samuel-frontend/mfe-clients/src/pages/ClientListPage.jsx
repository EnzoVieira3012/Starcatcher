import React from 'react';
import { useQuery, gql } from '@apollo/client';
import { useNavigate } from 'react-router-dom';

// Defina a query para listar clientes
const LIST_CLIENTS = gql`
  query {
    listClients {
      id
      name
      email
      phone
    }
  }
`;

const ClientListPage = () => {
  const { loading, error, data } = useQuery(LIST_CLIENTS);
  const navigate = useNavigate();

  if (loading) return <p>Carregando...</p>;
  if (error) return <p>Erro ao carregar clientes</p>;

  const handleClientClick = (id) => {
    navigate(`/client/${id}`);
  };

  return (
    <div className="flex flex-col min-h-screen bg-gray-100 p-8">
      <div className="flex justify-end mb-4">
        <button
          onClick={() => navigate('/create-client')}
          className="bg-blue-500 text-white px-4 py-2 font-bold rounded hover:bg-blue-700"
        >
          Criar Novo Cliente
        </button>
      </div>
      <div className="bg-white shadow-md rounded overflow-hidden">
        <table className="min-w-full">
          <thead>
            <tr>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                ID
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Nome
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Email
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Telefone
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50"></th>
            </tr>
          </thead>
          <tbody>
            {data.listClients.map((client) => (
              <tr key={client.id} className="hover:bg-gray-100 cursor-pointer" onClick={() => handleClientClick(client.id)}>
                <td className="px-6 py-4 border-b border-gray-200">{client.id}</td>
                <td className="px-6 py-4 border-b border-gray-200">{client.name}</td>
                <td className="px-6 py-4 border-b border-gray-200">{client.email}</td>
                <td className="px-6 py-4 border-b border-gray-200">{client.phone}</td>
                <td className="px-6 py-4 border-b border-gray-200 text-right">
                  <button
                    onClick={() => console.log(`Excluir cliente com ID: ${client.id}`)}
                    className="text-red-600 hover:text-red-800"
                  >
                    &#8942;
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default ClientListPage;