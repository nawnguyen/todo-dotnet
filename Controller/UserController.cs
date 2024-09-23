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
}
