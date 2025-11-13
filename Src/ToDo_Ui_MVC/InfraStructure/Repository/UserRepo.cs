
public class UserRepo : IUserRepo
{
   private readonly ToDoDbContext context = new ToDoDbContext();

    public void Create(User user)
    {
        context.Users.Add(user);
        context.SaveChanges();
    }

    public User GetUser(string username, string password)
    {
        return context.Users.FirstOrDefault(u=>u.UserName==username && u.Password == password);
    }
}

