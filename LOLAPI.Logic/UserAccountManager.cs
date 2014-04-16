using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Shared.Entities;
using LOLAPI.Data;

namespace LOLAPI.Logic
{
    public class UserAccountManager : IUserManager
    {

        private LoLDBContext _lolDBContext = new LoLDBContext();

        public List<UserAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserAccount GetOneById(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount Add(UserAccount item)
        {
            throw new NotImplementedException();
        }

        public UserAccount EditById(UserAccount item, int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
