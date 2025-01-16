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

const LIST_QUOTAS = gql`
  query ListQuotas($input: QuotaInput!) {
    listQuotas(input: $input) {
      id
      consortiumId
      status
    }
  }
`;

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

const LINK_QUOTA_TO_CLIENT = gql`
  mutation LinkQuotaToClient($input: LinkQuotaToClientInput!) {
    linkQuotaToClient(input: $input)
  }
`;

const UPDATE_CONSORTIUM = gql`
  mutation UpdateConsortium($updateConsortiumInput: UpdateConsortiumInput!) {
    updateConsortium(updateConsortiumInput: $updateConsortiumInput)
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

const QuotaListPageContent = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);
  const [selectedQuotaId, setSelectedQuotaId] = useState(null);
  const [isClientModalOpen, setIsClientModalOpen] = useState(false);
  const [isEditing, setIsEditing] = useState(false);
  const [formData, setFormData] = useState({
    description: null,
    assetValue: null,
    numberOfInstallments: null,
    administrationFee: null,
    numberOfQuotas: null,
    quotasValue: null,
  });

  const selectedConsortiumId = localStorage.getItem("selectedConsortiumId");
  const consortiumId = parseInt(selectedConsortiumId, 10);

  if (isNaN(consortiumId)) {
    return <p className="text-red-500">ID do consórcio inválido.</p>;
  }

  const { loading, error, data } = useQuery(LIST_QUOTAS, {
    variables: { input: { consortiumId } },
    skip: isNaN(consortiumId),
  });

  const { loading: clientsLoading, error: clientsError, data: clientsData } = useQuery(LIST_CLIENTS);

  const [linkQuotaToClient] = useMutation(LINK_QUOTA_TO_CLIENT);
  const [updateConsortium] = useMutation(UPDATE_CONSORTIUM);

  const handleQuotaClick = (quotaId) => {
    setSelectedQuotaId(quotaId);
    setIsClientModalOpen(true);
  };

  const handleClientClick = async (clientId) => {
    try {
      await linkQuotaToClient({
        variables: {
          input: {
            quotaId: selectedQuotaId,
            clientId,
          },
        },
      });
      setIsClientModalOpen(false);
    } catch (error) {
      console.error("Erro ao vincular cliente à cota:", error.message);
      alert("Erro ao vincular cliente à cota. Tente novamente.");
    }
  };

  const handleEditClick = () => {
    setIsEditing(true);
  };

  const handleFormClose = () => {
    setIsEditing(false);
  };

  const handleFormChange = (e) => {
    const { name, value } = e.target;
    setFormData((prevData) => ({
      ...prevData,
      [name]: value === "" ? null : value,
    }));
  };

  const handleFormSubmit = async (e) => {
    e.preventDefault();

    const input = {
      id: consortiumId,
      description: formData.description || null,
      assetValue: formData.assetValue ? parseFloat(formData.assetValue) : null,
      numberOfInstallments: formData.numberOfInstallments
        ? parseInt(formData.numberOfInstallments, 10)
        : null,
      administrationFee: formData.administrationFee
        ? parseFloat(formData.administrationFee)
        : null,
      numberOfQuotas: formData.numberOfQuotas
        ? parseInt(formData.numberOfQuotas, 10)
        : null,
      quotasValue: formData.quotasValue
        ? parseFloat(formData.quotasValue)
        : null,
    };

    try {
      await updateConsortium({
        variables: { updateConsortiumInput: input },
      });
      setIsEditing(false);
      alert("Consórcio atualizado com sucesso!");
    } catch (error) {
      console.error("Erro ao atualizar consórcio:", error.message);
      alert("Erro ao atualizar consórcio. Tente novamente.");
    }
  };

  if (loading) {
    return <p className="text-blue-500">Carregando dados...</p>;
  }
  if (error) {
    return <p className="text-red-500">Erro ao carregar dados: {error.message}</p>;
  }
  if (!data || !data.listQuotas) {
    return <p className="text-gray-500">Nenhuma cota encontrada.</p>;
  }

  return (
    <div className="flex min-h-screen bg-gray-100">
      <Header onIconClick={() => setIsExtended(true)} />

      {isExtended && (
        <ExtendedHeader
          onClose={() => setIsExtended(false)}
          setCurrentPage={setCurrentPage}
        />
      )}

      <main
        className={`flex-grow flex flex-col transition-all duration-300 relative ${
          isExtended ? "ml-64" : "ml-16"
        }`}
      >
        <div className="absolute top-4 right-4 flex flex-col items-end">
          <h1 className="text-3xl font-bold" style={{ color: "#1E2261" }}>
            Cotas do Consórcio {consortiumId}
          </h1>
          <button
            onClick={handleEditClick}
            className="mt-4 bg-darkBlue hover:bg-lightBlue text-white px-4 py-2 rounded transition"
          >
            Editar Consórcio
          </button>
        </div>

        <div
          className="flex items-start justify-start mt-4 ml-4 font-semibold"
          style={{ color: "#1E2261" }}
        >
          <Breadcrumb setCurrentPage={setCurrentPage} />
        </div>

        {isEditing && (
          <div className="bg-white p-6 rounded shadow-md mb-6 mt-24">
            <h2 className="text-xl font-bold text-darkBlue mb-4">
              Editar Consórcio
            </h2>
            <form onSubmit={handleFormSubmit}>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-gray-700">Descrição:</label>
                  <input
                    type="text"
                    name="description"
                    value={formData.description || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
                <div>
                  <label className="block text-gray-700">Valor do Bem:</label>
                  <input
                    type="number"
                    name="assetValue"
                    value={formData.assetValue || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
                <div>
                  <label className="block text-gray-700">Número de Parcelas:</label>
                  <input
                    type="number"
                    name="numberOfInstallments"
                    value={formData.numberOfInstallments || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
                <div>
                  <label className="block text-gray-700">
                    Taxa de Administração:
                  </label>
                  <input
                    type="number"
                    name="administrationFee"
                    value={formData.administrationFee || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
                <div>
                  <label className="block text-gray-700">Número de Cotas:</label>
                  <input
                    type="number"
                    name="numberOfQuotas"
                    value={formData.numberOfQuotas || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
                <div>
                  <label className="block text-gray-700">Valor das Cotas:</label>
                  <input
                    type="number"
                    name="quotasValue"
                    value={formData.quotasValue || ""}
                    onChange={handleFormChange}
                    className="w-full border rounded px-3 py-2 focus:ring-2 focus:ring-blue-500"
                  />
                </div>
              </div>
              <div className="flex justify-end mt-4">
                <button
                  type="button"
                  onClick={handleFormClose}
                  className="bg-gray-400 text-white px-4 py-2 rounded hover:bg-gray-500 transition mr-2"
                >
                  Cancelar
                </button>
                <button
                  type="submit"
                  className="bg-darkBlue hover:bg-lightBlue text-white px-4 py-2 rounded transition"
                >
                  Salvar
                </button>
              </div>
            </form>
          </div>
        )}

        <div className="bg-white shadow-lg rounded-lg overflow-x-auto mx-4 mt-24">
          <table className="table-auto min-w-full divide-y divide-gray-200">
            <thead className="bg-darkBlue">
              <tr>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  ID
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Status
                </th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-gray-200">
              {data.listQuotas.map((quota) => (
                <tr
                  key={quota.id}
                  className="hover:bg-gray-100 cursor-pointer"
                  onClick={() => handleQuotaClick(quota.id)}
                >
                  <td className="px-6 py-4">{quota.id}</td>
                  <td className="px-6 py-4">
                    {quota.status === "Disponivel" ? "Disponível" : "Vinculado"}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>

        {isClientModalOpen && (
          <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
            <div className="bg-white p-6 rounded shadow-lg w-full max-w-lg">
              <h2 className="text-xl font-bold text-blue-600 mb-4">Selecione um Cliente</h2>
              {clientsLoading ? (
                <p className="text-gray-500">Carregando clientes...</p>
              ) : clientsError ? (
                <p className="text-red-500">Erro ao carregar clientes: {clientsError.message}</p>
              ) : (
                <table className="table-auto min-w-full divide-y divide-gray-200">
                  <thead className="bg-darkBlue">
                    <tr>
                      <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                        Nome
                      </th>
                      <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                        Email
                      </th>
                      <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                        Telefone
                      </th>
                    </tr>
                  </thead>
                  <tbody className="bg-white divide-y divide-gray-200">
                    {clientsData.listClients.map((client) => (
                      <tr
                        key={client.id}
                        className="hover:bg-gray-100 cursor-pointer"
                        onClick={() => handleClientClick(client.id)}
                      >
                        <td className="px-6 py-4">{client.name}</td>
                        <td className="px-6 py-4">{client.email}</td>
                        <td className="px-6 py-4">{client.phone}</td>
                      </tr>
                    ))}
                  </tbody>
                </table>
              )}
              <div className="flex justify-end mt-4">
                <button
                  onClick={() => setIsClientModalOpen(false)}
                  className="bg-gray-400 text-white px-4 py-2 rounded hover:bg-gray-500 transition"
                >
                  Fechar
                </button>
              </div>
            </div>
          </div>
        )}
      </main>
    </div>
  );
};

const QuotaListPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <QuotaListPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default QuotaListPage;