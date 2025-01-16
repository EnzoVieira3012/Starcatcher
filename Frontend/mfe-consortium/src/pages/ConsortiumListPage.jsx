import React, { useState } from "react";
import {
  ApolloProvider,
  ApolloClient,
  InMemoryCache,
  useQuery,
  useMutation,
  gql,
  createHttpLink,
} from "@apollo/client";
import { setContext } from "@apollo/client/link/context";
import Header from "../components/Header";
import ExtendedHeader from "../components/ExtendedHeader";
import Breadcrumb from "./components/Breadcrumb";
import "../index.css";

const GET_USER_CONSORTIA = gql`
  query {
    getUserConsortia {
      id
      name
      description
      assetValue
      numberOfInstallments
      administrationFee
      numberOfQuotas
      quotaValue
    }
  }
`;

const DELETE_CONSORTIUM = gql`
  mutation DeleteConsortium($id: Int!) {
    deleteConsortium(id: $id)
  }
`;

const httpLink = createHttpLink({
  uri: "http://localhost:3000/graphql",
});

const authLink = setContext((_, { headers }) => {
  const token = localStorage.getItem("token");
  return {
    headers: {
      ...headers,
      Authorization: token ? `Bearer ${token}` : "",
    },
  };
});

const client = new ApolloClient({
  link: authLink.concat(httpLink),
  cache: new InMemoryCache(),
});

const ConsortiumListPageContent = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);
  const { loading, error, data, refetch } = useQuery(GET_USER_CONSORTIA);
  const [deleteConsortium] = useMutation(DELETE_CONSORTIUM);

  const handleExtendHeader = () => setIsExtended(true);
  const handleCloseExtendedHeader = () => setIsExtended(false);

  const handleRowClick = (id) => {
    localStorage.setItem("selectedConsortiumId", id);
    setCurrentPage("quotas");
  };

  const handleDeleteClick = async (e, id) => {
    e.stopPropagation();
    try {
      await deleteConsortium({
        variables: { id },
      });
      refetch();
    } catch (err) {
      console.error("Erro ao deletar consórcio:", err);
    }
  };

  if (loading) return <p className="text-blue-500">Carregando...</p>;
  if (error)
    return (
      <p className="text-red-500">
        Erro ao carregar consórcios: {error.message}
      </p>
    );

  return (
    <div className="flex min-h-screen bg-gray-100">
      <Header onIconClick={handleExtendHeader} />
      {isExtended && (
        <ExtendedHeader
          onClose={handleCloseExtendedHeader}
          setCurrentPage={setCurrentPage}
        />
      )}
      <div
        className={`flex-grow flex flex-col transition-all duration-300 relative ${
          isExtended ? "ml-64" : "ml-16"
        }`}
      >
        <div
          className="absolute top-4 right-4 font-bold text-3xl"
          style={{ color: "#1E2261" }}
        >
          Lista de Consórcios
        </div>
        <div
          className="flex items-start justify-start mt-4 ml-4 font-semibold"
          style={{ color: "#1E2261" }}
        >
          <Breadcrumb setCurrentPage={setCurrentPage} />
        </div>
        <div className="flex justify-end mb-4 mt-4 mr-4">
          <button
            onClick={() => setCurrentPage("createConsortium")}
            className="px-4 py-2 font-bold text-white bg-darkBlue rounded hover:bg-lightBlue transition duration-200"
          >
            Criar Novo Consórcio
          </button>
        </div>
        <div className="bg-white shadow-lg rounded-lg overflow-x-auto mx-4">
          <table className="table-auto min-w-full divide-y divide-gray-200">
            <thead className="bg-darkBlue">
              <tr>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Nome
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Descrição
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Valor do Ativo
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  N° de Parcelas
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Taxa de Administração (%)
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Quantidade de Cotas
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Valor das Cotas
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider"></th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-gray-200">
              {data.getUserConsortia.map((consortium) => (
                <tr
                  key={consortium.id}
                  className="hover:bg-gray-100 cursor-pointer"
                  onClick={() => handleRowClick(consortium.id)}
                >
                  <td className="px-6 py-4">{consortium.name}</td>
                  <td className="px-6 py-4">{consortium.description}</td>
                  <td className="px-6 py-4">{consortium.assetValue}</td>
                  <td className="px-6 py-4">{consortium.numberOfInstallments}</td>
                  <td className="px-6 py-4">{consortium.administrationFee}</td>
                  <td className="px-6 py-4">{consortium.numberOfQuotas}</td>
                  <td className="px-6 py-4">{consortium.quotaValue}</td>
                  <td
                    className="px-6 py-4 text-red-500 hover:text-red-700 cursor-pointer"
                    onClick={(e) => handleDeleteClick(e, consortium.id)}
                  >
                    Delete
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </div>
  );
};

const ConsortiumListPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <ConsortiumListPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default ConsortiumListPage;