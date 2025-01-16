import React, { useState } from "react";
import { ApolloProvider, ApolloClient, InMemoryCache, useMutation, gql } from "@apollo/client";
import starcatcherIcon from "../assets/starcatcher_icon.png";
import "../index.css";

const REGISTER_MUTATION = gql`
  mutation Register($name: String!, $email: String!, $password: String!) {
    register(registerInput: { name: $name, email: $email, password: $password }) {
      token
    }
  }
`;

const client = new ApolloClient({
  uri: "http://localhost:3000/graphql",
  cache: new InMemoryCache(),
});

const RegisterPageContent = ({ setCurrentPage }) => {
  const [name, setName] = useState("");
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [register] = useMutation(REGISTER_MUTATION);

  const handleRegister = async () => {
    try {
      const { data } = await register({ variables: { name, email, password } });
      if (data.register.token) {
        console.log("Cadastro bem-sucedido:", data.register.token);
        localStorage.setItem("token", data.register.token);
        setCurrentPage("dashboard");
      }
    } catch (error) {
      console.error("Erro durante o cadastro:", error);
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
          Cadastro
        </h1>
        <div className="mb-4">
          <label
            htmlFor="name"
            className="block mb-2 text-sm font-bold"
            style={{ color: "#1E2261" }}
          >
            Nome
          </label>
          <input
            id="name"
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
            placeholder="Nome"
          />
        </div>
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
            htmlFor="password"
            className="block mb-2 text-sm font-bold"
            style={{ color: "#1E2261" }}
          >
            Senha
          </label>
          <input
            id="password"
            type="password"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            className="w-full px-3 py-2 leading-tight text-gray-700 border rounded shadow appearance-none focus:outline-none focus:shadow-outline"
            placeholder="********"
          />
        </div>
        <div className="mb-4">
          <button
            onClick={handleRegister}
            className="w-full px-4 py-2 font-bold text-white rounded focus:outline-none focus:shadow-outline text-left"
            style={{
              backgroundColor: "#1E2261",
            }}
            onMouseEnter={(e) => (e.target.style.backgroundColor = "#4F59A6")}
            onMouseLeave={(e) => (e.target.style.backgroundColor = "#1E2261")}
          >
            Criar Conta
          </button>
        </div>
        <div className="text-left">
          <p className="text-sm text-gray-500">
            Já tem uma conta?{" "}
            <button
              onClick={() => {
                document.getElementById("loginButton").click();
              }}
              className="text-blue-500 bg-transparent border-none cursor-pointer hover:text-blue-800 focus:outline-none"
            >
              Voltar para o Login
            </button>
          </p>
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
        id="changePasswordButton"
        style={{ display: "none" }}
        onClick={() => setCurrentPage("changePassword")}
      >
        Change Password
      </button>
    </div>
  );
};

const RegisterPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <RegisterPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default RegisterPage;