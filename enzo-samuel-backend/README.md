Documentação do Backend Starcatcher

Introdução

O Starcatcher é um backend desenvolvido em C# utilizando o ASP.NET Core. Ele fornece uma API RESTful para gerenciar consórcios, usuários, cotas e carteiras digitais.

Estrutura do Projeto

- Starcatcher.Api: Contém a aplicação principal da API.
- Starcatcher.Api.Tests: Contém os testes automatizados para a API.

Configuração e Instalação

Pré-requisitos

- .NET SDK 8.0 ou superior
- SQL Server ou Docker para banco de dados
- Git para controle de versão

Instalação

1. Clone o repositório:
   git clone https://bitbucket.org/newm-dev1/enzo-samuel-bff/src/develop/
   cd Starcatcher

2. Configure o banco de dados no arquivo appsettings.json:
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=127.0.0.1;Database=StarcatcherDB;User=SA;Password=Senha123;Encrypt=False;TrustServerCertificate=True"
     }
   }

3. Execute as migrações do banco de dados:
   dotnet ef database update

4. Execute a aplicação:
   dotnet run

Estrutura da API

Endpoints Principais

Usuário

- POST /User: Cria um novo usuário.
- GET /User: Retorna todos os usuários.
- GET /User/{id}: Retorna um usuário pelo ID.
- PUT /User: Atualiza um usuário autenticado.
- DELETE /User: Deleta o usuário autenticado.
- POST /User/login: Autentica um usuário e retorna um token.

Consórcio

- GET /Consortium: Retorna todos os consórcios.
- GET /Consortium/{id}: Retorna um consórcio pelo ID.
- POST /Consortium: Cria um novo consórcio.

Cotas

- GET /Quota: Retorna todas as cotas.
- GET /Quota/consortium/{consortiumId}: Retorna cotas por ID do consórcio.
- GET /Quota/{id}: Retorna uma cota pelo ID.
- POST /Quota: Cria uma nova cota.
- POST /Quota/buy/{id}: Compra uma cota.
- PUT /Quota: Atualiza uma cota.
- DELETE /Quota/{id}: Deleta uma cota.

Carteira

- GET /Wallet: Retorna todas as carteiras.
- GET /Wallet/{id}: Retorna uma carteira pelo ID.
- POST /Wallet/credit: Credita um valor na carteira do usuário autenticado.

Segurança

- Autenticação JWT é utilizada para proteger endpoints. Tokens são necessários para acessar a maioria dos endpoints, exceto para login e criação de usuários.

Testes

- Testes são implementados no projeto Starcatcher.Api.Tests.
- Utilize o seguinte comando para rodar os testes:
  dotnet test

Contribuição

1. Faça um fork do projeto.
2. Crie uma branch para sua feature (git checkout -b feature/nova-feature).
3. Commit suas mudanças (git commit -m 'Adiciona nova feature').
4. Suba a branch (git push origin feature/nova-feature).
5. Abra um Pull Request.

Contato

Para dúvidas ou suporte, entre em contato com enzo.vieira@newm.com.br