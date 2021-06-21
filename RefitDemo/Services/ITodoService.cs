using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RefitDemo.Models;

namespace RefitDemo.Services
{
    public interface ITodoService
    {
        Task<TodoModel> GetTodo(int id);
    }
}
