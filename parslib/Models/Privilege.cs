using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace parslib.Models
{
    public class Privilege{
        public int PrivilegeID{get; set;} // primary key
        public string? PrivilegeName {get; set;}
    }
        public class RolePrivilege
    {
        public int RoleID {get; set;} // Primary Key, Foreign Key 1
        public int PrivilegeID {get; set; } // Primary Key, Foreign Key 2
        public Role? Role {get; set;} // Navigation property back to Role
        public Privilege? Privilege{get; set;} // Navigation property back to Privilege
        
    } 
}