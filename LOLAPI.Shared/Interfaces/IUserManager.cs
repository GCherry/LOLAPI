using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
