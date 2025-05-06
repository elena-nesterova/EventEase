public class UserSessionService
{
    public UserModel? CurrentUser { get; private set; }

    public void Login(UserModel user)
    {
        CurrentUser = user;
    }

    public void Logout()
    {
        CurrentUser = null;
    }

    public bool IsLoggedIn => CurrentUser != null;
}