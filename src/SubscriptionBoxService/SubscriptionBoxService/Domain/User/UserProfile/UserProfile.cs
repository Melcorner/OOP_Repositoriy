using Domain.User.UserProfile.ValueObjects;

namespace Domain.User.UserProfile;

public class UserProfile
{
    public UserName Name { get;}
    public UserSurname Surname { get;}
    public UserDoB DoB { get;}
    public UserEmail Email { get;}

    public UserProfile(
        UserName name,
        UserSurname surname,
        UserDoB dob,
        UserEmail email 
    )
    {
        Name = name;
        Surname = surname;
        DoB = dob;
        Email = email;
    }
}