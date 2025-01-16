**Starcatcher BFF**

Este projeto é uma aplicação desenvolvida utilizando o framework NestJS. Ele fornece uma API GraphQL para gerenciar autenticação, clientes, consórcios, cotas e parcelas.

**Funcionalidades**
- Autenticação e autorização de usuários utilizando tokens JWT.
- Operações CRUD para clientes e consórcios.
- Gerenciamento de cotas e parcelas associadas.

**Tecnologias Utilizadas**
- NestJS
- GraphQL com Apollo Server
- Axios para requisições HTTP
- JWT para autenticação
- TypeScript

**Configuração**

1. Clone o repositório:
   git clone https://github.com/EnzoVieira3012/Starcatcher.git
   cd enzo-samuel-bff

2. Instale as dependências:
   npm install

3. Configure as variáveis de ambiente no arquivo .env:
   API_URL=http://localhost:5000
   JWT_SECRET=YourVerySecureSecretKeyHereWithAtLeast32Characters

4. Inicie a aplicação:
   npm run start

Acesse o GraphQL Playground para testar a API: http://localhost:3000/graphql

**Exemplos de Queries e Mutations**

**Autenticação**
- Obter informações do usuário autenticado:
  query {
    me {
      id
      name
      email
    }
  }

- Login:
  mutation {
    login(loginInput: { email: "user@example.com", password: "password123" }) {
      token
    }
  }

- Registro:
  mutation {
    register(registerInput: { name: "John Doe", email: "john@example.com", password: "password123" }) {
      token
    }
  }

- Alterar Senha:
  mutation {
    changePassword(changePasswordInput: { email: "john@example.com", newPassword: "newPassword123" })
  }

- Alterar Email:
  mutation {
    changeEmail(changeEmailInput: { newEmail: "newemail@example.com" })
  }

- Alterar Nome:
  mutation {
    changeName(changeNameInput: { newName: "Jane Doe" })
  }

- Deletar Conta:
  mutation {
    deleteAccount(deleteAccountInput: { password: "password123" })
  }

**Clientes**
- Listar Clientes:
  query {
    listClients {
      id
      name
      email
      phone
    }
  }

- Criar Cliente:
  mutation {
    createClient(createClientInput: { name: "Cliente Teste", email: "cliente@example.com", phone: "123456789" })
  }

- Atualizar Cliente:
  mutation {
    updateClient(updateClientInput: { id: 1, name: "Nome Atualizado", email: "atualizado@example.com" })
  }

- Deletar Cliente:
  mutation {
    deleteClient(id: 1)
  }

**Consórcios**
- Listar Consórcios do Usuário:
  query {
    getUserConsortia {
      id
      name
      description
      assetValue
      numberOfInstallments
      administrationFee
      numberOfQuotas
      quotaValue
    }
  }

- Criar Consórcio:
  mutation {
    createConsortium(createConsortiumInput: { 
      name: "Consórcio Teste", 
      description: "Descrição do consórcio", 
      assetValue: 100000, 
      numberOfInstallments: 60, 
      administrationFee: 5, 
      numberOfQuotas: 10
    })
  }

- Atualizar Consórcio:
  mutation {
      updateConsortium(updateConsortiumInput: { 
      id: 1,  
      description: "Nova descrição do consórcio", 
      assetValue: 120000, 
      numberOfInstallments: 72, 
      administrationFee: 6, 
      numberOfQuotas: 12, 
      quotasValue: 10000 
  })
}

- Deletar Consórcio:
  mutation {
    deleteConsortium(id: 1)
  }

**Cotas**
- Listar Cotas de um Consórcio:
  query {
    listQuotas(input: { consortiumId: 1 }) {
      id
      consortiumId
      status
    }
  }

- Listar Parcelas de uma Cota:
  query {
    listInstallments(input: { quotaId: 1 }) {
      id
      value
      status
    }
  }

- Listar Cotas de um Cliente:
  query {
    getQuotasByClientId(clientId: 1) {
      id
      consortiumId
      status
    }
  }

- Pagar Parcela:
  mutation {
    payInstallment(input: { installmentId: 1 })
  }

- Vincular Cota a Cliente:
  mutation {
    linkQuotaToClient(input: { quotaId: 1, clientId: 1 })
  }

**Executando Testes**
Execute os testes unitários utilizando o comando:
  npm run test

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
Este projeto está licenciado sob a Licença MIT. Consulte o arquivo LICENSE para mais detalhes.
