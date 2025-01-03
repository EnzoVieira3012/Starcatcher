import React, { useState } from 'react';
import { useMutation, gql } from '@apollo/client';
import { useNavigate } from 'react-router-dom';

// Defina a mutation para criar um consórcio
const CREATE_CONSORTIUM = gql`
  mutation CreateConsortium($input: CreateConsortiumInput!) {
    createConsortium(createConsortiumInput: $input)
  }
`;

const CreateConsortiumPage = () => {
  const [name, setName] = useState('');
  const [description, setDescription] = useState('');
  const [assetValue, setAssetValue] = useState('');
  const [numberOfInstallments, setNumberOfInstallments] = useState('');
  const [administrationFee, setAdministrationFee] = useState('');
  const [numberOfQuotas, setNumberOfQuotas] = useState('');
  const [createConsortium] = useMutation(CREATE_CONSORTIUM);
  const navigate = useNavigate();

  const handleCreateConsortium = async (e) => {
    e.preventDefault();

    try {
      await createConsortium({
        variables: {
          input: {
            name,
            description,
            assetValue: parseFloat(assetValue),
            numberOfInstallments: parseInt(numberOfInstallments),
            administrationFee: parseFloat(administrationFee),
            numberOfQuotas: parseInt(numberOfQuotas),
          },
        },
      });
      console.log('Consórcio criado com sucesso');
      navigate('/'); // Redirecionar para a página inicial após a criação
    } catch (error) {
      console.error('Erro ao criar consórcio:', error);
    }
  };

  return (
    <div className="flex flex-col items-center justify-center min-h-screen bg-gray-100">
      <h1 className="text-2xl font-bold mb-6">Criar Novo Consórcio</h1>
      <form onSubmit={handleCreateConsortium} className="bg-white shadow-md rounded px-8 pt-6 pb-8 mb-4 w-full max-w-md">
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="name">
            Nome do Consórcio
          </label>
          <input
            id="name"
            type="text"
            value={name}
            onChange={(e) => setName(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Nome do Consórcio"
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="description">
            Descrição
          </label>
          <textarea
            id="description"
            value={description}
            onChange={(e) => setDescription(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Descrição do Consórcio"
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="assetValue">
            Valor do Bem
          </label>
          <input
            id="assetValue"
            type="number"
            value={assetValue}
            onChange={(e) => setAssetValue(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Valor do Bem"
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="numberOfInstallments">
            Número de Parcelas
          </label>
          <input
            id="numberOfInstallments"
            type="number"
            value={numberOfInstallments}
            onChange={(e) => setNumberOfInstallments(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Número de Parcelas"
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="administrationFee">
            Taxa de Administração
          </label>
          <input
            id="administrationFee"
            type="number"
            step="0.01"
            value={administrationFee}
            onChange={(e) => setAdministrationFee(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Taxa de Administração (%)"
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 text-sm font-bold mb-2" htmlFor="numberOfQuotas">
            Número de Cotas
          </label>
          <input
            id="numberOfQuotas"
            type="number"
            value={numberOfQuotas}
            onChange={(e) => setNumberOfQuotas(e.target.value)}
            className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            placeholder="Número de Cotas"
          />
        </div>
        <div className="flex items-center justify-between">
          <button
            type="submit"
            className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
          >
            Criar Consórcio
          </button>
        </div>
      </form>
    </div>
  );
};

export default CreateConsortiumPage;