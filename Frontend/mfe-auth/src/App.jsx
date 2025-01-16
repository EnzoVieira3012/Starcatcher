import React from "react";
import ApolloProvider from "./ApolloProvider";
import LoginPage from "./pages/LoginPage";
import RegisterPage from "./pages/RegisterPage"
import ChangePasswordPage from "./pages/ChangePasswordPage";

function App() {
  return (
        <ApolloProvider>
          <LoginPage />
          <RegisterPage />
          <ChangePasswordPage />
        </ApolloProvider>
  );
}

export default App;
