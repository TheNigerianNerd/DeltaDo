using System.Net.Http.Json;
using DeltaDo.Shared;

namespace DeltaDo.Client.Services;
public class LocalTodoService(HttpClient http) {
    public async Task<List<TodoItem>> GetAsync() =>
        await http.GetFromJsonAsync<List<TodoItem>>("data/todos.json") ?? [];
}
