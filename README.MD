# Branch Management System

Este projeto é um sistema de gerenciamento de filiais desenvolvido utilizando várias tecnologias modernas. Ele permite que os usuários visualizem, adicionem, editem e excluam filiais associadas a departamentos.

## Tecnologias Utilizadas

### Frontend

- **Blazor WebAssembly**: Utilizado para construir a interface do usuário interativa e responsiva.
- **Razor Components**: Para criar componentes reutilizáveis e modulares.
- **Bootstrap**: Para estilização e layout responsivo.
- **Blazored.LocalStorage**: Para armazenamento local no navegador.
- **Syncfusion Blazor**: Para componentes adicionais de UI, como diálogos e pop-ups.

### Backend

- **ASP.NET Core**: Para construir a API RESTful que serve os dados para o frontend.
- **Entity Framework Core**: Para acesso e manipulação de dados no banco de dados.
- **Microsoft SQL Server**: Banco de dados relacional utilizado para armazenar os dados da aplicação.

### Segurança

- **JWT (JSON Web Tokens)**: Para autenticação e autorização de usuários.
- **BCrypt**: Para hashing de senhas.

## Estrutura do Projeto

### Client

- **Pages/ContentPages/DepartmentPages/BranchPage.razor**: Página principal para gerenciamento de filiais.
- **Services**: Serviços para comunicação com a API backend.
- **Components**: Componentes reutilizáveis, como diálogos e formulários.

### Server

- **Controllers**: Controladores da API para gerenciar requisições HTTP.
- **Repositories**: Implementações de repositórios para acesso a dados.
- **Data**: Configurações de contexto do banco de dados e migrações.

### Shared

- **Models**: Modelos de dados compartilhados entre o cliente e o servidor.
- **DTOs**: Objetos de transferência de dados para comunicação entre camadas.

## Funcionalidades

- **Visualização de Filiais**: Exibe uma lista de filiais associadas a departamentos.
- **Adição de Filiais**: Permite adicionar novas filiais.
- **Edição de Filiais**: Permite editar informações de filiais existentes.
- **Exclusão de Filiais**: Permite excluir filiais.
- **Autenticação e Autorização**: Utiliza JWT para autenticar e autorizar usuários.

## Como Executar o Projeto

### Pré-requisitos

- .NET 6 OU 8 SDK
- Node.js (para gerenciamento de pacotes)
- SQL Server



