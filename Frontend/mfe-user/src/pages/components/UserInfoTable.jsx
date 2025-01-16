import React, { useState } from "react";

const UserInfoTable = ({ name, email, setVisibleForm }) => {
  const [isMenuOpen, setIsMenuOpen] = useState(false);

  const toggleMenu = () => {
    setIsMenuOpen(!isMenuOpen);
  };

  const closeMenu = () => {
    setIsMenuOpen(false);
  };

  return (
    <div className="relative bg-white shadow-lg rounded-lg overflow-x-auto w-full max-w-4xl mx-auto">
      <table className="table-auto min-w-full divide-y divide-gray-200">
        <thead className="bg-[#1E2261]">
          <tr>
            <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
              Nome
            </th>
            <th className="px-6 py-3 text-left text-xs font-medium text-white uppercase tracking-wider">
              Email
            </th>
          </tr>
        </thead>
        <tbody className="bg-white divide-y divide-gray-200">
          <tr className="hover:bg-gray-100 cursor-pointer" onClick={toggleMenu}>
            <td className="px-6 py-4">{name}</td>
            <td className="px-6 py-4">{email}</td>
          </tr>
        </tbody>
      </table>

      {isMenuOpen && (
        <div className="fixed top-40 right-10 bg-white shadow-lg rounded-lg p-4 w-64 border z-50">
          <h2
            className="text-sm font-semibold mb-3 text-center"
            style={{ color: "#1E2261" }}
          >
            Menu de Opções
          </h2>
          <button
            onClick={() => setVisibleForm("nome")}
            className="bg-[#1E2261] text-white w-full py-1.5 rounded-md text-sm hover:bg-blue-600 mb-2"
          >
            Alterar Nome
          </button>
          <button
            onClick={() => setVisibleForm("email")}
            className="bg-[#1E2261] text-white w-full py-1.5 rounded-md text-sm hover:bg-blue-600 mb-2"
          >
            Alterar Email
          </button>
          <button
            onClick={() => setVisibleForm("senha")}
            className="bg-[#1E2261] text-white w-full py-1.5 rounded-md text-sm hover:bg-blue-600 mb-2"
          >
            Alterar Senha
          </button>
          <button
            onClick={() => setVisibleForm("deletar")}
            className="bg-red-700 text-white w-full py-1.5 rounded-md text-sm hover:bg-red-800 mb-2"
          >
            Deletar Conta
          </button>
          <button
            onClick={closeMenu}
            className="bg-gray-300 text-gray-800 w-full py-1.5 rounded-md text-sm hover:bg-gray-400"
          >
            Fechar
          </button>
        </div>
      )}
    </div>
  );
};

export default UserInfoTable;