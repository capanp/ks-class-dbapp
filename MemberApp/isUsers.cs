using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;

namespace MemberApp
{
    public class isUsers
    {
        private static isUsers instance;
        private List<Users> users;

        public isUsers()
        {
            users = new List<Users>();
        }

        public static isUsers Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new isUsers();
                }
                return instance;
            }
        }

        public bool IsUserRegistered(string email, string password)
        {
            foreach (var user in users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true; // Kullanıcı ve şifre doğru
                }
            }
            return false; // Kullanıcı veya şifre yanlış
        }

        public void AddUser(string email, string password)
        {
            users.Add(new Users(email, password));
        }
    }
}
