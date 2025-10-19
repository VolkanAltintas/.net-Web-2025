using System.ComponentModel.DataAnnotations;

namespace Week4App.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Material name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter quantity")]
        [Range(1, 10000, ErrorMessage = "Quantity must be between 1 and 10000")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Unit price is required")]
        [Range(0.01, 99999.99, ErrorMessage = "Price must be positive")]
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Supplier Name")]
        [Required(ErrorMessage = "Supplier is required")]
        public string Supplier { get; set; }

        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime? PurchaseDate { get; set; }
    }
}
