using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TESTE_VIVIANI.Models
{
    public class TesteViviani
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string? EmailAddress { get; set; }
    }
}
