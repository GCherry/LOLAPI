﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLAPI.Shared.Entities
{
    public class UserAccount : Entity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        public virtual  Champion Champ {get;set;}
    }
}
