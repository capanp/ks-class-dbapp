﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberApp
{
    public class Users
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Users(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
