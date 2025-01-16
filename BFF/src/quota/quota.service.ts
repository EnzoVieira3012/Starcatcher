import { Injectable, Logger } from '@nestjs/common';
import axios from 'axios';
import { QuotaResponse, InstallmentResponse } from './dto/quota.responses';

@Injectable()
export class QuotaService {
  private readonly apiUrl = `${process.env.API_URL}/api`;
  private readonly logger = new Logger(QuotaService.name);

  async getQuotasByClientId(
    clientId: number,
    token: string,
  ): Promise<QuotaResponse[]> {
    this.logger.log(
      `Iniciando método getQuotasByClientId para clientId: ${clientId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);

    try {
      const url = `${this.apiUrl}/quota/client/${clientId}`;
      this.logger.log(`Fazendo requisição para URL: ${url}`);

      const response = await axios.get<QuotaResponse[]>(url, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      this.logger.log('Cotas do cliente obtidas com sucesso');
      this.logger.debug(`Dados recebidos: ${JSON.stringify(response.data)}`);
      return response.data;
    } catch (error) {
      this.logger.error('Erro ao buscar cotas do cliente', error.message);
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error('Falha ao buscar cotas do cliente: ' + error.message);
    } finally {
      this.logger.log('Finalizando método getQuotasByClientId');
    }
  }

  async getQuotas(
    consortiumId: number,
    token: string,
  ): Promise<QuotaResponse[]> {
    this.logger.log(
      `Iniciando método getQuotas para consortiumId: ${consortiumId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);

    try {
      this.logger.log('Fazendo requisição para obter cotas');

      const response = await axios.get<QuotaResponse[]>(
        `${this.apiUrl}/consortium/${consortiumId}/quotas`,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );

      this.logger.log('Cotas obtidas com sucesso');
      this.logger.debug(`Dados recebidos: ${JSON.stringify(response.data)}`);
      return response.data;
    } catch (error) {
      this.logger.error('Erro ao buscar cotas', error.message);
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error('Failed to fetch quotas: ' + error.message);
    } finally {
      this.logger.log('Finalizando método getQuotas');
    }
  }

  async getInstallments(
    quotaId: number,
    token: string,
  ): Promise<InstallmentResponse[]> {
    this.logger.log(
      `Iniciando método getInstallments para quotaId: ${quotaId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);

    try {
      this.logger.log('Fazendo requisição para obter parcelas');

      const response = await axios.get<InstallmentResponse[]>(
        `${this.apiUrl}/Quota/${quotaId}/installments`,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );

      this.logger.log('Parcelas obtidas com sucesso');
      this.logger.debug(`Dados recebidos: ${JSON.stringify(response.data)}`);
      return response.data;
    } catch (error) {
      this.logger.error('Erro ao buscar parcelas', error.message);
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error('Failed to fetch installments: ' + error.message);
    } finally {
      this.logger.log('Finalizando método getInstallments');
    }
  }

  async payInstallment(installmentId: number, token: string): Promise<boolean> {
    this.logger.log(
      `Iniciando método payInstallment para installmentId: ${installmentId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);

    try {
      this.logger.log('Fazendo requisição para pagar parcela');

      await axios.put(
        `${this.apiUrl}/Quota/installments/${installmentId}/pay`,
        {},
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );

      this.logger.log('Pagamento efetuado com sucesso para a parcela');
      return true;
    } catch (error) {
      this.logger.error('Erro ao pagar parcela', error.message);
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error('Failed to pay installment: ' + error.message);
    } finally {
      this.logger.log('Finalizando método payInstallment');
    }
  }

  async linkQuotaToClient(
    quotaId: number,
    clientId: number,
    token: string,
  ): Promise<string> {
    this.logger.log(
      `Iniciando método linkQuotaToClient para quotaId: ${quotaId}, clientId: ${clientId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);

    try {
      this.logger.log('Fazendo requisição para vincular cota ao cliente');

      await axios.post(
        `${this.apiUrl}/quota/${quotaId}/link-to-client/${clientId}`,
        {},
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );

      this.logger.log('Cota vinculada com sucesso ao cliente');
      return 'Cota vinculada com sucesso ao cliente';
    } catch (error) {
      this.logger.error('Erro ao vincular cota', error.message);
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error('Falha ao vincular cota: ' + error.message);
    } finally {
      this.logger.log('Finalizando método linkQuotaToClient');
    }
  }

  async createQuotaForClient(
    clientId: number,
    token: string,
    postData: any,
  ): Promise<QuotaResponse[]> {
    this.logger.log(
      `Iniciando método createQuotaForClient para clientId: ${clientId}`,
    );
    this.logger.debug(`Token JWT recebido: ${token}`);
    this.logger.debug(`Dados enviados: ${JSON.stringify(postData)}`);

    try {
      const url = `${this.apiUrl}/client/${clientId}/quotas`;
      this.logger.log(`Fazendo requisição POST para URL: ${url}`);

      const response = await axios.post<QuotaResponse[]>(url, postData, {
        headers: {
          Authorization: `Bearer ${token}`,
        },
      });

      this.logger.log('Nova cota criada com sucesso');
      this.logger.debug(`Dados recebidos: ${JSON.stringify(response.data)}`);
      return response.data;
    } catch (error) {
      this.logger.error(
        'Erro ao criar nova cota para o cliente',
        error.message,
      );
      if (error.response) {
        this.logger.error('Detalhes do erro:', {
          data: error.response.data,
          status: error.response.status,
        });
      }
      throw new Error(
        'Falha ao criar nova cota para o cliente: ' + error.message,
      );
    } finally {
      this.logger.log('Finalizando método createQuotaForClient');
    }
  }
}
