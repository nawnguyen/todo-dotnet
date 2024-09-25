using todo.Entity;

namespace todo.Repository;

public interface IUserRepository
{
    void AddUser(User user);
    
    IEnumerable<User> GetAllUsers();
    
    User GetUserByName(string name);
    
    void DeleteUser(int id);
    
    User GetUserById(int id);
}
