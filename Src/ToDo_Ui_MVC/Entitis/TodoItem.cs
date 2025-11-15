
public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public Category Category { set; get; }
    public DateTime? DueDate { get; set; }
    public int CategoryId { get; set; }
    public ToDoStatus status { get; set; }
}

public enum ToDoStatus
{
    Pending = 1,   
    Completed,      
    Overdue
}