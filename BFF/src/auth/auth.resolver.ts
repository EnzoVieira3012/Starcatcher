import { Resolver, Query, Mutation, Args, Context } from '@nestjs/graphql';
import { AuthService } from './auth.service';
import {
  LoginInput,
  RegisterInput,
  ChangePasswordInput,
  ChangeEmailInput,
  ChangeNameInput,
  DeleteAccountInput,
} from './dto/auth.inputs';
import { AuthResponse } from './dto/auth.responses';
import { UserType } from './dto/user.response';

@Resolver()
export class AuthResolver {
  constructor(private readonly authService: AuthService) {}

  @Query(() => String)
  healthCheck(): string {
    return 'Service is up!';
  }

  @Mutation(() => AuthResponse)
  async login(
    @Args('loginInput') loginInput: LoginInput,
  ): Promise<AuthResponse> {
    return this.authService.login(loginInput);
  }

  @Mutation(() => AuthResponse)
  async register(
    @Args('registerInput') registerInput: RegisterInput,
  ): Promise<AuthResponse> {
    return this.authService.register(registerInput);
  }

  @Mutation(() => String)
  async changePassword(
    @Args('changePasswordInput') changePasswordInput: ChangePasswordInput,
  ): Promise<string> {
    const result = await this.authService.changePassword(changePasswordInput);
    return result.message;
  }

  @Mutation(() => String)
  async changeEmail(
    @Args('changeEmailInput') changeEmailInput: ChangeEmailInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.authService.changeEmail(changeEmailInput, token);
    return result.message;
  }

  @Mutation(() => String)
  async changeName(
    @Args('changeNameInput') changeNameInput: ChangeNameInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.authService.changeName(changeNameInput, token);
    return result.message;
  }

  @Mutation(() => String)
  async deleteAccount(
    @Args('deleteAccountInput') deleteAccountInput: DeleteAccountInput,
    @Context() context: any,
  ): Promise<string> {
    const token = this.extractToken(context);
    const result = await this.authService.deleteAccount(
      deleteAccountInput,
      token,
    );
    return result.message;
  }

  @Query(() => UserType, { name: 'me' })
  async me(@Context() context: any): Promise<UserType> {
    const token = this.extractToken(context);
    return this.authService.getUserByToken(token);
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
