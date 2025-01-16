import React, { useState, useEffect } from "react";
import {
  ApolloClient,
  InMemoryCache,
  createHttpLink,
  ApolloProvider as Provider,
  useQuery,
  useMutation,
  gql,
} from "@apollo/client";
import { setContext } from "@apollo/client/link/context";
import Header from "../components/Header";
import ExtendedHeader from "../components/ExtendedHeader";
import Breadcrumb from "./components/Breadcrumb";
import UserInfoTable from "./components/UserInfoTable";
import EditForm from "./components/EditForm";
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

const GET_USER_INFO = gql`
  query {
    me {
      id
      name
      email
    }
  }
`;

const CHANGE_NAME_MUTATION = gql`
  mutation ChangeName($changeNameInput: ChangeNameInput!) {
    changeName(changeNameInput: $changeNameInput)
  }
`;

const CHANGE_EMAIL_MUTATION = gql`
  mutation ChangeEmail($newEmail: String!) {
    changeEmail(changeEmailInput: { newEmail: $newEmail })
  }
`;

const CHANGE_PASSWORD_MUTATION = gql`
  mutation ChangePassword($email: String!, $newPassword: String!) {
    changePassword(changePasswordInput: { email: $email, newPassword: $newPassword })
  }
`;

const DELETE_ACCOUNT_MUTATION = gql`
  mutation DeleteAccount($password: String!) {
    deleteAccount(deleteAccountInput: { password: $password })
  }
`;

const ProfilePageContent = ({ setCurrentPage, isExtended }) => {
  const { loading, error, data, refetch } = useQuery(GET_USER_INFO);
  const [changeName] = useMutation(CHANGE_NAME_MUTATION);
  const [changeEmail] = useMutation(CHANGE_EMAIL_MUTATION);
  const [changePassword] = useMutation(CHANGE_PASSWORD_MUTATION);
  const [deleteAccount] = useMutation(DELETE_ACCOUNT_MUTATION);

  const [visibleForm, setVisibleForm] = useState("");
  const [newName, setNewName] = useState("");
  const [newEmail, setNewEmail] = useState("");
  const [passwordEmail, setPasswordEmail] = useState("");
  const [newPassword, setNewPassword] = useState("");
  const [deletePassword, setDeletePassword] = useState("");

  if (loading) return <p className="text-blue-500">Carregando dados...</p>;
  if (error) return <p className="text-red-500">Erro ao carregar dados do usuário.</p>;

  const { name, email } = data.me;

  return (
    <div
      className={`flex-grow flex flex-col transition-all duration-300 relative ${
        isExtended ? "ml-64" : "ml-16"
      } bg-gray-100`}
    >
      <div
        className="absolute top-4 right-4 font-bold text-3xl"
        style={{ color: "#1E2261" }}
      >
        Página de Perfil
      </div>

      <div
        className="flex items-start justify-start mt-4 ml-4 font-semibold"
        style={{ color: "#1E2261" }}
      >
        <Breadcrumb setCurrentPage={setCurrentPage} />
      </div>

      <main className="flex-grow flex items-start justify-center mt-2">
        <UserInfoTable
          name={name}
          email={email}
          setVisibleForm={setVisibleForm}
        />
      </main>

      {visibleForm !== "" && (
        <div className="fixed inset-0 bg-black bg-opacity-50 flex items-center justify-center z-50">
          <EditForm
            visibleForm={visibleForm}
            setVisibleForm={setVisibleForm}
            newName={newName}
            setNewName={setNewName}
            newEmail={newEmail}
            setNewEmail={setNewEmail}
            passwordEmail={passwordEmail}
            setPasswordEmail={setPasswordEmail}
            newPassword={newPassword}
            setNewPassword={setNewPassword}
            deletePassword={deletePassword}
            setDeletePassword={setDeletePassword}
            handleChangeName={async () => {
              try {
                await changeName({
                  variables: { changeNameInput: { newName } },
                });
                refetch();
                setVisibleForm("");
              } catch (err) {
                console.error("Erro ao alterar o nome:", err);
              }
            }}
            handleChangeEmail={async () => {
              try {
                await changeEmail({ variables: { newEmail } });
                refetch();
                setVisibleForm("");
              } catch (err) {
                console.error("Erro ao alterar o email:", err);
              }
            }}
            handleChangePassword={async () => {
              try {
                await changePassword({
                  variables: { email: passwordEmail, newPassword },
                });
                refetch();
                setVisibleForm("");
              } catch (err) {
                console.error("Erro ao alterar a senha:", err);
              }
            }}
            handleDeleteAccount={async () => {
              try {
                await deleteAccount({
                  variables: { password: deletePassword },
                });
                localStorage.removeItem("token");
                window.location.reload();
              } catch (err) {
                console.error("Erro ao deletar conta:", err);
              }
            }}
          />
        </div>
      )}
    </div>
  );
};

const ProfilePage = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);

  useEffect(() => {
    const token = localStorage.getItem("token");
    if (!token) {
      setCurrentPage("login");
    }
  }, [setCurrentPage]);

  return (
    <Provider client={client}>
      <div className="flex min-h-screen bg-gray-100">
        <div className="flex flex-col bg-white shadow-md transition-all duration-300">
          <Header
            onIconClick={() => setIsExtended(true)}
            setCurrentPage={setCurrentPage}
          />
          {isExtended && (
            <ExtendedHeader
              onClose={() => setIsExtended(false)}
              setCurrentPage={setCurrentPage}
            />
          )}
        </div>

        <ProfilePageContent
          setCurrentPage={setCurrentPage}
          isExtended={isExtended}
        />
      </div>
    </Provider>
  );
};

export default ProfilePage;