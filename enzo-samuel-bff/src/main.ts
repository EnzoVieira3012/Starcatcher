import { NestFactory } from '@nestjs/core';
import { AppModule } from './app.module';

async function bootstrap() {
  const app = await NestFactory.create(AppModule);

  app.enableCors({
    origin: [
      'http://localhost:4000',
      'http://localhost:4001',
      'http://localhost:4002',
      'http://localhost:4003',
      'http://localhost:4004',
      'http://localhost:4005',
    ],
    methods: 'GET,HEAD,PUT,PATCH,POST,DELETE',
    credentials: true, // Se precisar suportar cookies com CORS
  });

  await app.listen(process.env.PORT ?? 3000);
}

bootstrap();