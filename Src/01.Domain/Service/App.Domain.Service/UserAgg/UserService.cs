
public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;
    public UserService(IUserRepo userRepo )
    {
        _userRepo = userRepo;
    }
    public User Login(string username, string password)
    {
        return _userRepo.GetUser(username, password);
    }

    public void Register(User user)
    {
        _userRepo.Create(user);
    }






    public User GetUserById(int id)
    {
        return _userRepo.GetById(id);
    }
}

