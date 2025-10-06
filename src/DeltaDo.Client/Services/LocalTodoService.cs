using DeltaDo.Shared;
using System.Text.Json;
using System.Net;
using System.Net.Http.Json;
namespace DeltaDo.Client.Services
{
    public class LocalTodoService
    {
        private readonly HttpClient _httpClient;

        public LocalTodoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<IEnumerable<TodoItem>> GetAllAsync()
        //{
        //    //JsonConvert.DeserializeObject<Payment>(response.owedAmounts); 
        //    var response = await _httpClient.("data/todos.json");
        //    var todos = await JsonSerializer.DeserializeAsync<IEnumerable<TodoItem>>(response);
        //    return todos;
        //}
        public async Task<IEnumerable<TodoItem>> GetAllAsync()
        {
            const string url = "data/todos.json";

            // The one-line implementation:
            // GetFromJsonAsync fetches the file and deserializes it directly.
            // We use ?? Array.Empty<TodoItem>() as a safeguard against a null response.
            var todos = await _httpClient.GetFromJsonAsync<IEnumerable<TodoItem>>(url);

            return todos ?? Array.Empty<TodoItem>();
        }
    }
}
