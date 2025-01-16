import { Resolver, Query, Mutation, Args, Context } from '@nestjs/graphql';
import { ClientService } from './client.service';
import { CreateClientInput, UpdateClientInput } from './dto/client.inputs';
import { ClientResponse } from './dto/client.responses';

@Resolver()
export class ClientResolver {
  constructor(private readonly clientService: ClientService) {}

  @Query(() => [ClientResponse])
  async listClients(@Context() context: any): Promise<ClientResponse[]> {
    const token = this.extractToken(context);
    return this.clientService.getClients(token);
  }

  @Mutation(() => String)
  async createClient(
    @Args('createClientInput') createClientInput: CreateClientInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.clientService.createClient(
      createClientInput,
      token,
    );
    return result.message;
  }

  @Mutation(() => String)
  async updateClient(
    @Args('updateClientInput') updateClientInput: UpdateClientInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.clientService.updateClient(
      updateClientInput,
      token,
    );
    return result.message;
  }

  @Mutation(() => String)
  async deleteClient(
    @Args('id') id: number,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.clientService.deleteClient(id, token);
    return result.message;
  }

  private extractToken(context: any): string {
    const authHeader = context.req.headers.authorization;
    if (!authHeader) {
      throw new Error('Token JWT não fornecido');
    }
    const token = authHeader.split(' ')[1];
    if (!token) {
      throw new Error('Token JWT malformado');
    }
    return token;
  }
}
