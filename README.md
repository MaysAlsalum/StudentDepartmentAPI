# 🎓 StudentDepartmentAPI

A RESTful Web API built with **ASP.NET Core** for managing students and departments. The project demonstrates CRUD operations, authentication using ASP.NET Identity, and clean API development practices.

## ✨ Features

- 🔐 User Registration & Login
- 👤 ASP.NET Identity Authentication
- 🏫 Department Management
- 🎓 Student Management
- 🔄 Full CRUD Operations
- 📄 RESTful API Endpoints
- 📚 Swagger API Documentation
- 💾 Entity Framework Core
- 🗄️ SQL Server Database

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- ASP.NET Identity
- Swagger / OpenAPI
- Visual Studio

---

## Project Structure

```
StudentDepartmentAPI
│
├── Controllers/
├── Models/
├── DTOs/
├── Data/
├── Properties/
├── Migrations/
├── Program.cs
├── appsettings.json
└── StudentDepartmentAPI.csproj
```

---

## API Features

### Authentication

- Register User
- Login User

### Departments

- Get All Departments
- Get Department by ID
- Create Department
- Update Department
- Delete Department

### Students

- Get All Students
- Get Student by ID
- Create Student
- Update Student
- Delete Student

---

## Getting Started

### Clone the repository

```bash
git clone https://github.com/MaysAlsalum/StudentDepartmentAPI.git
```

### Navigate to the project

```bash
cd StudentDepartmentAPI
```

### Update the connection string

Modify the SQL Server connection string inside:

```
appsettings.json
```

### Apply migrations

```bash
dotnet ef database update
```

### Run the project

```bash
dotnet run
```

Or simply press **F5** in Visual Studio.

---

## API Documentation

After running the application, open Swagger:

```
https://localhost:<port>/swagger
```

---

## Learning Outcomes

This project demonstrates:

- Building RESTful APIs
- ASP.NET Identity Authentication
- Entity Framework Core
- SQL Server Integration
- CRUD Operations
- API Documentation with Swagger
- Clean Project Structure

---

## Future Improvements

- JWT Authentication
- Role-Based Authorization
- Pagination
- Filtering & Searching
- Logging
- Unit Testing
- Docker Support

---

## License

This project was developed for learning and educational purposes.
