
public interface ITodoService
{
    void CreateTodo(TodoItem todo);
    void UpdateTodo(TodoItem todo);
    void DeleteTodo(int id);
    List<TodoItem> GetUserTodos(int userId);
    public List<Category> GetCategories();
    public void ToggleComplete(int id);
}

