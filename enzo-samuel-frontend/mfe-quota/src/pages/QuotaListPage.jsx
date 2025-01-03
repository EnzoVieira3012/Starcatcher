import React, { useState } from 'react';
import { useQuery, useMutation, gql } from '@apollo/client';
import { useParams } from 'react-router-dom';

// Defina a query para listar cotas de um consórcio
const LIST_QUOTAS = gql`
  query ListQuotas($consortiumId: Int!) {
    listQuotas(input: { consortiumId: $consortiumId }) {
      id
      consortiumId
      status
    }
  }
`;

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

// Defina a mutation para vincular uma cota a um cliente
const LINK_QUOTA_TO_CLIENT = gql`
  mutation LinkQuotaToClient($quotaId: Int!, $clientId: Int!) {
    linkQuotaToClient(input: { quotaId: $quotaId, clientId: $clientId })
  }
`;

const QuotaListPage = () => {
  const { id } = useParams(); // Obter o ID do consórcio dos parâmetros da URL
  const { loading, error, data } = useQuery(LIST_QUOTAS, {
    variables: { consortiumId: parseInt(id) },
  });
  const { data: clientsData, loading: clientsLoading, error: clientsError } = useQuery(LIST_CLIENTS);
  const [linkQuotaToClient] = useMutation(LINK_QUOTA_TO_CLIENT);

  const [selectedQuota, setSelectedQuota] = useState(null);

  if (loading || clientsLoading) return <p>Carregando...</p>;
  if (error || clientsError) return <p>Erro ao carregar dados</p>;

  const handleQuotaClick = (quotaId) => {
    setSelectedQuota(quotaId);
  };

  const handleClientClick = async (clientId) => {
    try {
      await linkQuotaToClient({
        variables: { quotaId: selectedQuota, clientId },
      });
      console.log('Cota vinculada com sucesso');
      setSelectedQuota(null); // Fechar o modal após a vinculação
    } catch (error) {
      console.error('Erro ao vincular cota:', error);
    }
  };

  return (
    <div className="flex flex-col min-h-screen bg-gray-100 p-8">
      <h1 className="text-2xl font-bold mb-6">Cotas do Consórcio {id}</h1>
      <div className="bg-white shadow-md rounded overflow-hidden">
        <table className="min-w-full">
          <thead>
            <tr>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                ID
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Valor da Parcela (simulado)
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Status
              </th>
            </tr>
          </thead>
          <tbody>
            {data.listQuotas.map((quota) => (
              <tr key={quota.id} className="hover:bg-gray-100 cursor-pointer" onClick={() => handleQuotaClick(quota.id)}>
                <td className="px-6 py-4 border-b border-gray-200">{quota.id}</td>
                <td className="px-6 py-4 border-b border-gray-200">
                  R$ {Math.floor(Math.random() * 1000) + 100} {/* Valor simulado */}
                </td>
                <td className="px-6 py-4 border-b border-gray-200">
                  {quota.status === 'Disponivel' ? 'Disponível' : 'Vinculado'}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {/* Modal para listar clientes */}
      {selectedQuota && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex justify-center items-center">
          <div className="bg-white p-6 rounded shadow-md w-full max-w-md">
            <h2 className="text-xl font-bold mb-4">Selecione um Cliente</h2>
            {clientsData.listClients.map(client => (
              <div key={client.id} className="mb-2">
                <span>{client.name} - {client.email}</span>
                <button
                  className="ml-4 bg-blue-500 text-white px-2 py-1 rounded hover:bg-blue-700"
                  onClick={() => handleClientClick(client.id)}
                >
                  Vincular
                </button>
              </div>
            ))}
            <button
              className="mt-4 bg-red-500 text-white px-4 py-2 rounded hover:bg-red-700"
              onClick={() => setSelectedQuota(null)}
            >
              Fechar
            </button>
          </div>
        </div>
      )}
    </div>
  );
};

export default QuotaListPage;