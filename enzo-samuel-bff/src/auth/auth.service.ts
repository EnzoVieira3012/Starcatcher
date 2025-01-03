import { Injectable, Logger } from '@nestjs/common';
import { HttpService } from '@nestjs/axios';
import { JwtService } from '@nestjs/jwt';
import { AxiosResponse } from 'axios';
import { lastValueFrom } from 'rxjs';
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
import * as dotenv from 'dotenv';

dotenv.config();

@Injectable()
export class AuthService {
  private readonly logger = new Logger(AuthService.name);

  constructor(
    private readonly jwtService: JwtService,
    private readonly httpService: HttpService,
  ) {}

  async getUserByToken(token: string): Promise<UserType> {
    try {
      const observable = this.httpService.get<UserType>(
        `${process.env.API_URL}/api/auth/me`,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );
      const response: AxiosResponse<UserType> = await lastValueFrom(observable);
      return response.data;
    } catch (error) {
      this.logger.error('Failed to get user by token', error.stack);
      throw new Error('Failed to get user by token: ' + error.message);
    }
  }

  async login(loginInput: LoginInput): Promise<AuthResponse> {
    this.logger.log(`Attempting login for user: ${loginInput.email}`);
    try {
      const observable = this.httpService.post<AuthResponse>(
        `${process.env.API_URL}/api/auth/login`,
        loginInput,
      );
      const response = await lastValueFrom(observable);
      this.logger.log(`Login successful for user: ${loginInput.email}`);
      return response.data;
    } catch (error) {
      this.logger.error(
        `Failed to login for user: ${loginInput.email}`,
        error.stack,
      );
      throw new Error('Failed to login: ' + error.message);
    }
  }

  async register(registerInput: RegisterInput): Promise<AuthResponse> {
    this.logger.log(`Attempting to register user: ${registerInput.email}`);
    try {
      const observable = this.httpService.post<AuthResponse>(
        `${process.env.API_URL}/api/auth/register`,
        registerInput,
      );
      const response = await lastValueFrom(observable);
      this.logger.log(
        `Registration successful for user: ${registerInput.email}`,
      );
      return response.data;
    } catch (error) {
      this.logger.error(
        `Failed to register user: ${registerInput.email}`,
        error.stack,
      );
      throw new Error('Failed to register: ' + error.message);
    }
  }

  async changePassword(
    changePasswordInput: ChangePasswordInput,
  ): Promise<{ message: string }> {
    this.logger.log(
      `Attempting to change password for user: ${changePasswordInput.email}`,
    );
    try {
      const observable = this.httpService.post(
        `${process.env.API_URL}/api/auth/change-password`,
        changePasswordInput,
      );
      await lastValueFrom(observable);
      this.logger.log(
        `Password change successful for user: ${changePasswordInput.email}`,
      );
      return { message: 'Password changed successfully' };
    } catch (error) {
      this.logger.error(
        `Failed to change password for user: ${changePasswordInput.email}`,
        error.stack,
      );
      throw new Error('Failed to change password: ' + error.message);
    }
  }

  async changeEmail(
    changeEmailInput: ChangeEmailInput,
    token: string,
  ): Promise<{ message: string }> {
    this.logger.log('Attempting to change email');
    try {
      const observable = this.httpService.put(
        `${process.env.API_URL}/api/auth/update-email`,
        changeEmailInput,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );
      await lastValueFrom(observable);
      this.logger.log('Email update successful');
      return { message: 'Email updated successfully' };
    } catch (error) {
      this.logger.error('Failed to update email', error.stack);
      throw new Error('Failed to update email: ' + error.message);
    }
  }

  async changeName(
    changeNameInput: ChangeNameInput,
    token: string,
  ): Promise<{ message: string }> {
    this.logger.log('Attempting to change name');
    try {
      const observable = this.httpService.put(
        `${process.env.API_URL}/api/auth/update-name`,
        changeNameInput,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
        },
      );
      await lastValueFrom(observable);
      this.logger.log('Name update successful');
      return { message: 'Name updated successfully' };
    } catch (error) {
      this.logger.error('Failed to update name', error.stack);
      throw new Error('Failed to update name: ' + error.message);
    }
  }

  async deleteAccount(
    deleteAccountInput: DeleteAccountInput,
    token: string,
  ): Promise<{ message: string }> {
    this.logger.log('Attempting to delete account');
    try {
      const observable = this.httpService.delete(
        `${process.env.API_URL}/api/auth/delete-account`,
        {
          headers: {
            Authorization: `Bearer ${token}`,
          },
          data: deleteAccountInput,
        },
      );
      await lastValueFrom(observable);
      this.logger.log('Account deletion successful');
      return { message: 'Account deleted successfully' };
    } catch (error) {
      this.logger.error('Failed to delete account', error.stack);
      throw new Error('Failed to delete account: ' + error.message);
    }
  }
}
