# 🏢 Employee System

Este projeto é um sistema de gerenciamento de filiais desenvolvido utilizando tecnologias modernas. Ele permite que os usuários visualizem, adicionem, editem e excluam filiais associadas a departamentos.

## 🚀 Tecnologias Utilizadas

### Frontend

- **Blazor WebAssembly**: Interface do usuário interativa e responsiva.
- **Razor Components**: Componentes reutilizáveis e modulares.
- **Bootstrap**: Estilização e layout responsivo.
- **Blazored.LocalStorage**: Armazenamento local no navegador.
- **Syncfusion Blazor**: Componentes adicionais de UI, como diálogos e pop-ups.

### Backend

- **ASP.NET Core**: API RESTful que serve os dados para o frontend.
- **Entity Framework Core**: Acesso e manipulação de dados no banco de dados.
- **Microsoft SQL Server**: Banco de dados relacional utilizado para armazenar os dados da aplicação.

### Segurança

- **JWT (JSON Web Tokens)**: Autenticação e autorização de usuários.
- **BCrypt**: Hashing de senhas.

## 🗂️ Estrutura do Projeto

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

## ✨ Funcionalidades

- **Visualização de Filiais**: Exibe uma lista de filiais associadas a departamentos.
- **Adição de Filiais**: Permite adicionar novas filiais.
- **Edição de Filiais**: Permite editar informações de filiais existentes.
- **Exclusão de Filiais**: Permite excluir filiais.
- **Autenticação e Autorização**: Utiliza JWT para autenticar e autorizar usuários.

## 🛠️ Como Executar o Projeto

### Pré-requisitos

- .NET 6 ou 8 SDK
- Node.js (para gerenciamento de pacotes)
- SQL Server

### Passos

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio

2. Restaure os pacotes NuGet
	```bash
	dotnet restore

3. Configure a string de conexão com o banco de dados no arquivo `appsettings.json`.

4. Execute as migrações para criar o banco de dados:

   ```bash
   dotnet ef database update

5. Inicie o servidor:

   ```bash
   dotnet run --project Server

6. Execute o cliente:

   ```bash
   cd Client
   dotnet run


## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests.

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.