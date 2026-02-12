# Learning_Concepts_of_ASPdotNET_Core

## Today's Topic is EF Core

### What is EF Core?
EF Core (Entity Framework Core) is an open-source, lightweight, and extensible version of the popular Entity Framework data access technology. 
It is a modern object-database mapper that enables .NET developers to work with databases using .NET objects. 
EF Core supports a wide range of database providers, including SQL Server, SQLite, PostgreSQL, MySQL, and more.

### Steps
1. Installed EntityFramework Core, Entity Framework Core Tools, and Entity Framework Core SQL Server packages using NuGet Package Manager. 
2. Created a new folder named "Models" in the project and added a new class named "Student.cs" to represent the student entity.
3. Defined properties in the Student class, such as Id, Name, Age, and Email.
4. Created a new folder named "Data" and added a new class named "AppDbContext.cs" to represent the database context.
5. In the AppDbContext class, inherited from DbContext and defined a DbSet<Student> property to represent the Students table in the database.
6. Configured the database connection string in the appsettings.json file.
7. Registered the AppDbContext in the Program.cs file.
8. Created a new controller named "StudentsController.cs" to handle CRUD operations for the Student entity.
9. Implemented actions in the StudentsController to perform Create, Read, Update, and Delete operations on the Student entity using EF Core.
10. Created DTOs (Data Transfer Objects) if necessary to transfer data between the controller and the views.
	1. Dto helped in decoupling the internal data structure from the external representation, allowing for better control over the data being sent to and received from the client.

11. Created migrations using the Package Manager Console to generate the necessary database schema based on the defined models and context.

### What are Migrations?
Migrations in Entity Framework Core are a way to manage database schema changes over time.
They allow developers to evolve the database schema as the application evolves, without losing existing data.
Migrations provide a way to create, update, and manage the database schema based on the changes made to the entity models and the database context. 
When you create a migration, EF Core generates code that represents the changes needed to update the database schema to match the current state of your models.

``` dotnet ef migrations add InitialCreate
	dotnet ef database update
```

``` dotnet ef migrations add InitialCreate``` - This command creates a new migration named "InitialCreate" based on the current state of the models and the database context.
``` dotnet ef database update``` - This command applies the pending migrations to the database, updating the schema to match the current state of the models. It converts the migration code into SQL commands and executes them against the database to create or modify tables, columns, indexes, etc., as defined in the migration.

### Code-first approach vs Database-first approach
1. Code-first approach: 
	1. In this approach, you define your entity models and database context in code, and EF Core generates the database schema based on your code. 
	2. You can use migrations to manage schema changes over time. 
	3. This approach is often preferred when starting a new project or when you want more control over the database schema.
2. Database-first approach: 
	1. In this approach, you start with an existing database and generate the entity models and database context based on the database schema. 
	2. EF Core can reverse engineer the database to create the necessary code. 
	3. This approach is often used when working with legacy databases or when you want to quickly scaffold a data access layer based on an existing database.

### What I learned from this topic?
1. I learned how to set up and configure Entity Framework Core in an ASP.NET Core application.
2. I learned how to define entity models and a database context to represent the database structure.
3. I learned how to perform CRUD operations using EF Core in a controller.
4. I learned how to create and apply migrations to manage database schema changes over time.
5. I learned the importance of using DTOs to decouple internal data structures from external representations, improving control over data transfer between the client and server.
6. I learned the differences between code-first and database-first approaches in EF Core and when to use each approach based on the project requirements.
7. I learned about migrations in EF Core and how they help manage database schema changes without losing existing data, allowing for a smooth evolution of the database as the application evolves.
8. Overall, I gained a solid understanding of how to use Entity Framework Core to interact with databases in an ASP.NET Core application, and I am now equipped to implement data access functionality using EF Core in my projects.
