﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterCareBackend.Models
{
    public class User: IUser
    {
        public String Email { get; set; }
        public String Password { get; set; }
        public String FullName { get; set;}
        public int AccessLevel { get; set; }

        public void Login()
        {
            // To be implemented.
            throw new NotImplementedException();
        }

        public void Logout()
        {
            // To be implemented.
            throw new NotImplementedException();
        }
    }
}