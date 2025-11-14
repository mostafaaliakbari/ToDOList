

public class ToDoService : ITodoService
{
    private readonly TodoRepo _todoRepo = new TodoRepo();
    public void CreateTodo(TodoItem todo)
    {
        _todoRepo.Create(todo);
    }

    public void DeleteTodo(int id)
    {
        _todoRepo.Delete(id);
    }

    public List<Category> GetCategories()
    {
        return _todoRepo.GetAll();
    }

    public List<TodoItem> GetUserTodos(int userId)
    {
        return _todoRepo.GetUserTodos(userId);
    }

    public void ToggleComplete(int id)
    {
        var todo = _todoRepo.GetById(id);
        todo.IsCompleted = !todo.IsCompleted;
        _todoRepo.Update(todo);
    }

    public void UpdateTodo(TodoItem todo)
    {
        _todoRepo.Update(todo);
    }
}

