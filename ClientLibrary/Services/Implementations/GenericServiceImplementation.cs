using BaseLibrary.Responses;
using ClientLibrary.Helpers;
using ClientLibrary.Services.Contracts;
using System.Net.Http.Json;

namespace ClientLibrary.Services.Implementations
{
    public class GenericServiceImplementation<T>(GetHttpClient getHttpClient) : IGenericServiceInterface<T>
    {
        private readonly GetHttpClient _getHttpClient = getHttpClient;

        // Create
        public async Task<GeneralResponse> Insert(T item, string baseUrl)
        {
            var httpClient = await _getHttpClient.GetPrivateHttpClient();
            var response = await httpClient.PostAsJsonAsync($"{baseUrl}/add", item);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                return result ?? new GeneralResponse(false, "Invalid response from server");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorContent}");
                return new GeneralResponse(false, "Failed to add item");
            }
        }

        // Read All
        public async Task<List<T>> GetAll(string baseUrl)
        {
            var httpClient = await _getHttpClient.GetPrivateHttpClient();
            var results = await httpClient.GetFromJsonAsync<List<T>>($"{baseUrl}/all");
            return results ?? [];
        }

        // Read Single {id}
        public async Task<T> GetById(int id, string baseUrl)
        {
            var httpClient = await _getHttpClient.GetPrivateHttpClient();
            var result = await httpClient.GetFromJsonAsync<T>($"{baseUrl}/single/{id}");
            return result == null ? throw new Exception("Item not found") : result;
        }

        // Update {model}
        public async Task<GeneralResponse> Update(T item, string baseUrl)
        {
            var httpClient = await _getHttpClient.GetPrivateHttpClient();
            var response = await httpClient.PutAsJsonAsync($"{baseUrl}/update", item);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                return result ?? new GeneralResponse(false, "Invalid response from server");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorContent}");
                return new GeneralResponse(false, "Failed to update item");
            }
        }

        // Delete {id}
        public async Task<GeneralResponse> DeleteById(int id, string baseUrl)
        {
            var httpClient = await _getHttpClient.GetPrivateHttpClient();
            var response = await httpClient.DeleteAsync($"{baseUrl}/delete/{id}");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<GeneralResponse>();
                return result ?? new GeneralResponse(false, "Invalid response from server");
            }
            else
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Error: {errorContent}");
                return new GeneralResponse(false, "Failed to delete item");
            }
        }
    }
}
