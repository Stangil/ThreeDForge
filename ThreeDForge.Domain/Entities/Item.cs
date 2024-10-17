using System.ComponentModel.DataAnnotations;
using ThreeDForge.Domain.Enums;

namespace ThreeDForge.Domain.Entities
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        public DateTime AddedDate { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        [Required]
        [MaxLength(300)]
        public string? Description { get; set; }
    }
}
