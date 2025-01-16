import { Resolver, Query, Mutation, Args, Int, Context } from '@nestjs/graphql';
import { ConsortiumService } from './consortium.service';
import {
  CreateConsortiumInput,
  UpdateConsortiumInput,
} from './dto/consortium.inputs';
import { ConsortiumResponse } from './dto/consortium.responses';

@Resolver()
export class ConsortiumResolver {
  constructor(private readonly consortiumService: ConsortiumService) {}

  @Query(() => [ConsortiumResponse])
  async getUserConsortia(
    @Context() context: any,
  ): Promise<ConsortiumResponse[]> {
    const token = this.extractToken(context);
    try {
      console.log('Buscando consórcios do usuário');
      const consortia = await this.consortiumService.getUserConsortia(token);

      // Log dos dados recebidos da API REST
      console.log('Consórcios retornados pela API REST:', consortia);

      return consortia;
    } catch (error) {
      console.error('Erro ao listar consórcios no Resolver:', error.message);
      throw new Error('Falha ao listar consórcios: ' + error.message);
    }
  }

  @Mutation(() => String)
  async createConsortium(
    @Args('createConsortiumInput') createConsortiumInput: CreateConsortiumInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    try {
      const result = await this.consortiumService.createConsortium(
        createConsortiumInput,
        token,
      );
      return result.message;
    } catch (error) {
      console.error('Erro ao criar consórcio no Resolver:', error.message);
      throw new Error('Falha ao criar consórcio: ' + error.message);
    }
  }

  @Mutation(() => String)
  async updateConsortium(
    @Args('updateConsortiumInput') updateConsortiumInput: UpdateConsortiumInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    try {
      const result = await this.consortiumService.updateConsortium(
        updateConsortiumInput,
        token,
      );
      return result.message;
    } catch (error) {
      console.error('Erro ao atualizar consórcio no Resolver:', error.message);
      throw new Error('Falha ao atualizar consórcio: ' + error.message);
    }
  }

  @Mutation(() => String)
  async deleteConsortium(
    @Args('id', { type: () => Int }) id: number,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    try {
      const result = await this.consortiumService.deleteConsortium(id, token);
      return result.message;
    } catch (error) {
      console.error('Erro ao deletar consórcio no Resolver:', error.message);
      throw new Error('Falha ao deletar consórcio: ' + error.message);
    }
  }

  private extractToken(context: any): string {
    const authHeader = context.req.headers.authorization;
    if (!authHeader) {
      console.error('Cabeçalho Authorization não encontrado.');
      throw new Error('Token JWT não fornecido');
    }
    const token = authHeader.split(' ')[1];
    if (!token) {
      console.error('Token JWT malformado no cabeçalho Authorization.');
      throw new Error('Token JWT malformado');
    }
    console.log('Token JWT extraído com sucesso:', token);
    return token;
  }
}
