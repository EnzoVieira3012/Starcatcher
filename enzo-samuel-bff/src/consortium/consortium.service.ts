import { Injectable } from '@nestjs/common';
import axios from 'axios';
import {
  CreateConsortiumInput,
  UpdateConsortiumInput,
} from './dto/consortium.inputs';
import { ConsortiumResponse } from './dto/consortium.responses';

@Injectable()
export class ConsortiumService {
  private readonly apiUrl = `${process.env.API_URL}/api/consortium`;

  async createConsortium(
    createConsortiumInput: CreateConsortiumInput,
    token: string,
  ): Promise<{ message: string }> {
    try {
      console.log('Iniciando criação de consórcio');
      console.log('Token JWT usado:', token);
      console.log('Dados de entrada para criação:', createConsortiumInput);

      const response = await axios.post(this.apiUrl, createConsortiumInput, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      console.log('Resposta da API na criação:', response.data);

      return { message: 'Consórcio criado com sucesso' };
    } catch (error) {
      console.error('Erro ao criar consórcio:', {
        message: error.message,
        data: error.response?.data,
        status: error.response?.status,
      });
      throw new Error('Falha ao criar consórcio: ' + error.message);
    }
  }

  async updateConsortium(
    updateConsortiumInput: UpdateConsortiumInput,
    token: string,
  ): Promise<{ message: string }> {
    try {
      console.log('Iniciando atualização de consórcio');
      console.log('Token JWT usado:', token);
      console.log('Dados de entrada para atualização:', updateConsortiumInput);

      const response = await axios.put(
        `${this.apiUrl}/${updateConsortiumInput.id}`,
        updateConsortiumInput,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );

      console.log('Resposta da API na atualização:', response.data);

      return { message: 'Consórcio atualizado com sucesso' };
    } catch (error) {
      console.error('Erro ao atualizar consórcio:', {
        message: error.message,
        data: error.response?.data,
        status: error.response?.status,
      });
      throw new Error('Falha ao atualizar consórcio: ' + error.message);
    }
  }

  async deleteConsortium(
    id: number,
    token: string,
  ): Promise<{ message: string }> {
    try {
      console.log('Iniciando deleção de consórcio');
      console.log('Token JWT usado:', token);
      console.log('ID do consórcio para deleção:', id);

      await axios.delete(`${this.apiUrl}/${id}`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      console.log('Deleção de consórcio bem-sucedida, ID:', id);
      return { message: 'Consórcio deletado com sucesso' };
    } catch (error) {
      console.error('Erro ao deletar consórcio:', {
        message: error.message,
        data: error.response?.data,
        status: error.response?.status,
      });
      throw new Error('Falha ao deletar consórcio: ' + error.message);
    }
  }

  async getUserConsortia(token: string): Promise<ConsortiumResponse[]> {
    try {
      console.log('Iniciando listagem de consórcios do usuário');
      console.log('Token JWT usado:', token);

      const response = await axios.get<ConsortiumResponse[]>(this.apiUrl, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      console.log('Resposta bruta da API:', response.data);

      response.data.forEach((consortium) => {
        console.log(
          'Consortium ID:',
          consortium.id,
          'Quotas Value:',
          consortium.quotaValue,
        );
      });

      return response.data;
    } catch (error) {
      console.error('Erro ao listar consórcios:', {
        message: error.message,
        data: error.response?.data,
        status: error.response?.status,
      });
      throw new Error('Falha ao listar consórcios: ' + error.message);
    }
  }
}
