using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace _200541042.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; } 

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailAddress { get; set; } 

        [Required(ErrorMessage = "Chasis No is required")]
        public string ChasisNo { get; set; }

        [Required(ErrorMessage = "Car Name is required")]
        public string CarName { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Car Type is required")]
        public string CarType { get; set; }
    }
}
