import { InputType, Field, Int } from '@nestjs/graphql';

@InputType()
export class CreateConsortiumInput {
  @Field()
  name: string;

  @Field()
  description: string;

  @Field(() => Int)
  assetValue: number;

  @Field(() => Int)
  numberOfInstallments: number;

  @Field(() => Int)
  administrationFee: number;

  @Field(() => Int)
  numberOfQuotas: number;

  @Field(() => Int, { nullable: true })
  quotasValue: number;
}

@InputType()
export class UpdateConsortiumInput {
  @Field(() => Int)
  id: number;

  @Field({ nullable: true })
  name?: string;

  @Field({ nullable: true })
  description?: string;

  @Field(() => Int, { nullable: true })
  assetValue?: number;

  @Field(() => Int, { nullable: true })
  numberOfInstallments?: number;

  @Field(() => Int, { nullable: true })
  administrationFee?: number;

  @Field(() => Int, { nullable: true })
  numberOfQuotas?: number;

  @Field(() => Int, { nullable: true })
  quotasValue?: number;
}
