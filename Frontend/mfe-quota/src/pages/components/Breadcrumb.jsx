import React from "react";

const Breadcrumb = ({ setCurrentPage }) => {
  return (
    <div className="flex items-center gap-2 p-4 transition-all duration-300">
      <button
        onClick={() => setCurrentPage("dashboard")}
        className="text-blue-500 hover:text-blue-800 text-sm"
      >
        Dashboard
      </button>
      <span className="text-gray-500 text-sm"> &gt; </span>
      <button
        onClick={() => setCurrentPage("consortiums")}
        className="text-blue-500 hover:text-blue-800 text-sm"
      >
        Lista de Consórcios
      </button>
      <span className="text-gray-500 text-sm"> &gt; </span>
      <span
        className="text-sm font-semibold"
        style={{ color: "#1E2261" }}
      >
        Lista de Cotas
      </span>
    </div>
  );
};

export default Breadcrumb;