using System.ComponentModel.DataAnnotations;

namespace D_Ui.Models.ViewMode
{
    public class ForgottenpasswordViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
