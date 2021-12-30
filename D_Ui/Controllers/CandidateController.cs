using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace D_Ui.Controllers
{
    [Authorize(Roles = "Candidate")]
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
