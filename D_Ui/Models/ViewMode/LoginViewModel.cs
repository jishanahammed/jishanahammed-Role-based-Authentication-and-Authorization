using System.ComponentModel.DataAnnotations;

namespace D_Ui.Models.ViewMode
{
    public class LoginViewModel
    {
        public long Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
