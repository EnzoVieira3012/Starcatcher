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
import { Provider as ReduxProvider } from "react-redux";
import { store } from "../redux/store";
import Header from "../components/Header";
import ExtendedHeader from "../components/ExtendedHeader";
import Breadcrumb from "./components/Breadcrumb";
import "../index.css";

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

const CREATE_CLIENT = gql`
  mutation CreateClient($createClientInput: CreateClientInput!) {
    createClient(createClientInput: $createClientInput)
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

const DELETE_CLIENT = (id) => gql`
  mutation {
    deleteClient(id: ${id})
  }
`;

const ClientListPageContent = ({ setCurrentPage }) => {
  const { loading, error, data, refetch } = useQuery(LIST_CLIENTS);
  const [createClient] = useMutation(CREATE_CLIENT);

  const [isExtended, setIsExtended] = useState(false);
  const [isCreating, setIsCreating] = useState(false);
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [phone, setPhone] = useState("");

  const handleExtendHeader = () => {
    setIsExtended(true);
  };

  const handleCloseExtendedHeader = () => {
    setIsExtended(false);
  };

  const handleCreateClient = async () => {
    try {
      await createClient({
        variables: {
          createClientInput: { name, email, phone },
        },
      });

      setIsCreating(false);
      setName("");
      setEmail("");
      setPhone("");
      refetch();
    } catch (error) {
      console.error("Erro ao criar cliente:", error);
    }
  };

  const handleDeleteClient = async (id) => {
    try {
      await client.mutate({
        mutation: DELETE_CLIENT(id),
      });

      refetch();
    } catch (error) {
      console.error("Erro ao deletar cliente:", error.message);
    }
  };

  const handleClientClick = (clientId) => {
    localStorage.setItem("selectedClientId", clientId);
    setCurrentPage("clientProfile");
  };

  if (loading) return <p className="text-blue-500">Carregando...</p>;
  if (error) return <p className="text-red-500">Erro ao carregar clientes.</p>;

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
          Lista de Clientes
        </div>

        <div
          className="flex items-start justify-start mt-4 ml-4 font-semibold"
          style={{ color: "#1E2261" }}
        >
          <Breadcrumb setCurrentPage={setCurrentPage} />
        </div>

        <div className="flex justify-end mb-4 mt-4 mr-4">
          <button
            onClick={() => setIsCreating(true)}
            className="px-4 py-2 font-bold text-white bg-darkBlue rounded hover:bg-lightBlue transition duration-200"
          >
            Criar Novo Cliente
          </button>
        </div>

        <div className="bg-white shadow-lg rounded-lg overflow-x-auto mx-4">
          <table className="table-auto min-w-full divide-y divide-gray-200">
            <thead className="bg-darkBlue">
              <tr>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  ID
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Nome
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Email
                </th>
                <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
                  Telefone
                </th>
                <th className="px-6 py-3 text-right text-xs font-medium text-white uppercase tracking-wider"></th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-gray-200">
              {data.listClients.map((client) => (
                <tr
                  key={client.id}
                  className="hover:bg-gray-100 cursor-pointer"
                  onClick={(e) => {
                    if (e.target.tagName !== "BUTTON") {
                      handleClientClick(client.id);
                    }
                  }}
                >
                  <td className="px-6 py-4 text-sm text-gray-500">{client.id}</td>
                  <td className="px-6 py-4 text-sm text-gray-500">{client.name}</td>
                  <td className="px-6 py-4 text-sm text-gray-500">{client.email}</td>
                  <td className="px-6 py-4 text-sm text-gray-500">{client.phone}</td>
                  <td className="px-6 py-4 text-sm text-right">
                    <button
                      onClick={() => handleDeleteClient(client.id)}
                      className="text-red-600 hover:text-red-800 font-bold"
                    >
                      Deletar
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>
      </div>

      {isCreating && (
        <div className="fixed inset-0 flex items-center justify-center bg-black bg-opacity-50 z-50">
          <div className="bg-white p-6 rounded shadow-lg w-full max-w-md">
            <h2 className="text-xl font-bold mb-4 text-darkBlue">Criar Novo Cliente</h2>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="name">
                Nome
              </label>
              <input
                id="name"
                type="text"
                value={name}
                onChange={(e) => setName(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                placeholder="Nome do Cliente"
                required
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
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                placeholder="Email do Cliente"
                required
              />
            </div>
            <div className="mb-4">
              <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="phone">
                Telefone
              </label>
              <input
                id="phone"
                type="text"
                value={phone}
                onChange={(e) => setPhone(e.target.value)}
                className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                placeholder="Telefone do Cliente"
                required
              />
            </div>
            <div className="flex items-center justify-end gap-4">
              <button
                onClick={() => setIsCreating(false)}
                className="bg-gray-400 hover:bg-gray-500 text-white px-4 py-2 font-bold rounded focus:outline-none focus:ring-2 focus:ring-gray-500"
              >
                Cancelar
              </button>
              <button
                onClick={handleCreateClient}
                className="bg-darkBlue hover:bg-lightBlue text-white px-4 py-2 font-bold rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
              >
                Criar
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

const ClientListPage = ({ setCurrentPage }) => (
  <ReduxProvider store={store}>
    <ApolloProvider client={client}>
      <ClientListPageContent setCurrentPage={setCurrentPage} />
    </ApolloProvider>
  </ReduxProvider>
);

export default ClientListPage;