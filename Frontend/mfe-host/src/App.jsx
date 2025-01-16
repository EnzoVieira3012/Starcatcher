import React, { useState, useEffect } from "react";
import DashboardPage from "user/DashboardPage";
import ProfilePage from "user/ProfilePage";
import QuotaListPage from "quota/QuotaListPage";
import CreateConsortiumPage from "consortium/CreateConsortiumPage";
import ConsortiumListPage from "consortium/ConsortiumListPage";
import ClientProfilePage from "clients/ClientProfilePage";
import ClientListPage from "clients/ClientListPage";
import ChangePasswordPage from "auth/ChangePasswordPage";
import RegisterPage from "auth/RegisterPage";
import LoginPage from "auth/LoginPage";

function App() {
  const [currentPage, setCurrentPage] = useState(() => {
    return localStorage.getItem("currentPage") || "login";
  });

  useEffect(() => {
    localStorage.setItem("currentPage", currentPage);
  }, [currentPage]);

  const renderPage = () => {
    switch (currentPage) {
      case "login":
        return <LoginPage setCurrentPage={setCurrentPage} />;
      case "register":
        return <RegisterPage setCurrentPage={setCurrentPage} />;
      case "changePassword":
        return <ChangePasswordPage setCurrentPage={setCurrentPage} />;
      case "clients":
        return <ClientListPage setCurrentPage={setCurrentPage} />;
      case "clientProfile":
        return <ClientProfilePage setCurrentPage={setCurrentPage} />;
      case "consortiums":
        return <ConsortiumListPage setCurrentPage={setCurrentPage} />;
      case "createConsortium":
        return <CreateConsortiumPage setCurrentPage={setCurrentPage} />;
      case "quotas":
        return <QuotaListPage setCurrentPage={setCurrentPage} />;
      case "profile":
        return <ProfilePage setCurrentPage={setCurrentPage} />;
      case "dashboard":
        return <DashboardPage setCurrentPage={setCurrentPage} />;
      default:
        return <LoginPage setCurrentPage={setCurrentPage} />;
    }
  };

  return (
    <div>
      <div>{renderPage()}</div>
    </div>
  );
}

export default App;