using todo.DBContext;
using todo.Entity;

namespace todo.Repository;

public class UserRepository(ApiDbContext context) : IUserRepository
{
    public void AddUser(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
    }
}