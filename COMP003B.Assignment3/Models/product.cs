using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment3.Models
{
    public class product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="ID")]
        public string Name { get; set; }
        [Required]
        [Range(0,100)]
        public int Price { get; set; }
    }
}
