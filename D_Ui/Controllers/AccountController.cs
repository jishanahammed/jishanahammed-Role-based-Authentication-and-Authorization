using D_Ui.Models.Data;
using D_Ui.Models.Domain.Auth;
using D_Ui.Models.ViewMode;
using D_Ui.Service.EmailSender;
using D_Ui.Service.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace D_Ui.Controllers
{
    public class AccountController : Controller
    {
        private readonly DuiContext db;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private SignInManager<ApplicationUser> signInManager;
        private ICheckUserContext workContext;
        private IEmailService _eImailService;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            ICheckUserContext workContext, RoleManager<IdentityRole> roleManager, DuiContext db, IEmailService emailService)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.workContext = workContext;
            this.roleManager = roleManager;
            this.db = db;
            _eImailService = emailService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        public IActionResult Registration()
        {
            RegistrationViewModel model = new RegistrationViewModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registration(RegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var isValid = CheckValidEmail(model.Email);
                    if (isValid == false)
                    {
                        model.Email = model.Email + "@gmail.com";
                    }
                    else
                    {
                        model.Email = model.Email;
                    }

                    var exitusr = chackauser(model);
                    if (exitusr)
                    {
                        ApplicationUser user = new ApplicationUser()
                        {
                            FullName = model.FullName,
                            PhoneNumber = model.PhoneNumber,
                            Email = model.Email,
                            Department = model.Department,
                            Designation = model.Designation,
                            EmailConfirmed = true,
                            UserName = model.Email,
                            LockoutEnabled = false,
                            UserType = 2,
                            CreatedOn = DateTime.Now
                        };

                        var result = await userManager.CreateAsync(user, model.Password);
                        if (result.Succeeded)
                        {
                            string roleName = "Candidate";
                            var role = roleManager.FindByNameAsync(roleName).Result;
                            if (role != null)
                            {
                                await userManager.AddToRoleAsync(user, role.Name);
                                return RedirectToAction("Login");
                            }
                        }
                    }
                    ModelState.AddModelError(string.Empty, "this user already exists");
                    return View(model);
                }
                catch (System.Exception)
                {

                    ModelState.AddModelError(string.Empty, "Internal Error");
                    return View(model);
                }

            }
            ModelState.AddModelError(string.Empty, "your required field not fulfilled");
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            string email = "";
            var isValid = CheckValidEmail(login.Email);
            if (isValid == false)
            {
                email = login.Email + "@gmail.com";
            }
            else
            {
                email = login.Email;
            }
            var user = await userManager.FindByEmailAsync(email);
            if (user != null)
            {

                    var result = await signInManager.PasswordSignInAsync(user, login.Password, false, false);
                    if (result.Succeeded)
                    {
                        if (login.ReturnUrl == null)
                        {
                            return Redirect("/Home/Index");
                        }
                        return Redirect(login.ReturnUrl);
                    }
                    if (result.IsNotAllowed)
                    {
                        ModelState.AddModelError(string.Empty, "Email is not verified.");
                        return View(login);
                    }
                

            }
            ModelState.AddModelError(string.Empty, "User not found!");
            return View(login);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            if (signInManager.IsSignedIn(User))
            {
                await signInManager.SignOutAsync();
            }
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Forgottenpassword()
        {
            ForgottenpasswordViewModel model = new ForgottenpasswordViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Forgottenpassword(ForgottenpasswordViewModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var token = await userManager.GeneratePasswordResetTokenAsync(user);
                var link = Url.Action(nameof(ResetPassword), "Account", new { uId = user.Id, barcode = token }, Request.Scheme, Request.Host.ToString());
                sentEmailContact(model, link);
                ModelState.AddModelError("Email", "Check Email.");
                return View(model);
            }
            ModelState.AddModelError("Email", "There is no account assosiated with this email.");
            return View(model);

        }
        public void sentEmailContact(ForgottenpasswordViewModel model,string link)
        {
            MaileRequst maileRequst = new MaileRequst();
            maileRequst.ToEmail =model.Email;
            maileRequst.Subject = "Reset Password";
            maileRequst.Body =
          "<!DOCTYPE html>" +
          "<html>" +
          "<head>" +
          "<title>Uapp</title>" +

          "<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css\" integrity=\"sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk\" crossorigin=\"anonymous\">" +

          "</head>" +
         "<body>" +
        "</div>" +
        "<div style=\"padding: 10px 0px 10px 0px\">" +
        "<p>Dear Admin,</p>" +
       
        "<p>Please click on the link to reset your password.</p>" +
        "<br>"+
       "<p>  " +link+ " </p>" +
         "<br/>" +
         "<p> or </p>" +
    " <button style=\" color: #fff;background-color:#1b6ec2;\" class=\"btn btn-success\"><a href=\""+link+"\">lick Here</a></button>"+
        "</div>" +
        "</body>" +
        "</html>";


         var result= _eImailService.SendEmailAsync(maileRequst);

        }
        [HttpGet]
        public IActionResult ResetPassword(string uId, string barcode)
        {
            ResetPasswordViewModel recover = new ResetPasswordViewModel();
            recover.UserId = uId;
            recover.Token = barcode;
            return View(recover);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPasswordConfirm(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.UserId);
                var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }
               
            }
            return View();
        }
        private bool CheckValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool chackauser(RegistrationViewModel model)
        {
            var exituser = userManager.FindByEmailAsync(model.Email).Result;
            if (exituser == null)
            {

                return true;
            }
            return false;
        }
    }
}
