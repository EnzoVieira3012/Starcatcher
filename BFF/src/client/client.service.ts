import { Injectable } from '@nestjs/common';
import axios from 'axios';
import { CreateClientInput, UpdateClientInput } from './dto/client.inputs';
import { ClientResponse } from './dto/client.responses';

@Injectable()
export class ClientService {
  private readonly apiUrl = `${process.env.API_URL}/api/client`;

  async createClient(
    createClientInput: CreateClientInput,
    token: string,
  ): Promise<{ message: string }> {
    try {
      const response = await axios.post(this.apiUrl, createClientInput, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      console.log(response.data); // Use a resposta ou faça log
      return { message: 'Cliente criado com sucesso' };
    } catch (error) {
      throw new Error('Falha ao criar cliente: ' + error.message);
    }
  }

  async getClients(token: string): Promise<ClientResponse[]> {
    try {
      const response = await axios.get<ClientResponse[]>(this.apiUrl, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      return response.data;
    } catch (error) {
      throw new Error('Falha ao listar clientes: ' + error.message);
    }
  }

  async updateClient(
    updateClientInput: UpdateClientInput,
    token: string,
  ): Promise<{ message: string }> {
    try {
      const response = await axios.put(
        `${this.apiUrl}/${updateClientInput.id}`,
        updateClientInput,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );
      console.log(response.data);
      return { message: 'Cliente atualizado com sucesso' };
    } catch (error) {
      throw new Error('Falha ao atualizar cliente: ' + error.message);
    }
  }

  async deleteClient(id: number, token: string): Promise<{ message: string }> {
    try {
      await axios.delete(`${this.apiUrl}/${id}`, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });
      return { message: 'Cliente deletado com sucesso' };
    } catch (error) {
      throw new Error('Falha ao deletar cliente: ' + error.message);
    }
  }
}
