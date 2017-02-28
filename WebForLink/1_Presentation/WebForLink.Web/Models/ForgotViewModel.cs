using System.ComponentModel.DataAnnotations;

namespace WebForLink.Web.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}