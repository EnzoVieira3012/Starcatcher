import { ObjectType, Field, Int } from '@nestjs/graphql';

@ObjectType()
export class ClientResponse {
  @Field(() => Int)
  id: number;

  @Field()
  name: string;

  @Field({ nullable: true })
  email?: string;

  @Field({ nullable: true })
  phone?: string;
}
