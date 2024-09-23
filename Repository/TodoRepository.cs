using todo.DBContext;
using todo.Entity;

namespace todo.Repository;

public class TodoRepository(ApiDbContext context) : ITodoRepository
{
    public Todo GetTodoByName(string tenCanTim)
    {
        var todo = context.Todos.FirstOrDefault(todo => todo.Name == tenCanTim);
        if (todo == null) throw new Exception("Todo not found");
        
        return todo;
    }
    
    public IEnumerable<Todo> GetAllTodos()
    {
        return context.Todos;
    }

    public void AddTodo(Todo yvgbhn)
    {
        context.Todos.Add(yvgbhn);
        context.SaveChanges();
    }

    public void DeleteTodo(int id)
    {
        var todo = context.Todos.FirstOrDefault(t => t.Id == id);
        if (todo == null) throw new Exception("Todo not found");
        
        context.Todos.Remove(todo);
        context.SaveChanges();
    }
}