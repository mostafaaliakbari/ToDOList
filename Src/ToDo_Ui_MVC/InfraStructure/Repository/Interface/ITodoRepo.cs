
public interface ITodoRepo
{
    void Create(TodoItem todo);
    void Update(TodoItem todo);
    void Delete(int id);
    List<TodoItem> GetUserTodos(int userId);
    TodoItem GetById(int id);
    public List<Category> GetAll();
}


