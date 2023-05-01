using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Layali.Models
{
    public class Category
    {
        //to make id a primary key in the database we use key annotation
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public  String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
