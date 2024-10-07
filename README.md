# Employee System

A robust system for managing branch offices and departments, developed using modern web technologies. This system allows users to view, add, edit, and delete branches linked to departments with a focus on user-friendly interfaces and secure data handling.

## 🚀 Features
- **Branch Management**: Add, view, edit, and delete branches.
- **User Authentication**: Secure JWT-based authentication and authorization.
- **Responsive UI**: Powered by Blazor WebAssembly with Bootstrap for a seamless experience across devices.

## 🛠️ Tech Stack
### Frontend
- **Blazor WebAssembly**: For interactive and responsive UI.
- **Razor Components**: Modular and reusable components.
- **Blazored.LocalStorage**: Local storage in the browser.
- **Syncfusion Blazor**: Additional UI components like pop-ups and dialogs.
- **Bootstrap**: Responsive styling.

### Backend
- **ASP.NET Core**: RESTful API to serve data.
- **Entity Framework Core**: Data access and ORM.
- **Microsoft SQL Server**: Database for secure data storage.

### Security
- **JWT**: User authentication and session management.
- **BCrypt**: Secure password hashing.

## 📂 Project Structure
- **Client**: Contains UI pages, services, and reusable components.
- **Server**: API controllers, repositories, and database context.
- **Shared**: Shared models and data transfer objects (DTOs).

## ⚙️ Installation and Setup

### Prerequisites
- .NET 6 or 8 SDK
- Node.js
- Microsoft SQL Server
- Syncfusion

### Steps
1. Clone the repository:
    ```bash
    git clone https://github.com/BLACKBARGS/EmployeeSystem.git
    cd EmployeeSystem
    ```
2. Restore NuGet packages:
    ```bash
    dotnet restore
    ```
3. Configure the connection string in `appsettings.json`.
4. Apply migrations to set up the database:
    ```bash
    dotnet ef database update
    ```
5. Run the backend server:
    ```bash
    dotnet run --project Server
    ```
6. Launch the frontend client:
    ```bash
    cd Client
    dotnet run --project Client
    ```

## 🤝 Contributing
Contributions are welcome! Feel free to open issues and pull requests.

## 📜 License
This project is licensed under the [MIT License](LICENSE.txt).
