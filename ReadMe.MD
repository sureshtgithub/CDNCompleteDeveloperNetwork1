CDN Complete Developer Network - Web API
Overview:

This is a project for CDN - Complete Developer Network, which includes a Web API built using ASP.NET Core 8. 
The backend stores data in a JSON file database. The Web API allows users to perform CRUD operations for managing users, 
including adding, updating, deleting, and retrieving user information.

Features:

CRUD Operations: Create, Read, Update, Delete freelancers.
JSON File Database: Lightweight and easy-to-use database stored as a JSON file.
RESTful API: Built with ASP.NET Core 8.


Technologies Used:
Backend: ASP.NET Core 8 Web API
Database: JSON File (using JsonFlatFileDataStore)
Package Management: NuGet (for .NET)
API Testing: Postman or Swagger

Prerequisites:
.NET 8 SDK: Download and install from here.
Visual Studio or VS Code for development.
Postman for API testing (optional).

Getting Started
Backend (ASP.NET Core 8 Web API)

Clone the Repository:
git clone https://github.com/sureshtgithub/CDNCompleteDeveloperNetwork

Navigate to the Project Folder:
cd CDNCompleteDeveloperNetwork

Install NuGet Packages: In Visual Studio, open the NuGet Package Manager and install the required packages, or use the command line:
dotnet restore
Install Required Packages:

Install JsonFlatFileDataStore for JSON-based database handling:
dotnet add package JsonFlatFileDataStore

Run the Project: Use the following command to run the Web API:
dotnet run
The Web API will be available at https://localhost:7144 by default.

API Endpoints:
The Web API exposes the following endpoints:
GET /api/users - Retrieves all users.
GET /api/users/{id} - Retrieves a specific user by ID.
POST /api/users - Creates a new user.
PUT /api/users/{id} - Updates an existing user.
DELETE /api/users/{id} - Deletes a user.

Sample JSON for Creating a User (POST /api/users)
{
  "username": "john_doe",
  "mail": "john.doe@example.com",
  "phoneNumber": "123-456-7890",
  "skillsets": "C#, .NET, SQL",
  "hobby": "Photography"
}

JSON File Database
The database is stored in a JSON file called users.json located in the root of the project.
All CRUD operations on users are performed by reading and writing to this JSON file.

Example Structure of users.json
[
  {
    "id": 1,
    "username": "john_doe",
    "mail": "john.doe@example.com",
    "phoneNumber": "123-456-7890",
    "skillsets": "C#, .NET, SQL",
    "hobby": "Photography"
  },
  {
    "id": 2,
    "username": "jane_smith",
    "mail": "jane.smith@example.com",
    "phoneNumber": "987-654-3210",
    "skillsets": "JavaScript, React, Node.js",
    "hobby": "Cooking"
  }
]

Configuration:
launchSettings.json: This file contains the configuration for how the project should launch, including the URLs to use for debugging.
appsettings.json: Used for environment variables and connection strings if needed. However, this project uses a JSON file as a database, so there’s no external database connection required.

Testing

Postman:
Use Postman to test the API endpoints.
Set the Accept header to application/json and provide the necessary JSON body for POST and PUT requests.

Swagger:
Swagger is enabled in development mode. Visit https://localhost:7144/swagger to test the API interactively.

Running the Project

Backend:
Use the following command in the root directory of the Web API project to start the API:
dotnet run

Troubleshooting:

404 Error for /weatherforecast: Ensure that launchSettings.json is correctly set up to point to api/users or swagger.
JSON Database Not Updating: Check that the file users.json exists and has appropriate read/write permissions.

Future Improvements:

Switch to a more scalable database like MongoDB or SQL Server as needed.
Add authentication and authorization for securing API endpoints.

