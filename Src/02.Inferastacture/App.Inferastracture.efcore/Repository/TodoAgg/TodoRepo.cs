

using Microsoft.EntityFrameworkCore;

public class TodoRepo : ITodoRepo
{
    private readonly ToDoDbContext _dbContext;
    public TodoRepo(ToDoDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void Create(TodoItem todo)
    {
        todo.CreatedDate = DateTime.Now;
        _dbContext.Add(todo);
        _dbContext.SaveChanges();

    }

    

    public void Delete(int id)
    {
        var todoitem = _dbContext.TodoItems.Find(id);
        if (todoitem != null)
        {
            _dbContext.Remove(todoitem);
            _dbContext.SaveChanges();
        }
    }

    public TodoItem GetById(int id)
    {
        return _dbContext.TodoItems.Include(t => t.Category).FirstOrDefault(t => t.Id == id);
    }

    public List<TodoItem> GetUserTodos(int userId)
    {
        return _dbContext.TodoItems
            .Include(t => t.Category)
            .Where(t => t.UserId == userId)
            .OrderByDescending(t => t.CreatedDate)
            .ToList();
    }

    public void Update(TodoItem todo)
    {
        _dbContext.TodoItems.Update(todo);
        _dbContext.SaveChanges();
    }
    public List<Category> GetAll()
    {
        return _dbContext.Categories
            .OrderBy(c => c.Title)
            .ToList();
    }





}

