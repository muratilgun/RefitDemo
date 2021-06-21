using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RefitDemo.Configuration;
using RefitDemo.Models;

namespace RefitDemo.Services
{
    public class TodoService : ITodoService
    {
        private readonly IApiConfig _config;
        private readonly HttpClient _httpClient;

        public TodoService(HttpClient httpClient, IApiConfig config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<TodoModel> GetTodo(int id)
        {
            return await _httpClient.GetFromJsonAsync<TodoModel>(
                $"{_config.BaseUrl}todos/{id}");
        }
    }
}
