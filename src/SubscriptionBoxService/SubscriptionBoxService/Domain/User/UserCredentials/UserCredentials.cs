using Domain.User.UserCredentials.ValueObjects;

namespace Domain.User.UserCredentials;

public class UserCredentials
{
    public UserLogin Login { get;}
    public UserPassword Password { get;}

    public UserCredentials(UserLogin login, UserPassword password)
    {
        Login = login;
        Password = password;
    }
}