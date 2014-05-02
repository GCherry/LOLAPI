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

        public string GetHashedPassword(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        public bool LogInUser(UserAccount user)
        {

            UserAccount checkUser = GetOneByEmail(user.Email);

            if (checkUser == null)
            {
                return false;
            }
            else
            {
                
                //Hash the passed in password and check if they match
                string checkPassword = GetHashedPassword(user.Password);

                if (checkPassword == checkUser.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
    }
}
