import { InputType, Field } from '@nestjs/graphql';

@InputType()
export class QuotaInput {
  @Field()
  consortiumId: number;
}

@InputType()
export class InstallmentInput {
  @Field()
  quotaId: number;
}

@InputType()
export class PayInstallmentInput {
  @Field()
  installmentId: number;
}

@InputType()
export class LinkQuotaToClientInput {
  @Field()
  quotaId: number;

  @Field()
  clientId: number;
}
