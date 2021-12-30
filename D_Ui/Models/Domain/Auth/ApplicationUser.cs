using Microsoft.AspNetCore.Identity;
using System;

namespace D_Ui.Models.Domain.Auth
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public int UserType { get; set; }
        public DateTime CreatedOn { get; set; }
    }

}
