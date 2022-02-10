using System.ComponentModel.DataAnnotations;

namespace CoreRESTAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Unit { get; set; }
    }
}