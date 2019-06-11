using System.ComponentModel.DataAnnotations;

namespace DataContext.Entities
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
