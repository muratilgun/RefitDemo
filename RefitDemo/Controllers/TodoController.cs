using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using RefitDemo.Abstraction;
using RefitDemo.Services;

namespace RefitDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("GetTodo/{id}")]
        public async Task<IActionResult> GetTodo(int id)
        {
            return Ok(await _todoService.GetTodo(id));
        }

        [HttpGet("GetTodos")]
        public async Task<IActionResult> GetTodo()
        {
            var api = RestService.For<ITodoApi>("https://jsonplaceholder.typicode.com/");
            return Ok(await api.GetTodos());
        }
    }
}
