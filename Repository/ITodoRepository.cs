using todo.Entity;

namespace todo.Repository;

public interface ITodoRepository
{
    Todo GetTodoByName(string name);

    IEnumerable<Todo> GetAllTodos();

    void AddTodo(Todo todo);

    void DeleteTodo(int id);
}
