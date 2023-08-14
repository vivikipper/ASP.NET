using System;
using System.ComponentModel.DataAnnotations;
namespace Output_Student_200541042.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Chasis No is required")]
        [Display(Name = "Chasis No")]
        public string ChasisNo { get; set; }

        [Required(ErrorMessage = "Car Name is required")]
        [Display(Name = "Car Name")]
        public string CarName { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Car Type is required")]
        [Display(Name = "Car Type")]
        public string CarType { get; set; }
    }
}
