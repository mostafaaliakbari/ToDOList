
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public List<TodoItem> TodoItems { get; set; }
}

