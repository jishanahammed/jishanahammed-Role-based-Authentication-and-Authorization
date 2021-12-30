using System;
using System.ComponentModel.DataAnnotations;

namespace D_Ui.Models.ViewMode
{
    public class RegistrationViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Must be between 6 and 10 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]      
        [StringLength(10, ErrorMessage ="Password doesn't match.")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Designation")]
        public string Designation { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string Department { get; set; }
        [Required]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        public int UserType { get; set; }
        public DateTime CreatedOn { get; set; }
        public string date { get; set; }
    }
}
