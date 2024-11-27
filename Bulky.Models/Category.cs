using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]

        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1, 100)]
        //For custom error message
        //[Range(1, 100, ErrorMessage="Custom msg here")]
        public int DisplayOrder { get; set; }
    }
}
