using System;

namespace domain.Models
{
    public class User{
        public int UserID{get; set;}
        public int Password{get; set;}
        public Profile? Profile { get; set; }

    }
}