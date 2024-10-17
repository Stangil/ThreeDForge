using System.ComponentModel.DataAnnotations;
using ThreeDForge.Domain.Enums;

namespace ThreeDForge.Domain.Entities
{
    public class Item
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Please provide a product name")]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [MaxLength(300)]
        public string? Description { get; set; }
        public DateTime? AddedDate { get; set; }
        [EnumDataType(typeof(Category), ErrorMessage = "Please select a category")]
        public Category Category { get; set; }
        public decimal Price { get; set; }
       
    }
}
