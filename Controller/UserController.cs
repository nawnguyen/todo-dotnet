using Microsoft.AspNetCore.Mvc;
using todo.Entity;
using todo.Repository;

namespace todo.Controller;

/**
 * Them 1 user
 * Lay toan bo danh sach user
 * Tim user theo ten
 * Xoa user theo ID
 * Tim user theo ID
 */
[ApiController]
public class UserController(IUserRepository repo) : Microsoft.AspNetCore.Mvc.Controller
{
    [HttpPost("/users")]
    public async Task<OkResult> AddTodo([FromBody] User user)
    {
        repo.AddUser(user);
        return Ok();
    }
    
    [HttpGet(template: "/users")]
    public async Task<List<User>> GetUsers()
    {
        return repo.GetAllUsers().ToList();
    }
    
    [HttpGet(template: "/users/{name}")]
    public User GetUser(string name)
    {
        return repo.GetUserByName(name);
    }
    
    [HttpDelete(template: "/users/{id}")]
    public async Task<OkResult> DeleteUser(int id)
    {
        repo.DeleteUser(id);
        return Ok();
    }
    
    [HttpGet(template: "/users/{id}")]
    public User GetUser(int id)
    {
        return repo.GetUserById(id);
    }
}
