using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_LAB_5.Models
{
    public class AddToRoleModel
    {
        public string Email { get; set; }
        public List<string> roles { get; set; }
        public string selectedRole { get; set; }
        public AddToRoleModel()
        {
            roles = new List<string>();
        }
    }
}