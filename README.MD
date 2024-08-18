# Branch Management System

Este projeto � um sistema de gerenciamento de filiais desenvolvido utilizando v�rias tecnologias modernas. Ele permite que os usu�rios visualizem, adicionem, editem e excluam filiais associadas a departamentos.

## Tecnologias Utilizadas

### Frontend

- **Blazor WebAssembly**: Utilizado para construir a interface do usu�rio interativa e responsiva.
- **Razor Components**: Para criar componentes reutiliz�veis e modulares.
- **Bootstrap**: Para estiliza��o e layout responsivo.
- **Blazored.LocalStorage**: Para armazenamento local no navegador.
- **Syncfusion Blazor**: Para componentes adicionais de UI, como di�logos e pop-ups.

### Backend

- **ASP.NET Core**: Para construir a API RESTful que serve os dados para o frontend.
- **Entity Framework Core**: Para acesso e manipula��o de dados no banco de dados.
- **Microsoft SQL Server**: Banco de dados relacional utilizado para armazenar os dados da aplica��o.

### Seguran�a

- **JWT (JSON Web Tokens)**: Para autentica��o e autoriza��o de usu�rios.
- **BCrypt**: Para hashing de senhas.

## Estrutura do Projeto

### Client

- **Pages/ContentPages/DepartmentPages/BranchPage.razor**: P�gina principal para gerenciamento de filiais.
- **Services**: Servi�os para comunica��o com a API backend.
- **Components**: Componentes reutiliz�veis, como di�logos e formul�rios.

### Server

- **Controllers**: Controladores da API para gerenciar requisi��es HTTP.
- **Repositories**: Implementa��es de reposit�rios para acesso a dados.
- **Data**: Configura��es de contexto do banco de dados e migra��es.

### Shared

- **Models**: Modelos de dados compartilhados entre o cliente e o servidor.
- **DTOs**: Objetos de transfer�ncia de dados para comunica��o entre camadas.

## Funcionalidades

- **Visualiza��o de Filiais**: Exibe uma lista de filiais associadas a departamentos.
- **Adi��o de Filiais**: Permite adicionar novas filiais.
- **Edi��o de Filiais**: Permite editar informa��es de filiais existentes.
- **Exclus�o de Filiais**: Permite excluir filiais.
- **Autentica��o e Autoriza��o**: Utiliza JWT para autenticar e autorizar usu�rios.

## Como Executar o Projeto

### Pr�-requisitos

- .NET 6 OU 8 SDK
- Node.js (para gerenciamento de pacotes)
- SQL Server


