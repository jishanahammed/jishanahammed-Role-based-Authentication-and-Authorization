using System.ComponentModel.DataAnnotations;

namespace D_Ui.Models.ViewMode
{
    public class ChangePasswordViewModel
    {
        public string UserId { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Must be between 6 and 10 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Must be between 6 and 10 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Password doesn't match.")]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
