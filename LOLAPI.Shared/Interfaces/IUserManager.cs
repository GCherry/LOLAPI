using System;
using LOLAPI.Shared.Entities;

namespace LOLAPI.Shared.Interfaces
{
    public interface IUserManager : IManager<UserAccount>
    {
        //bool UserLoggedIn();
        UserAccount GetOneByEmail(string email);
        string GetHashedPassword(string password);
        Boolean LogInUser(UserAccount user);

    }
}
