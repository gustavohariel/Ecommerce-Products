# Web API CRUD using .NET 7, Swagger, and SQLite
This repository contains a simple Web API project built using .NET 7 that performs CRUD (Create, Read, Update, Delete) operations on a SQLite database (app.db). Swagger is also integrated to provide API documentation and testing capabilities.

# Prerequisites
Before running the application, ensure that you have the following prerequisites installed on your machine:

.NET 7 SDK
SQLite

# Getting Started
Clone this repository to your local machine:


```
git clone https://github.com/gustavohariel/Ecommerce-Products.git
```

Navigate to the project directory:

```
cd Ecommerce-Products
```
Build and run the application:

```
dotnet run
```

The API should now be running locally.

# Access the Swagger documentation:

Open your web browser and navigate to https://localhost:5001/swagger/index.html. You will see the API endpoints and can use Swagger for testing.

# API Endpoints
The API provides the following endpoints:

GET /api/Product: Retrieve a list of all products.

GET /api/Product/{id}: Retrieve a specific product by ID.

POST /api/Product: Create a new product.

PUT /api/Product/{id}: Update an existing product by ID.

DELETE /api/Product/{id}: Delete a product by ID.

# Database
The SQLite database (app.db) is located in the root of the project. You can customize the database schema and connection string in the appsettings.json file.

# Testing
You can use Swagger to test the API endpoints interactively. Open the Swagger UI at https://localhost:5001/swagger/index.html and try out the different CRUD operations.

# License
This project is licensed under the MIT License. See the LICENSE file for details.
