import { ObjectType, Field } from '@nestjs/graphql';

@ObjectType()
export class QuotaResponse {
  @Field()
  id: number;

  @Field()
  consortiumId: number;

  @Field()
  status: string;
}

@ObjectType()
export class InstallmentResponse {
  @Field()
  id: number;

  @Field()
  value: number;

  @Field()
  status: string;
}
