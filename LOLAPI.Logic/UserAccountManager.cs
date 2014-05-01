using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LOLAPI.Shared.Interfaces;
using LOLAPI.Shared.Entities;
using LOLAPI.Data;
using System.Security.Cryptography;

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
            //Create a new item
            UserAccount user = new UserAccount()
            {
                UserName = item.UserName,
                Email = item.Email,
                Password = item.Password,
                Active = true
            };
            
            _lolDBContext.UserAccounts.Add(user);
            _lolDBContext.SaveChanges();

            return user;
        }

        public UserAccount EditById(UserAccount item, int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount GetOneByEmail(string email)
        {

            UserAccount user = _lolDBContext.UserAccounts.SingleOrDefault(u => u.Email == email);

            return user;
        }
    }
}
