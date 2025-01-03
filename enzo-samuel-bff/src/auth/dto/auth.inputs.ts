import { InputType, Field } from '@nestjs/graphql';

@InputType()
export class LoginInput {
  @Field()
  email: string;

  @Field()
  password: string;
}

@InputType()
export class RegisterInput {
  @Field()
  name: string;

  @Field()
  email: string;

  @Field()
  password: string;
}

@InputType()
export class ChangePasswordInput {
  @Field()
  email: string;

  @Field()
  newPassword: string;
}

@InputType()
export class ChangeEmailInput {
  @Field()
  newEmail: string;
}

@InputType()
export class ChangeNameInput {
  @Field()
  newName: string;
}

@InputType()
export class DeleteAccountInput {
  @Field()
  password: string;
}
