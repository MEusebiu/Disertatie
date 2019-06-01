using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataContext.Entities
{
    public class Book : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Release { get; set; }


        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        public virtual Genre Genre { get; set; }


        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }

        public ICollection<Review> Reviews { get; set; }
       
    }
}
