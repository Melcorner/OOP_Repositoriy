using Domain.User.ValueObjects;
using Domain.User.UserCredentials.ValueObjects;
using Domain.User.UserProfile.ValueObjects;

namespace Domain.User;

public sealed class User
{
    public UserID Id { get; }
    public UserAddress Address { get; }
    public UserCredentials.UserCredentials Credentials { get; }
    public UserProfile.UserProfile Profiles { get; }

    public User(
        UserID id,
        UserAddress address,
        UserLogin login,
        UserPassword password,
        UserDoB doB,
        UserEmail email,
        UserName name,
        UserSurname surname
    )
    {
        Id = id;
        Address = address;
        Credentials = new UserCredentials.UserCredentials(login, password);
        Profiles = new UserProfile.UserProfile(name, surname, doB, email);
    }
}