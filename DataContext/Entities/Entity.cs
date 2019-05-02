using System.ComponentModel.DataAnnotations;

namespace DataContext.Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
