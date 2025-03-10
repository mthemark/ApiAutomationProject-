# ApiAutomationProject

This project is designed to automate testing for REST APIs using a generated API client based on an OpenAPI specification. It consists of two main components: an API client library and an xUnit test project.

## Project Structure

- **src/ApiClient**: Contains the API client library that interacts with the REST API.
  - **ApiClient.csproj**: Project file for the API client library.
  - **Generated**: Directory containing the generated API client files based on the OpenAPI specification.
  - **README.md**: Documentation for the API client library.

- **src/ApiTests**: Contains the xUnit test project for testing the API client.
  - **ApiTests.csproj**: Project file for the xUnit test project.
  - **Tests**: Directory containing the test cases for the API client.
    - **ApiTests.cs**: Test cases that validate the functionality of the generated API client.
  - **README.md**: Documentation for the test project.

- **openapi.yaml**: OpenAPI specification file that defines the API endpoints, request/response models, and other details necessary for generating the API client.

- **ApiAutomationProject.sln**: Solution file that groups the API client and test projects together.

## Setup Instructions

1. Clone the repository to your local machine.
2. Ensure you have the necessary tools installed, such as .NET SDK.
3. Navigate to the project directory and restore the dependencies:
   ```
   dotnet restore
   ```
4. To generate the API client from the OpenAPI specification, use the OpenAPI Generator tool.
5. Build the solution:
   ```
   dotnet build ApiAutomationProject.sln
   ```

## Running Tests

To run the tests for the API client, navigate to the `src/ApiTests` directory and execute the following command:
```
dotnet test
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.