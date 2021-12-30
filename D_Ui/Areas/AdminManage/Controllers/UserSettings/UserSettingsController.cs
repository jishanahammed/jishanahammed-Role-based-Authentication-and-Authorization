using D_Ui.Areas.AdminManage.Controllers.Base;
using D_Ui.Models.Data;
using D_Ui.Models.Domain.Auth;
using D_Ui.Models.ViewMode;
using D_Ui.Service.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Ui.Areas.AdminManage.Controllers.UserSettings
{
    [Authorize(Roles = "Admin")]
    public class UserSettingsController : BaseController
    {
        private readonly DuiContext db;
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;
        private SignInManager<ApplicationUser> signInManager;
        private ICheckUserContext workContext;
        public UserSettingsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            ICheckUserContext workContext, RoleManager<IdentityRole> roleManager, DuiContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.workContext = workContext;
            this.roleManager = roleManager;
            this.db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = db.Users.Where(u=>u.UserType==1).ToList();
            List<RegistrationViewModel> models = new List<RegistrationViewModel>();
            foreach (var item in user)
            {
                RegistrationViewModel model = new RegistrationViewModel()
                {
                    Id=item.Id,
                    FullName = item.FullName,
                    Email = item.Email,
                    PhoneNumber=item.PhoneNumber,
                    date=item.CreatedOn.ToLongDateString(),
                    Designation=item.Designation,
                    Department=item.Department,
                    RoleName=findRole(item.Id),

                };
                models.Add(model);
            }
            return View(models);
        }

        private dynamic findRole(string id)
        {
            string rolename = "";
            var user = db.UserRoles.FirstOrDefault(g=>g.UserId==id).RoleId;
            if (user != null)
            {
                rolename = db.Roles.FirstOrDefault(d => d.Id == user).Name;
                return rolename;
            }
            return rolename = "";
        }

        private dynamic findRoleId(string id)
        {
            string rolename = "";
            var user = db.UserRoles.FirstOrDefault(g => g.UserId == id).RoleId;
            if (user != null)
            {
                rolename = db.Roles.FirstOrDefault(d => d.Id == user).Id;
                return rolename;
            }
            return rolename = "";
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.taList= new SelectList(( db.Roles.Where(s=>s.Name!= "Candidate")).Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            return View(new RegistrationViewModel() { });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RegistrationViewModel model)
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
                            UserType = 1,
                            CreatedOn = DateTime.Now
                        };

                        var result = await userManager.CreateAsync(user, model.Password);
                        if (result.Succeeded)
                        {
                            var role = roleManager.FindByIdAsync(model.RoleName).Result;
                            if (role != null)
                            {
                                await userManager.AddToRoleAsync(user, role.Name);
                                return RedirectToAction("Index");
                            }
                        }
                    }
                    ModelState.AddModelError(string.Empty, "this user already exists");
                    return View();
                }
                catch (System.Exception)
                {

                    ModelState.AddModelError(string.Empty, "Internal Error");
                    return View();
                }

            }
            ModelState.AddModelError(string.Empty, "your required field not fulfilled");
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var model = await userManager.FindByIdAsync(id);
            RegistrationViewModel user = new RegistrationViewModel()
            {
                Id =model.Id,
                FullName = model.FullName,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Department = model.Department,
                Designation = model.Designation,
                RoleName= findRoleId(model.Id),
            };
            ViewBag.taList = new SelectList((db.Roles.Where(s => s.Name != "Candidate")).Select(s => new { Id = s.Id, Name = s.Name }), "Id", "Name");
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(RegistrationViewModel model)
        {
        
                try
                {


                var exitusr = db.Users.FirstOrDefault(d => d.Email == model.Email && d.Id != model.Id);
                    if (exitusr==null)
                    {
                          
                    var user =  userManager.FindByIdAsync(model.Id).Result;
                           user.FullName = model.FullName;
                           user.PhoneNumber = model.PhoneNumber;
                            user.Email = model.Email;
                            user.Department = model.Department;
                            user.Designation = model.Designation;
                            user.UserName = model.Email;
                            user.LockoutEnabled = false;
                        var result = await userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                        var curentname = findRole(user.Id);
                        var role = roleManager.FindByIdAsync(model.RoleName).Result;
                            if (role != null)
                            {
                            await userManager.RemoveFromRoleAsync(user, curentname);
                            await userManager.AddToRoleAsync(user, role.Name);
                                return RedirectToAction("Index");
                            }
                        }
                        ModelState.AddModelError(string.Empty, "Internal Error");
                        return View();
                }
                    ModelState.AddModelError(string.Empty, "this user already exists");
                    return View();
                }
                catch (System.Exception)
                {
                    ModelState.AddModelError(string.Empty, "Internal Error");
                    return View();
                }                
          }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ChangePassword(string id)
        {
            ChangePasswordViewModel model = new ChangePasswordViewModel();
            model.UserId = id;
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {

                var user = await userManager.FindByIdAsync(model.UserId);
                if (user!=null)
                {
                    var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "User Not Fount");
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
