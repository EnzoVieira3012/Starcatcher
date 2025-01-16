import React, { useState } from "react";
import { ApolloProvider, ApolloClient, InMemoryCache, useMutation, gql } from "@apollo/client";
import starcatcherIcon from "../assets/starcatcher_icon.png";
import "../index.css";

const CHANGE_PASSWORD_MUTATION = gql`
  mutation ChangePassword($email: String!, $newPassword: String!) {
    changePassword(changePasswordInput: { email: $email, newPassword: $newPassword })
  }
`;

const client = new ApolloClient({
  uri: "http://localhost:3000/graphql",
  cache: new InMemoryCache(),
});

const ChangePasswordPageContent = ({ setCurrentPage }) => {
  const [email, setEmail] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [changePassword] = useMutation(CHANGE_PASSWORD_MUTATION);

  const handleChangePassword = async () => {
    try {
      await changePassword({ variables: { email, newPassword } });
      console.log("Senha alterada com sucesso");
      setCurrentPage("login");
    } catch (error) {
      console.error("Erro durante a mudança de senha:", error);
    }
  };

  return (
    <div
      className="min-h-screen flex items-center relative"
      style={{ backgroundColor: "#1E2261" }}
    >
      <div
        className="absolute left-1/2 transform -translate-x-[calc(50%+10rem)] top-1/2 -translate-y-1/2"
      >
        <img
          src={starcatcherIcon}
          alt="Starcatcher Icon"
          className="w-[512px] h-[512px] object-contain"
        />
      </div>

      <div className="absolute right-0 w-full max-w-xs h-screen bg-white flex flex-col justify-center px-8 shadow-md">
        <h1
          className="mb-6 text-2xl font-bold text-left"
          style={{ color: "#1E2261" }}
        >
          Alterar Senha
        </h1>
        <div className="mb-4">
          <label
            htmlFor="email"
            className="block mb-2 text-sm font-bold"
            style={{ color: "#1E2261" }}
          >
            Email
          </label>
          <input
            id="email"
            type="email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
            placeholder="Email"
          />
        </div>
        <div className="mb-4">
          <label
            htmlFor="new-password"
            className="block mb-2 text-sm font-bold"
            style={{ color: "#1E2261" }}
          >
            Nova Senha
          </label>
          <input
            id="new-password"
            type="password"
            value={newPassword}
            onChange={(e) => setNewPassword(e.target.value)}
            className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
            placeholder="********"
          />
        </div>
        <div className="mb-4">
          <button
            onClick={handleChangePassword}
            className="w-full px-4 py-2 font-bold text-white rounded focus:outline-none focus:shadow-outline text-left"
            style={{
              backgroundColor: "#1E2261",
            }}
            onMouseEnter={(e) => (e.target.style.backgroundColor = "#4F59A6")}
            onMouseLeave={(e) => (e.target.style.backgroundColor = "#1E2261")}
          >
            Alterar Senha
          </button>
        </div>
        <div className="text-left">
          <button
            onClick={() => {
              document.getElementById("loginButton").click();
            }}
            className="text-sm text-blue-500 bg-transparent border-none cursor-pointer hover:text-blue-800 focus:outline-none"
          >
            Voltar para o Login
          </button>
        </div>
      </div>

      <button
        id="loginButton"
        style={{ display: "none" }}
        onClick={() => setCurrentPage("login")}
      >
        Login
      </button>
      <button
        id="registerButton"
        style={{ display: "none" }}
        onClick={() => setCurrentPage("register")}
      >
        Register
      </button>
    </div>
  );
};

const ChangePasswordPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <ChangePasswordPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default ChangePasswordPage;