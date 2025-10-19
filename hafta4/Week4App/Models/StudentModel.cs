namespace Week4App.Models;
using System.ComponentModel.DataAnnotations;

public class StudentModel
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(50, ErrorMessage = "Name must be at most 50 characters")]
    public string Name { get; set; }

    [Range(18, 60, ErrorMessage = "Age must be between 18 and 60")]
    public int? Age { get; set; }

    [Required, EmailAddress(ErrorMessage = "Please enter a valid email")]
    public string Email { get; set; }

    [Display(Name = "Enroll Date")]
    [DataType(DataType.Date)]
    public DateTime? EnrollDate { get; set; }
}
