import React from 'react';
import { useQuery, useMutation, gql } from '@apollo/client';
import { useNavigate } from 'react-router-dom';

const GET_USER_CONSORTIA = gql`
  query {
    getUserConsortia {
      id
      name
      numberOfQuotas
      numberOfInstallments
    }
  }
`;

const DELETE_CONSORTIUM = gql`
  mutation DeleteConsortium($id: Int!) {
    deleteConsortium(id: $id)
  }
`;

const ConsortiumListPage = () => {
  const { loading, error, data, refetch } = useQuery(GET_USER_CONSORTIA);
  const [deleteConsortium] = useMutation(DELETE_CONSORTIUM);
  const navigate = useNavigate();

  if (loading) return <p>Carregando...</p>;
  if (error) return <p>Erro ao carregar consórcios</p>;

  const handleDelete = async (id) => {
    await deleteConsortium({ variables: { id } });
    refetch(); // Recarregar a lista após a exclusão
  };

  const handleConsortiumClick = (id) => {
    // Redireciona para a página de cotas do consórcio no MFE Quota
    window.location.href = `http://localhost:4003/quota/${id}`;
  };

  return (
    <div className="flex flex-col min-h-screen bg-gray-100 p-8">
      <div className="flex justify-end mb-4">
        <button
          onClick={() => navigate('/create-consortium')}
          className="bg-blue-500 text-white px-4 py-2 font-bold rounded hover:bg-blue-700"
        >
          Criar Novo Consórcio
        </button>
      </div>
      <div className="bg-white shadow-md rounded overflow-hidden">
        <table className="min-w-full">
          <thead>
            <tr>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Nome
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                Qtd. de Cotas
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50 text-left text-xs font-semibold text-gray-600 uppercase tracking-wider">
                N° de Parcelas
              </th>
              <th className="px-6 py-3 border-b-2 border-gray-200 bg-gray-50"></th>
            </tr>
          </thead>
          <tbody>
            {data.getUserConsortia.map((consortium) => (
              <tr key={consortium.id} className="hover:bg-gray-100 cursor-pointer">
                <td
                  className="px-6 py-4 border-b border-gray-200"
                  onClick={() => handleConsortiumClick(consortium.id)}
                >
                  {consortium.name}
                </td>
                <td className="px-6 py-4 border-b border-gray-200">
                  {consortium.numberOfQuotas}
                </td>
                <td className="px-6 py-4 border-b border-gray-200">
                  {consortium.numberOfInstallments}
                </td>
                <td className="px-6 py-4 border-b border-gray-200 text-right">
                  <button
                    onClick={() => handleDelete(consortium.id)}
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

export default ConsortiumListPage;