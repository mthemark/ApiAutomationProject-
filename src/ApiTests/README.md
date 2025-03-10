# ApiAutomationProject/src/ApiTests/README.md

# API Tests Documentation

This directory contains the xUnit test project for testing the API client library generated from the OpenAPI specification.

## Running the Tests

To run the tests, ensure you have the following prerequisites:

- .NET SDK installed on your machine.
- The API client library project should be built successfully.

### Steps to Run Tests

1. Open a terminal and navigate to the `ApiTests` directory.
2. Run the following command to execute the tests:

   ```
   dotnet test
   ```

## Test Structure

The tests are located in the `Tests` folder and are organized in the `ApiTests.cs` file. Each test case is designed to validate specific functionalities of the API client.

## Adding New Tests

To add new tests:

1. Open the `ApiTests.cs` file.
2. Create a new test method following the xUnit conventions.
3. Ensure that your test cases cover various scenarios, including success and error cases.

## Contributing

If you would like to contribute to the test suite, please follow the guidelines outlined in the main project README.