# MoviesApp

A simple ASP.NET Core MVC application for managing a movie collection.

## Features

- Create, read, update, and delete movie records
- Server-side validation using data annotations
- Entity Framework Core for data access
- MVC pattern with Controllers, Models, and Views

## Getting Started

### Prerequisites

- .NET 10.0 SDK or later
- Visual Studio 2022 / Visual Studio Code or another code editor

### Running the Application

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd MoviesApp/MoviesApp
   ```
2. Restore dependencies and build:
   ```bash
   dotnet restore
   dotnet build
   ```
3. Run the project:
   ```bash
   dotnet run
   ```
4. Navigate to `https://localhost:5001` (or the URL shown in the console) to use the app.

### Database

The project uses Entity Framework Core with migrations. The initial migration has been applied. The database is created automatically when the application runs if it does not exist.

### Project Structure

- `Controllers` – MVC controllers for handling HTTP requests
- `Models` – Domain models and validation attributes
- `Data` – `MovieDbContext` for EF Core
- `Repository` – Interface and implementation for data access
- `Views` – Razor views for UI

### Validation

The `Movie` model includes validation attributes such as `[Required]`, `[Range]`, and `[RegularExpression]` to ensure data integrity.

### License

This project is provided for educational purposes.

### Author

Name: Peter Do

Student ID: 9086580
