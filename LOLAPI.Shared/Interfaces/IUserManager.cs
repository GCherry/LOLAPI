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
    }
}
