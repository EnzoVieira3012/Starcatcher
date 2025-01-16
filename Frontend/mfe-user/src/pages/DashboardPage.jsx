import React, { useState } from "react";
import { ApolloProvider, ApolloClient, InMemoryCache } from "@apollo/client";
import Header from "../components/Header";
import ExtendedHeader from "../components/ExtendedHeader";
import starcatcherIcon from "../assets/starcatcher_icon.png";
import "../index.css";

const client = new ApolloClient({
  uri: "http://localhost:3000/graphql",
  cache: new InMemoryCache(),
});

const DashboardPageContent = ({ setCurrentPage }) => {
  const [isExtended, setIsExtended] = useState(false);

  const handleExtendHeader = () => {
    setIsExtended(true);
  };

  const handleCloseExtendedHeader = () => {
    setIsExtended(false);
  };

  return (
    <div className="flex flex-row min-h-screen bg-gray-100 relative">
      <Header onIconClick={handleExtendHeader} />

      {isExtended && (
        <ExtendedHeader
          onClose={handleCloseExtendedHeader}
          setCurrentPage={setCurrentPage}
        />
      )}

      <div className="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2">
        <img
          src={starcatcherIcon}
          alt="Starcatcher Icon"
          className="w-full h-full max-w-screen max-h-screen object-contain"
        />
      </div>

      <main
        className={`flex-grow ${
          isExtended ? "ml-64" : "ml-16"
        } flex items-center justify-center p-8`}
      >
      </main>
    </div>
  );
};

const DashboardPage = ({ setCurrentPage }) => (
  <ApolloProvider client={client}>
    <DashboardPageContent setCurrentPage={setCurrentPage} />
  </ApolloProvider>
);

export default DashboardPage;