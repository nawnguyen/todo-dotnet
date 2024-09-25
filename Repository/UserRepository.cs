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

    public IEnumerable<User> GetAllUsers()
    {
    return context.Users;
    }
    
    public User GetUserByName(string name)
    {
        var user = context.Users.FirstOrDefault(user => user.Name == name);
        if (user == null) throw new Exception("User not found");
        
        return user;
    }
    
    public void DeleteUser(int id)
    {
        var user = context.Users.FirstOrDefault(u => u.Id == id);
        if (user == null) throw new Exception("User not found");
        
        context.Users.Remove(user);
        context.SaveChanges();
    }

    public User GetUserById(int id)
    {
        var user = context.Users.FirstOrDefault(user => user.Id == id);
        if (user == null) throw new Exception("User not found");
        
        return user;
    }

}