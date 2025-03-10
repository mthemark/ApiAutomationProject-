using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace ApiTests.Tests
{
    public class ApiTests
    {
        private readonly HttpClient _httpClient;

        public ApiTests()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://api.example.com/") // Replace with your API base URL
            };
        }

        [Fact]
        public async Task GetEndpoint_ReturnsSuccessStatusCode()
        {
            // Arrange
            var requestUri = "endpoint"; // Replace with your API endpoint

            // Act
            var response = await _httpClient.GetAsync(requestUri);

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task PostEndpoint_ReturnsCreatedStatusCode()
        {
            // Arrange
            var requestUri = "endpoint"; // Replace with your API endpoint
            var content = new StringContent("{\"key\":\"value\"}", System.Text.Encoding.UTF8, "application/json"); // Replace with your request body

            // Act
            var response = await _httpClient.PostAsync(requestUri, content);

            // Assert
            Assert.Equal(System.Net.HttpStatusCode.Created, response.StatusCode);
        }

        // Additional tests can be added here
    }
}