﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Aud_Albums.Models
{
    public class AddToRoleModel
    {
        public string Email { get; set; }
        public string selectedRole { get; set; }
        public List<string> roles { get; set; }
        public AddToRoleModel()
        {
            roles = new List<string>();
        }
    }
}