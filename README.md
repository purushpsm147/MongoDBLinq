# MongoDBLinq

This project demonstrates how to interact with MongoDB using C# and the MongoDB.Driver library. It includes examples of connecting to a MongoDB database, reading documents, and applying filters.

## Project Structure

- **MongoDBLinq.csproj**: Project file containing package references and build settings.
- **Program.cs**: Main program file with examples of MongoDB operations.

## Prerequisites

- .NET 8.0 SDK
- MongoDB instance (local or cloud)

## Installation
    
1. Clone the repository:
   - git clone https://github.com/your-repo/MongoDBLinq.git
   - cd MongoDBLinq
    
2. Restore the dependencies:
    - dotnet restore


## Configuration

Ensure you have a MongoDB connection string. The connection string in the example is:
```csharp
var dbClient = new MongoClient("your-mongodb-connection-string");
```

Replace `"your-mongodb-connection-string"` with your actual MongoDB connection string.

## Usage

1. Run the application:
    - dotnet run

2. The program will:
    - Connect to the MongoDB instance.
    - Retrieve and display the first document in the `grades` collection.
    - Apply a filter to find a specific document by `student_id`.
    - Apply a filter to find documents with high exam scores.


## Dependencies

- [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver/)
- [Microsoft.Extensions.Configuration.UserSecrets](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.UserSecrets/)

## License

This project is licensed under the MIT License.


