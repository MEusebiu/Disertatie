using System;
using System.Collections.Generic;

namespace DataContext.Entities
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<UserBook> UserBook { get; set; }
    }
}
