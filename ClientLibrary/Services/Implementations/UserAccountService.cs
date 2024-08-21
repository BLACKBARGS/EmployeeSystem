using BaseLibrary.DTOs;
using BaseLibrary.Entities;
using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http.Json;

namespace ClientLibrary.Services.Implementations
{
    public class UserAccountService(GetHttpClient getHttpClient) : IUserAccountService
    {
        public const string AuThUrl = "api/authentication";
        public async Task<GeneralResponse> CreateAsync(Register user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/register", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "An error on registration occurred");
            return await result.Content.ReadFromJsonAsync<GeneralResponse>() ?? new GeneralResponse(false, "Failed to deserialize response");
        }

        public async Task<LoginResponse> SignInAsync(Login user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/login", user);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "An error on login occurred");
            return await result.Content.ReadFromJsonAsync<LoginResponse>() ?? new LoginResponse(false, "Failed to deserialize response");
        }

        public async Task<LoginResponse> RefreshTokenAsync(RefreshToken token)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PostAsJsonAsync($"{AuThUrl}/refresh-token", token);
            if (!result.IsSuccessStatusCode) return new LoginResponse(false, "Error occurred");
            var response = await result.Content.ReadFromJsonAsync<LoginResponse>();
            return response ?? new LoginResponse(false, "Failed to serialize response");
        }

        public async Task<List<ManageUser>> GetUsers()
        {
            var httpClient = await getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.GetFromJsonAsync<List<ManageUser>>($"{AuThUrl}/users");
            return result!;
        }

        public async Task<GeneralResponse> UpdateUser(ManageUser user)
        {
            var httpClient = getHttpClient.GetPublicHttpClient();
            var result = await httpClient.PutAsJsonAsync($"{AuThUrl}/update-user", user);
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "An error occurred");
            return await result.Content.ReadFromJsonAsync<GeneralResponse>() ?? new GeneralResponse(false, "Failed to deserialize response"); ;
        }

        public async Task<List<SystemRole>> GetRoles()
        {
            var httpClient = await getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.GetFromJsonAsync<List<SystemRole>>($"{AuThUrl}/roles");
            return result!;
        }

        public async Task<GeneralResponse> DeleteUser(int id)
        {
            var httpClient = await getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.DeleteAsync($"{AuThUrl}/delete-user/{id}");
            if (!result.IsSuccessStatusCode) return new GeneralResponse(false, "An error occurred");
            return await result.Content.ReadFromJsonAsync<GeneralResponse>() ?? new GeneralResponse(false, "Failed to deserialize response");
        }

    }
}
