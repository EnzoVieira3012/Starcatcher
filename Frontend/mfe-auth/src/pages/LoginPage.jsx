import React, { useState } from "react";
import { ApolloProvider, ApolloClient, InMemoryCache, useMutation, gql } from "@apollo/client";
import starcatcherIcon from "../assets/starcatcher_icon.png";
import "../index.css";

const LOGIN_MUTATION = gql`
  mutation Login($email: String!, $password: String!) {
    login(loginInput: { email: $email, password: $password }) {
      token
    }
  }
`;

const client = new ApolloClient({
  uri: "http://localhost:3000/graphql",
  cache: new InMemoryCache(),
});

const LoginPageContent = ({ setCurrentPage }) => {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [errorMessage, setErrorMessage] = useState("");
  const [login] = useMutation(LOGIN_MUTATION);

  const handleLogin = async () => {
    try {
      const { data } = await login({ variables: { email, password } });
      if (data.login.token) {
        console.log("Login bem-sucedido:", data.login.token);
        localStorage.setItem("token", data.login.token);
        setErrorMessage("");
        setCurrentPage("dashboard");
      }
    } catch (error) {
      console.error("Erro durante o login:", error);
      setErrorMessage("Credenciais inválidas. Verifique seu email e senha.");
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
          Login
        </h1>
        {errorMessage && (
          <p className="mb-4 text-sm font-bold text-red-500">{errorMessage}</p>
        )}
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
        <div className="mb-4 text-left">
          <button
            onClick={() => {
              document.getElementById("changePasswordButton").click();
            }}
            className="text-sm text-blue-500 bg-transparent border-none cursor-pointer hover:text-blue-800 focus:outline-none"
          >
            Esqueceu a senha?
          </button>
        </div>
        <div className="mb-4">
          <button
            onClick={handleLogin}
            className="w-full px-4 py-2 font-bold text-white bg-darkBlue rounded hover:bg-lightBlue focus:outline-none focus:shadow-outline text-left"
          >
            Entrar
          </button>
        </div>
        <div className="text-left">
          <p className="text-sm text-gray-500">
            Não tem uma conta?{" "}
            <button
              onClick={() => {
                document.getElementById("registerButton").click();
              }}
              className="text-blue-500 bg-transparent border-none cursor-pointer hover:text-blue-800 focus:outline-none"
            >
              Cadastre-se
            </button>
          </p>
        </div>
      </div>

      <button
        id="changePasswordButton"
        style={{ display: "none" }}
        onClick={() => setCurrentPage("changePassword")}
      >
        Change Password
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

const LoginPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <LoginPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default LoginPage;