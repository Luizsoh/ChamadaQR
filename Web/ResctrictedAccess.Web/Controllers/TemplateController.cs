using System.Web.Mvc;

namespace ResctrictedAccess.Web.Controllers
{
    public class TemplateController : Controller
    {
        // GET: Template
        public ActionResult Index()
        {
            return View();
        }
    }
}