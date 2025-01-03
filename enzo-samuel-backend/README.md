**Starcatcher Backend**

Este é o backend da aplicação Starcatcher, desenvolvido utilizando ASP.NET Core com uma abordagem de arquitetura limpa.

**Funcionalidades**

- Autenticação e autorização de usuários utilizando tokens JWT.
- Operações CRUD para clientes e consórcios.
- Gerenciamento de cotas e parcelas.
- Testes unitários integrados para as camadas de serviço e controle.

**Tecnologias Utilizadas**

- ASP.NET Core 8.0
- Entity Framework Core 9.0
- Autenticação JWT
- Docker para SQL Server
- Moq e xUnit para testes

**Endpoints da API**

**Autenticação (Auth)**

- GET /api/Auth/me: Retorna as informações do usuário autenticado.
- POST /api/Auth/register: Registra um novo usuário. Requer um payload JSON com Name, Email e Password.
- POST /api/Auth/login: Autentica um usuário existente. Requer um payload JSON com Email e Password.
- POST /api/Auth/change-password: Altera a senha do usuário. Requer um payload JSON com Email e NewPassword.
- PUT /api/Auth/update-email: Atualiza o email do usuário autenticado. Requer um payload JSON com NewEmail.
- PUT /api/Auth/update-name: Atualiza o nome do usuário autenticado. Requer um payload JSON com NewName.
- DELETE /api/Auth/delete-account: Deleta a conta do usuário autenticado. Requer um payload JSON com Password.

**Clientes (Client)**

- POST /api/Client: Cria um novo cliente associado ao usuário autenticado. Requer um payload JSON com informações do cliente.
- GET /api/Client: Retorna todos os clientes associados ao usuário autenticado.
- PUT /api/Client/{id}: Atualiza as informações de um cliente específico. Requer um payload JSON com as atualizações desejadas.
- DELETE /api/Client/{id}: Deleta um cliente específico.

**Consórcios (Consortium)**

- POST /api/Consortium: Cria um novo consórcio associado ao usuário autenticado. Requer um payload JSON com informações do consórcio.
- GET /api/Consortium: Retorna todos os consórcios associados ao usuário autenticado.
- PUT /api/Consortium/{id}: Atualiza as informações de um consórcio específico. Requer um payload JSON com as atualizações desejadas.
- DELETE /api/Consortium/{id}: Deleta um consórcio específico.
- GET /api/Consortium/{consortiumId}/quotas: Retorna todas as cotas associadas a um consórcio específico.

**Cotas (Quota)**

- GET /api/Quota/{quotaId}/installments: Retorna todas as parcelas associadas a uma cota específica.
- PUT /api/Quota/installments/{installmentId}/pay: Marca uma parcela específica como paga.
- POST /api/Quota/{quotaId}/link-to-client/{clientId}: Associa uma cota a um cliente específico.
- GET /api/Quota/client/{clientId}: Retorna todas as cotas associadas a um cliente específico.

**Começando**

**Pré-requisitos**

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

**Configuração**

1. Clone o repositório:

git clone https://github.com/EnzoVieira3012/Starcatcher.git
cd enzo-samuel-backend

2. Configure a string de conexão do banco de dados no appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=YourDatabaseName;User Id=sa;Password=Your_password123;TrustServerCertificate=True;"
}

3. Inicie o SQL Server usando Docker:

docker-compose up -d

4. Execute a aplicação:

cd API
dotnet run

5. Acesse o Swagger UI para testar a API:

http://localhost:5000/swagger

**Executando Testes**

Navegue até o diretório Tests e execute os testes usando:

cd Tests
dotnet test

**Contribuindo**

1. Faça o fork do repositório.
2. Crie uma nova branch:

git checkout -b feature/nome-da-sua-funcionalidade

3. Faça commit das suas alterações:

git commit -am 'Adicionei uma funcionalidade'

4. Faça push para a branch:

git push origin feature/nome-da-sua-funcionalidade

5. Crie um novo Pull Request.

**Licença**

Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.
