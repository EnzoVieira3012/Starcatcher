import { ObjectType, Field, Int, Float } from '@nestjs/graphql';

@ObjectType()
export class ConsortiumResponse {
  @Field(() => Int, { nullable: true })
  id: number;

  @Field({ nullable: true })
  name: string;

  @Field({ nullable: true })
  description: string;

  @Field(() => Int, { nullable: true })
  assetValue: number;

  @Field(() => Int, { nullable: true })
  numberOfInstallments: number;

  @Field(() => Int, { nullable: true })
  administrationFee: number;

  @Field(() => Int, { nullable: true })
  numberOfQuotas: number;

  @Field(() => Float, { nullable: true })
  quotaValue: number;
}
