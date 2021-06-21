using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;
using RefitDemo.Models;

namespace RefitDemo.Abstraction
{
    public interface ITodoApi
    {
        [Get("/todos")]
        Task<IEnumerable<TodoModel>> GetTodos();
    }
}
