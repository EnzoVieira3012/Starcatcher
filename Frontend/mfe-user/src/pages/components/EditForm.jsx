import React from "react";

const EditForm = ({
  visibleForm,
  setVisibleForm,
  newName,
  setNewName,
  newEmail,
  setNewEmail,
  passwordEmail,
  setPasswordEmail,
  newPassword,
  setNewPassword,
  deletePassword,
  setDeletePassword,
  handleChangeName,
  handleChangeEmail,
  handleChangePassword,
  handleDeleteAccount,
}) => {
  return (
    <div className="bg-white shadow-md rounded p-6 w-full max-w-screen-md mx-auto mt-6">
      {visibleForm === "nome" && (
        <>
          <h2 className="text-2xl font-semibold mb-6 text-center" style={{ color: "#1E2261" }}>
            Alterar Nome
          </h2>
          <div className="flex flex-col items-center gap-4">
            <input
              type="text"
              value={newName}
              onChange={(e) => setNewName(e.target.value)}
              placeholder="Digite o novo nome"
              className="border border-gray-300 rounded px-4 py-2 w-full focus:ring-2 focus:ring-blue-500"
            />
            <button
              onClick={handleChangeName}
              className="bg-[#1E2261] text-white font-bold px-6 py-2 rounded hover:bg-blue-600 w-full"
            >
              Confirmar
            </button>
            <button
              onClick={() => setVisibleForm("")}
              className="bg-gray-300 text-gray-800 font-bold px-6 py-2 rounded hover:bg-gray-400 w-full"
            >
              Cancelar
            </button>
          </div>
        </>
      )}
      {visibleForm === "email" && (
        <>
          <h2 className="text-2xl font-semibold mb-6 text-center" style={{ color: "#1E2261" }}>
            Alterar Email
          </h2>
          <div className="flex flex-col items-center gap-4">
            <input
              type="email"
              value={newEmail}
              onChange={(e) => setNewEmail(e.target.value)}
              placeholder="Digite o novo email"
              className="border border-gray-300 rounded px-4 py-2 w-full focus:ring-2 focus:ring-blue-500"
            />
            <button
              onClick={handleChangeEmail}
              className="bg-[#1E2261] text-white font-bold px-6 py-2 rounded hover:bg-blue-600 w-full"
            >
              Confirmar
            </button>
            <button
              onClick={() => setVisibleForm("")}
              className="bg-gray-300 text-gray-800 font-bold px-6 py-2 rounded hover:bg-gray-400 w-full"
            >
              Cancelar
            </button>
          </div>
        </>
      )}
      {visibleForm === "senha" && (
        <>
          <h2 className="text-2xl font-semibold mb-6 text-center" style={{ color: "#1E2261" }}>
            Alterar Senha
          </h2>
          <div className="flex flex-col items-center gap-4">
            <input
              type="email"
              value={passwordEmail}
              onChange={(e) => setPasswordEmail(e.target.value)}
              placeholder="Digite seu email"
              className="border border-gray-300 rounded px-4 py-2 w-full focus:ring-2 focus:ring-blue-500"
            />
            <input
              type="password"
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
              placeholder="Digite a nova senha"
              className="border border-gray-300 rounded px-4 py-2 w-full focus:ring-2 focus:ring-blue-500"
            />
            <button
              onClick={handleChangePassword}
              className="bg-[#1E2261] text-white font-bold px-6 py-2 rounded hover:bg-blue-600 w-full"
            >
              Confirmar
            </button>
            <button
              onClick={() => setVisibleForm("")}
              className="bg-gray-300 text-gray-800 font-bold px-6 py-2 rounded hover:bg-gray-400 w-full"
            >
              Cancelar
            </button>
          </div>
        </>
      )}
      {visibleForm === "deletar" && (
        <>
          <h2 className="text-2xl font-bold mb-6 text-center text-red-700">
            Deletar Conta
          </h2>
          <div className="flex flex-col items-center gap-4">
            <input
              type="password"
              value={deletePassword}
              onChange={(e) => setDeletePassword(e.target.value)}
              placeholder="Digite sua senha"
              className="border border-gray-300 rounded px-4 py-2 w-full focus:ring-2 focus:ring-red-500"
            />
            <button
              onClick={handleDeleteAccount}
              className="bg-red-700 text-white font-bold px-6 py-2 rounded hover:bg-red-800 w-full"
            >
              Confirmar
            </button>
            <button
              onClick={() => setVisibleForm("")}
              className="bg-gray-300 text-gray-800 font-bold px-6 py-2 rounded hover:bg-gray-400 w-full"
            >
              Cancelar
            </button>
          </div>
        </>
      )}
    </div>
  );
};

export default EditForm;