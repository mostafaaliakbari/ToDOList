
using Microsoft.EntityFrameworkCore;

public class UserRepo : IUserRepo
{
    private readonly ToDoDbContext context;
    public UserRepo(ToDoDbContext toDoDbContext)
    {
        context = toDoDbContext;
    }

    public void Create(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
    }

    public User GetUser(string username, string password)
    {
        return context.Users.FirstOrDefault(u=>u.UserName==username && u.Password == password);
    }














    public User GetById(int id)
    {
        return context.Users.Find(id);
    }
}

