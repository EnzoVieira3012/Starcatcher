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
    return this.consortiumService.getUserConsortia(token);
  }

  @Mutation(() => String)
  async createConsortium(
    @Args('createConsortiumInput') createConsortiumInput: CreateConsortiumInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.consortiumService.createConsortium(
      createConsortiumInput,
      token,
    );
    return result.message;
  }

  @Mutation(() => String)
  async updateConsortium(
    @Args('updateConsortiumInput') updateConsortiumInput: UpdateConsortiumInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.consortiumService.updateConsortium(
      updateConsortiumInput,
      token,
    );
    return result.message;
  }

  @Mutation(() => String)
  async deleteConsortium(
    @Args('id', { type: () => Int }) id: number,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.consortiumService.deleteConsortium(id, token);
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
