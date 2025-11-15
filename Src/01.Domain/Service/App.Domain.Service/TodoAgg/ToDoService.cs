

public class ToDoService : ITodoService
{
    private readonly ITodoRepo _todoRepo;
    public ToDoService(ITodoRepo todoRepo)
    {
        _todoRepo = todoRepo;
    }
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
        var todos = _todoRepo.GetUserTodos(userId);
        foreach (var todo in todos)
        {
            todo.status = CalculateStatus(todo);
        }
        return todos;
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
    public ToDoStatus CalculateStatus(TodoItem todo)
    {
        if (todo.IsCompleted)
            return ToDoStatus.Completed;

        if (todo.DueDate.HasValue && todo.DueDate.Value < DateTime.Now)
            return ToDoStatus.Overdue;

        return ToDoStatus.Pending;
    }
}

