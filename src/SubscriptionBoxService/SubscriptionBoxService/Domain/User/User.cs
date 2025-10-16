using Domain.User.ValueObjects;

namespace Domain.User;

public class User
{
    public UserID Id { get; }
    public UserAddress Address { get; }
    public IReadOnlyCollection<UserCredentials.UserCredentials>  Credentials { get; }
    public IReadOnlyCollection<UserProfile.UserProfile>  Profiles { get; }

    public User(
        UserID id,
        UserAddress address,
        IEnumerable<UserCredentials.UserCredentials> credentials,
        IEnumerable<UserProfile.UserProfile> profiles
    )
    {
        Id = id;
        Address = address;
        Credentials = credentials.ToList();
        Profiles = profiles.ToList();
    }
}