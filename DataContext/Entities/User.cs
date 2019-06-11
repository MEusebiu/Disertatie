using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataContext.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public DateTime JoinDate { get; set; }

        public ICollection<Review> Reviews { get; set; }
        public ICollection<UserBook> UserBook { get; set; }
    }
}
