# Akcelita C# Code Test

## Configuration

Make sure that you have **netcore 6.0** installed ([Download Here](https://dotnet.microsoft.com/en-us/download/dotnet/6.0))

### Entity Framework Core Tools

This project uses Entity Framework as an ORM. To install the tools run the following command.

```bash
dotnet tool install --global dotnet-ef
```

[Installation Guide](https://docs.microsoft.com/en-us/ef/core/get-started/overview/install)

### Database Migration

Once you have EF Tools installed we must run the migration of the database.

```bash
dotnet ef database update
```

## Running the project

To run the project execute the following command in the root of the project in your terminal

```bash
dotnet run --watch
```

## Swagger

You can look at the documentation of the API and test your code by going to [https://localhost:7145/swagger/index.html](https://localhost:7145/swagger/index.html)

This will open the Swagger documentation and you will be able to test each one of the endpoints needed for this project.

## Completing the tasks

There are four tasks that need to be completed for this project

### ✅  Insert a new order into the system.

You must finish the `PostOrder` method inside of `Controllers/OrdersController.cs`. The Data Transfer Object has already been created for you. It is important that the total cost of the order is calculated based on the products selected.

**To keep things simple, an order cannot have repeating products**

### ✅  Get the Sales Per City

Implement `GetSalesPerCity` method inside of `StatsController/GetSalesPerCity`. The expected Object has already been created for you.

### ✅  Get the number of Orders Per User

Implement `GetSalesPerCity` method inside of `StatsController/GetOrdersPerUsers`. The expected Object has already been created for you.

### ✅  Get the total number of products sold

Implement `GetSalesPerCity` method inside of `StatsController/GetProductsSold`. The expected Object has already been created for you.

## Submission

You can submit your code by creating a fork of this project and sending the new repository or generating a Zip version of your project and emailing at **johnnietirado@akcelita.com**

### Good Luck!

