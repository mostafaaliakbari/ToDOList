
public class UserService : IUserService
{
    private readonly IUserRepo _userRepo = new UserRepo();
    public User Login(string username, string password)
    {
        return _userRepo.GetUser(username, password);
    }

    public void Register(User user)
    {
        _userRepo.Create(user);
    }
}

