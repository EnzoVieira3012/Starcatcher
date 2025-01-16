import React, { useState } from "react";
import {
  ApolloProvider,
  ApolloClient,
  InMemoryCache,
  useMutation,
  gql,
  createHttpLink,
} from "@apollo/client";
import { setContext } from "@apollo/client/link/context";
import Header from "../components/Header";
import ExtendedHeader from "../components/ExtendedHeader";
import { BreadcrumbCreateConsortium } from "./components/Breadcrumb";
import "../index.css";

const CREATE_CONSORTIUM = gql`
  mutation CreateConsortium($createConsortiumInput: CreateConsortiumInput!) {
    createConsortium(createConsortiumInput: $createConsortiumInput)
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

const CreateConsortiumPageContent = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");
  const [assetValue, setAssetValue] = useState("");
  const [numberOfInstallments, setNumberOfInstallments] = useState("");
  const [administrationFee, setAdministrationFee] = useState("");
  const [numberOfQuotas, setNumberOfQuotas] = useState("");
  const [createConsortium] = useMutation(CREATE_CONSORTIUM);

  const handleExtendHeader = () => {
    setIsExtended(true);
  };

  const handleCloseExtendedHeader = () => {
    setIsExtended(false);
  };

  const handleCreateConsortium = async (e) => {
    e.preventDefault();

    try {
      await createConsortium({
        variables: {
          createConsortiumInput: {
            name,
            description,
            assetValue: parseFloat(assetValue),
            numberOfInstallments: parseInt(numberOfInstallments, 10),
            administrationFee: parseFloat(administrationFee),
            numberOfQuotas: parseInt(numberOfQuotas, 10),
          },
        },
      });

      setCurrentPage("consortiums");
    } catch (error) {
      console.error("Erro ao criar consórcio:", error);
    }
  };

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
          Criar Consórcio
        </div>

        <div
          className="flex items-start justify-start mt-4 ml-4 font-semibold"
          style={{ color: "#1E2261" }}
        >
          <BreadcrumbCreateConsortium setCurrentPage={setCurrentPage} />
        </div>

        <div className="flex justify-center items-center min-h-[calc(100vh-8rem)]">
          <form
            onSubmit={handleCreateConsortium}
            className="grid grid-cols-2 gap-8 bg-white shadow-lg rounded-lg px-8 pt-6 pb-8 w-full max-w-4xl"
          >
            <div className="col-span-2 md:col-span-1">
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="name"
                >
                  Nome do Consórcio
                </label>
                <input
                  id="name"
                  type="text"
                  value={name}
                  onChange={(e) => setName(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Nome do Consórcio"
                  required
                />
              </div>
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="description"
                >
                  Descrição
                </label>
                <textarea
                  id="description"
                  value={description}
                  onChange={(e) => setDescription(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Descrição do Consórcio"
                  required
                />
              </div>
            </div>

            <div className="col-span-2 md:col-span-1">
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="assetValue"
                >
                  Valor do Bem
                </label>
                <input
                  id="assetValue"
                  type="number"
                  value={assetValue}
                  onChange={(e) => setAssetValue(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Valor do Bem"
                  required
                />
              </div>
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="numberOfInstallments"
                >
                  Número de Parcelas
                </label>
                <input
                  id="numberOfInstallments"
                  type="number"
                  value={numberOfInstallments}
                  onChange={(e) => setNumberOfInstallments(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Número de Parcelas"
                  required
                />
              </div>
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="administrationFee"
                >
                  Taxa de Administração (%)
                </label>
                <input
                  id="administrationFee"
                  type="number"
                  step="0.01"
                  value={administrationFee}
                  onChange={(e) => setAdministrationFee(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Taxa de Administração"
                  required
                />
              </div>
              <div className="mb-4">
                <label
                  className="block text-gray-700 text-sm font-bold mb-2"
                  htmlFor="numberOfQuotas"
                >
                  Número de Cotas
                </label>
                <input
                  id="numberOfQuotas"
                  type="number"
                  value={numberOfQuotas}
                  onChange={(e) => setNumberOfQuotas(e.target.value)}
                  className="w-full px-3 py-2 border rounded text-gray-700 bg-white leading-tight focus:outline-none focus:ring-2 focus:ring-blue-500"
                  placeholder="Número de Cotas"
                  required
                />
              </div>
            </div>

            <div className="col-span-2 flex justify-center mt-4">
              <button
                type="submit"
                className="bg-darkBlue hover:bg-lightBlue text-white font-bold py-2 px-8 rounded focus:outline-none focus:ring-2 focus:ring-blue-500"
              >
                Criar Consórcio
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>
  );
};

const CreateConsortiumPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <CreateConsortiumPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default CreateConsortiumPage;