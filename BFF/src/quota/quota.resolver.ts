import { Resolver, Query, Mutation, Args, Context } from '@nestjs/graphql';
import { QuotaService } from './quota.service';
import { QuotaResponse, InstallmentResponse } from './dto/quota.responses';
import {
  QuotaInput,
  InstallmentInput,
  PayInstallmentInput,
  LinkQuotaToClientInput,
} from './dto/quota.inputs';

@Resolver()
export class QuotaResolver {
  constructor(private readonly quotaService: QuotaService) {}

  @Query(() => [QuotaResponse])
  async listQuotas(
    @Args('input') input: QuotaInput,
    @Context() context: any,
  ): Promise<QuotaResponse[]> {
    const token = this.extractToken(context);
    return this.quotaService.getQuotas(input.consortiumId, token);
  }

  @Query(() => [InstallmentResponse])
  async listInstallments(
    @Args('input') input: InstallmentInput,
    @Context() context: any,
  ): Promise<InstallmentResponse[]> {
    const token = this.extractToken(context);
    return this.quotaService.getInstallments(input.quotaId, token);
  }

  @Query(() => [QuotaResponse])
  async getQuotasByClientId(
    @Args('clientId') clientId: number,
    @Context() context: any,
  ): Promise<QuotaResponse[]> {
    const token = this.extractToken(context);
    return this.quotaService.getQuotasByClientId(clientId, token);
  }

  @Mutation(() => Boolean)
  async payInstallment(
    @Args('input') input: PayInstallmentInput,
    @Context() context: any,
  ): Promise<boolean> {
    const token = this.extractToken(context);
    return this.quotaService.payInstallment(input.installmentId, token);
  }

  @Mutation(() => String)
  async linkQuotaToClient(
    @Args('input') input: LinkQuotaToClientInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    await this.quotaService.linkQuotaToClient(
      input.quotaId,
      input.clientId,
      token,
    );
    return 'Quota linked to client successfully.';
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
