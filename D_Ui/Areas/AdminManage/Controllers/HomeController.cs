using D_Ui.Areas.AdminManage.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace D_Ui.Areas.AdminManage.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
