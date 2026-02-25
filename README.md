# EFCode


Entity Framework Core (.NET 8) – Code First & Database First

This solution demonstrates two approaches of using Entity Framework Core with SQL Server in .NET 8:

Code First

Database First (Scaffold)

Both projects connect to a shared SQL Server Docker container.

🏗 Solution Structure
Solution
│
├── ConsoleApp.CodeFirst
├── ConsoleApp.DatabaseFirst
└── docker-compose.yml (optional)
🐳 SQL Server Docker Setup
Step 1 – Run SQL Server Container
docker run -e "ACCEPT_EULA=Y" \
-e "SA_PASSWORD=YourStrong!Pass123" \
-p 1433:1433 \
--name sqlserver-container \
-d mcr.microsoft.com/mssql/server:2022-latest
Step 2 – Verify Container
docker ps
Step 3 – Connect Using SSMS

Server:

localhost,1433

Login:

User: sa
Password: YourStrong!Pass123
🔵 Project 1 – Code First Approach
Overview

In this approach:

C# entity classes define the model

EF Core generates database schema using migrations

Packages Used
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
Connection String
"Server=localhost,1433;Database=CodeFirstDb;User Id=sa;Password=YourStrong!Pass123;TrustServerCertificate=True;"
Create Migration
dotnet ef migrations add InitialCreate
dotnet ef database update

This creates the database automatically inside the Docker container.

Features Demonstrated

Entity configuration

DbContext

Fluent API

Migrations

CRUD operations

🔵 Project 2 – Database First Approach
Overview

In this approach:

Database schema exists first

EF Core generates entity classes using Scaffold

Step 1 – Create Database

Using SSMS:

CREATE DATABASE DatabaseFirstDb;

Create tables manually:

CREATE TABLE Customers(
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);
Step 2 – Scaffold Models

Run inside project folder:

dotnet ef dbcontext scaffold \
"Server=localhost,1433;Database=DatabaseFirstDb;User Id=sa;Password=YourStrong!Pass123;TrustServerCertificate=True;" \
Microsoft.EntityFrameworkCore.SqlServer \
-o Models

This generates:

DbContext

Entity classes

Fluent configuration

Features Demonstrated

Reverse engineering database

Relationship mapping

LINQ queries

CRUD operations

📌 Key Differences
Feature	Code First	Database First
Database Created By	EF Core	Developer
Migrations Used	Yes	No (optional)
Model Source	C# Classes	SQL Schema
Best For	New projects	Legacy DB
🔐 Important Notes

Password must meet SQL Server complexity rules.

Always use TrustServerCertificate=True for local Docker.

Do not hardcode credentials in production.

Consider using appsettings.json for configuration.

🚀 How to Run

Start Docker container

Run Code First project → apply migrations

Create DatabaseFirstDb manually

Scaffold database

Run both console apps