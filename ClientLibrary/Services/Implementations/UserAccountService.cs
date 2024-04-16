using BaseLibrary.DTOs;
using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http.Json;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService(GetHttpClient getHttpClient) : IUserAccountService
    {
        public const string AuThUrl = "api/authentication";
        public async Task<GeneralResponse> CreateAsync(Register user) // Create a new user
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/register", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "An error on registration occurred"); // If the request is not successful, return a general response with a message
            return await result.Content.ReadFromJsonAsync<GeneralResponse>() ?? new GeneralResponse(false, "Failed to deserialize response"); // If the response is null, return a general response with a message
        }

        public async Task<LoginResponse> SignInAsync(Login user) // Sign in a user
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/login", user);
            // If the request is not successful, return a login response with a message
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "An error on login occurred");
            return await result.Content.ReadFromJsonAsync<LoginResponse>() ?? new LoginResponse(false, "Failed to deserialize response");
        }

        public async Task<LoginResponse> RefreshTokenAsync(RefreshToken token) // Refresh the token
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/refresh-token", token);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Error occurred");
            var response = await result.Content.ReadFromJsonAsync<LoginResponse>();
            return response ?? new LoginResponse(false, "Failed to serialize response");
        }

        public async Task<WeatherForecast[]> GetWeatherForecasts() // Get the weather forecast from the server
        {
            var httpClient = await getHttpClient.GetPrivacyHttpClient();
            var result = await httpClient.GetFromJsonAsync<WeatherForecast[]>("api/weatherforecast");
            return result ?? Array.Empty<WeatherForecast>();
        }
    }
}