using Microsoft.AspNetCore.Mvc;
using todo.Entity;
using todo.Repository;

namespace todo.Controller;

[ApiController]
public class TodoController(ITodoRepository repo) : Microsoft.AspNetCore.Mvc.Controller
{
    [HttpGet("/todos/{name}")]
    public Todo GetTodo(string name) => repo.GetTodoByName(name);
    
    [HttpGet("/todos")]
    public async Task<List<Todo>> GetTodos()
    {
        return repo.GetAllTodos().ToList();
    }
    
    [HttpPost("/todos")]
    public async Task<OkResult> AddTodo([FromBody] Todo todo)
    {
        repo.AddTodo(todo);
        return Ok();
    }
    
    [HttpDelete("/todos/{id}")]
    public async Task<OkResult> DeleteTodo([FromRoute] int id)
    {
        repo.DeleteTodo(id);
        return Ok();
    }
}