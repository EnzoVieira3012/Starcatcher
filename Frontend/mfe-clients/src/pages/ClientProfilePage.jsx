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
import { BreadcrumbClientProfile } from "./components/Breadcrumb";
import "../index.css";

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

const GET_QUOTAS_BY_CLIENT_ID = gql`
  query {
    getQuotasByClientId(clientId: ${parseInt(localStorage.getItem("selectedClientId"), 10)}) {
      id
    }
  }
`;

const LIST_INSTALLMENTS = gql`
  query ListInstallments($input: InstallmentInput!) {
    listInstallments(input: $input) {
      id
      value
      status
    }
  }
`;

const PAY_INSTALLMENT = gql`
  mutation PayInstallment($input: PayInstallmentInput!) {
    payInstallment(input: $input)
  }
`;

const UPDATE_CLIENT = gql`
  mutation UpdateClient($updateClientInput: UpdateClientInput!) {
    updateClient(updateClientInput: $updateClientInput)
  }
`;

const ClientProfilePageContent = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);
  const [isEditModalOpen, setIsEditModalOpen] = useState(false);
  const [isInstallmentModalOpen, setIsInstallmentModalOpen] = useState(false);
  const [installments, setInstallments] = useState([]);
  const [selectedQuotaId, setSelectedQuotaId] = useState(null);
  const [editName, setEditName] = useState("");
  const [editEmail, setEditEmail] = useState("");
  const clientId = parseInt(localStorage.getItem("selectedClientId"), 10);

  const { loading, error, data } = useQuery(GET_QUOTAS_BY_CLIENT_ID);
  const [payInstallment] = useMutation(PAY_INSTALLMENT);
  const [updateClient] = useMutation(UPDATE_CLIENT);

  const handleUpdateClient = async () => {
    try {
      await updateClient({
        variables: {
          updateClientInput: { id: clientId, name: editName, email: editEmail },
        },
      });
      alert("Cliente atualizado com sucesso!");
      setIsEditModalOpen(false);
    } catch (error) {
      console.error("Erro ao atualizar cliente:", error.message);
      alert("Erro ao atualizar cliente. Tente novamente.");
    }
  };

  const handleQuotaClick = async (quotaId) => {
    setSelectedQuotaId(quotaId);
    try {
      const { data } = await client.query({
        query: LIST_INSTALLMENTS,
        variables: { input: { quotaId } },
      });

      if (data && data.listInstallments) {
        setInstallments(data.listInstallments);
        setIsInstallmentModalOpen(true);
      }
    } catch (error) {
      console.error("Erro ao carregar parcelas:", error.message);
    }
  };

  const handlePayInstallment = async (installmentId) => {
    try {
      await payInstallment({
        variables: {
          input: { installmentId },
        },
      });

      const updatedInstallments = installments.map((installment) => {
        if (installment.id === installmentId) {
          return { ...installment, status: "Pago" };
        }
        return installment;
      });

      setInstallments(updatedInstallments);
    } catch (error) {
      console.error("Erro ao pagar parcela:", error.message);
    }
  };

  const handleExtendHeader = () => setIsExtended(true);
  const handleCloseExtendedHeader = () => setIsExtended(false);

  if (loading) return <p className="text-blue-500">Carregando cotas...</p>;
  if (error) return <p className="text-red-500">Erro ao carregar cotas: {error.message}</p>;

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
          Cotas do Cliente
        </div>

        <div
          className="flex items-start justify-start mt-4 ml-4 font-semibold"
          style={{ color: "#1E2261" }}
        >
          <BreadcrumbClientProfile setCurrentPage={setCurrentPage} />
        </div>

        <div className="flex justify-end mb-4 mt-4 mr-4">
          <button
            onClick={() => setIsEditModalOpen(true)}
            className="px-4 py-2 font-bold text-white bg-darkBlue rounded hover:bg-lightBlue transition duration-200"
          >
            Editar Cliente
          </button>
        </div>

        <div className="bg-white shadow-lg rounded-lg overflow-x-auto mx-4">
          <table className="table-auto min-w-full divide-y divide-gray-200">
            <thead className="bg-darkBlue">
              <tr>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Número da Cota
                </th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-gray-200">
              {data.getQuotasByClientId.map((quota) => (
                <tr
                  key={quota.id}
                  className="hover:bg-gray-100 cursor-pointer"
                  onClick={() => handleQuotaClick(quota.id)}
                >
                  <td className="px-6 py-4 text-sm text-gray-500">{quota.id}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>

      {isEditModalOpen && (
        <div className="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50 z-50">
          <div className="bg-white p-6 rounded shadow-lg w-full max-w-3xl">
            <h2 className="text-xl font-bold mb-4 text-darkBlue text-center">
              Editar Cliente
            </h2>
            <div className="grid grid-cols-2 gap-6">
              <div className="col-span-2 md:col-span-1">
                <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="editName">
                  Nome
                </label>
                <input
                  id="editName"
                  type="text"
                  value={editName}
                  onChange={(e) => setEditName(e.target.value)}
                  className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Nome do Cliente"
                  required
                />
              </div>
              <div className="col-span-2 md:col-span-1">
                <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="editEmail">
                  Email
                </label>
                <input
                  id="editEmail"
                  type="email"
                  value={editEmail}
                  onChange={(e) => setEditEmail(e.target.value)}
                  className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Email do Cliente"
                  required
                />
              </div>
            </div>
            <div className="flex justify-end mt-6 gap-4">
              <button
                onClick={() => setIsEditModalOpen(false)}
                className="px-4 py-2 bg-gray-400 hover:bg-gray-500 text-white font-bold rounded focus:outline-none focus:ring-2 focus:ring-gray-500"
              >
                Cancelar
              </button>
              <button
                onClick={handleUpdateClient}
                className="px-4 py-2 bg-darkBlue hover:bg-lightBlue text-white font-bold rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
              >
                Salvar
              </button>
            </div>
          </div>
        </div>
      )}

      {isInstallmentModalOpen && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
          <div className="bg-white p-6 rounded shadow-lg w-96 max-h-[80vh] overflow-y-auto">
            <h2 className="text-xl font-bold text-darkBlue mb-4 text-center">
              Parcelas da Cota {selectedQuotaId}
            </h2>
            <table className="table-auto w-full divide-y divide-gray-200">
              <thead className="bg-darkBlue">
                <tr>
                  <th className="px-4 py-2 text-left text-xs font-medium text-white uppercase tracking-wider">
                    ID
                  </th>
                  <th className="px-4 py-2 text-left text-xs font-medium text-white uppercase tracking-wider">
                    Valor
                  </th>
                  <th className="px-4 py-2 text-left text-xs font-medium text-white uppercase tracking-wider">
                    Status
                  </th>
                  <th className="px-4 py-2"></th>
                </tr>
              </thead>
              <tbody className="bg-white divide-y divide-gray-200">
                {installments.map((installment) => (
                  <tr key={installment.id}>
                    <td className="px-4 py-2 text-sm text-gray-500">{installment.id}</td>
                    <td className="px-4 py-2 text-sm text-gray-500">{installment.value}</td>
                    <td className="px-4 py-2 text-sm text-gray-500">{installment.status}</td>
                    <td className="px-4 py-2 text-right">
                      {installment.status !== "Pago" && (
                        <button
                          onClick={() => handlePayInstallment(installment.id)}
                          className="bg-green-500 hover:bg-green-600 text-white px-2 py-1 rounded text-xs font-bold"
                        >
                          Pagar
                        </button>
                      )}
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
            <div className="flex justify-center mt-4">
              <button
                onClick={() => setIsInstallmentModalOpen(false)}
                className="bg-gray-400 hover:bg-gray-500 text-white px-4 py-2 rounded transition"
              >
                Fechar
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

const ClientProfilePage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <ClientProfilePageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default ClientProfilePage;
