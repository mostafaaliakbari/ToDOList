public interface IUserRepo
{
    public User GetUser(string username,string password);
    public void Create(User user);
}


