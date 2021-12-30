using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace D_Ui.Areas.AdminManage.Components
{
    public class CafeteriaSidbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
