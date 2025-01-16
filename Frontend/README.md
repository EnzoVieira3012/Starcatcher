**Starcatcher Microfrontend Architecture**

Índice
Descrição do Projeto
Arquitetura Microfrontend
Microfrontends
1. MFE Host
2. MFE User
3. MFE Clients
4. MFE Consortium
5. MFE Quota
Tecnologias Utilizadas
Configuração do Ambiente
Como Rodar o Projeto
Rodando Localmente
Build para Produção
Boas Práticas e Sugestões

**Descrição do Projeto**
O Starcatcher é uma aplicação modular baseada em arquitetura de microfrontends (MFEs). Cada MFE é responsável por uma funcionalidade específica, como gerenciamento de usuários, clientes, consórcios e cotas. A aplicação utiliza o Webpack Module Federation para integrar os MFEs em um único sistema coeso.

A arquitetura permite:
Desenvolvimento independente de cada MFE.
Desdobramento e implantação modular.
Manutenibilidade e escalabilidade aprimoradas.

**Arquitetura Microfrontend**
A arquitetura é composta por um Host (aplicação principal) que consome e integra os microfrontends remotos. Cada MFE é implantado de maneira independente, mas compartilha dependências e comunicação via Module Federation.

**Estrutura**
Starcatcher/
├── mfe-host/ - Aplicação principal que integra os MFEs
├── mfe-user/ - MFE para gerenciamento de usuários
├── mfe-clients/ - MFE para gerenciamento de clientes
├── mfe-consortium/ - MFE para gerenciamento de consórcios
├── mfe-quota/ - MFE para gerenciamento de cotas

Comunicação
A comunicação entre os MFEs é gerenciada por:
Module Federation: Compartilhamento de componentes/páginas entre os MFEs.
Apollo Client: Integração com APIs GraphQL para manipulação de dados.

**Microfrontends**

1. MFE Host
Descrição: O mfe-host é a aplicação principal que consome e integra os outros MFEs.
Porta: 4000
Funcionalidades:
Exibição e navegação entre os MFEs.
Gerenciamento do estado de navegação.
Configuração do Webpack:
Consome remotes:
{
  "auth": "auth@http://localhost:4001/remoteEntry.js",
  "consortium": "consortium@http://localhost:4002/remoteEntry.js",
  "quota": "quota@http://localhost:4003/remoteEntry.js",
  "clients": "clients@http://localhost:4004/remoteEntry.js",
  "user": "user@http://localhost:4005/remoteEntry.js"
}
Rotas e Páginas:
/login - Página de login.
/dashboard - Página inicial.
/profile - Perfil do usuário.

2. MFE User
Descrição: O mfe-user gerencia as informações do usuário, como perfil, senha e exclusão de conta.
Porta: 4005
Funcionalidades:
Exibição do perfil do usuário.
Alteração de informações pessoais (nome, e-mail, senha).
Exclusão de conta.
Expostos pelo Module Federation:
./DashboardPage
./ProfilePage
Tecnologias:
Apollo Client para GraphQL.
TailwindCSS para estilização.

3. MFE Clients
Descrição: O mfe-clients é utilizado para gerenciar clientes.
Porta: 4004
Funcionalidades:
Listar clientes.
Criar, editar e excluir clientes.
Exibir detalhes de cada cliente.
Expostos pelo Module Federation:
./ClientListPage
./ClientProfilePage
Tecnologias:
Apollo Client para manipulação de dados.
Redux Toolkit para gerenciamento de estado local.

4. MFE Consortium
Descrição: O mfe-consortium gerencia consórcios.
Porta: 4002
Funcionalidades:
Listar consórcios do usuário.
Criar, editar e excluir consórcios.
Expostos pelo Module Federation:
./ConsortiumListPage
./CreateConsortiumPage
Tecnologias:
Apollo Client para integração com APIs GraphQL.

5. MFE Quota
Descrição: O mfe-quota gerencia as cotas de consórcios.
Porta: 4003
Funcionalidades:
Listar cotas de um consórcio.
Vincular cotas a clientes.
Atualizar consórcios.
Exposto pelo Module Federation:
./QuotaListPage
Tecnologias:
Apollo Client para consultas e mutações GraphQL.

**Tecnologias Utilizadas**
React: Biblioteca para construção de interfaces de usuário.
Webpack Module Federation: Para integração e compartilhamento de MFEs.
Apollo Client: Comunicação com APIs GraphQL.
Redux Toolkit: Gerenciamento de estado global no MFE Clients.
TailwindCSS: Estilização responsiva.
Jest e Testing Library: Testes automatizados.

**Configuração do Ambiente**
Pré-requisitos
Certifique-se de que os seguintes programas estão instalados:
Node.js (>= 16.x)
Yarn ou npm

**Instalação**
Execute os comandos abaixo para instalar as dependências de cada MFE:
cd mfe-host && yarn install
cd ../mfe-user && yarn install
cd ../mfe-clients && yarn install
cd ../mfe-consortium && yarn install
cd ../mfe-quota && yarn install

Como Rodar o Projeto
Rodando Localmente
Certifique-se de que o backend GraphQL esteja rodando na porta 3000.
Inicie cada MFE em um terminal separado:
# Iniciar o Host
cd mfe-host
yarn start
# Iniciar o MFE User
cd ../mfe-user
yarn start
# Iniciar o MFE Clients
cd ../mfe-clients
yarn start
# Iniciar o MFE Consortium
cd ../mfe-consortium
yarn start
# Iniciar o MFE Quota
cd ../mfe-quota
yarn start

Acesse o Host no navegador:
http://localhost:4000

Build para Produção
Para gerar os arquivos de produção:
# Em cada MFE, execute:
yarn build
Os arquivos gerados estarão na pasta /dist de cada MFE.

**Contribuição**
Contribuições são bem-vindas! Para contribuir:
Faça um fork do repositório.
Crie uma branch para sua feature:
git checkout -b minha-feature
Envie um pull request com suas alterações.

**Licença**
Este projeto é licenciado sob a MIT License.
