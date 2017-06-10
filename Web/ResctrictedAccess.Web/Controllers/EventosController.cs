using ResctrictedAccess.Web.Domain.Repository;
using System.Linq;
using System.Web.Mvc;

namespace ResctrictedAccess.Web.Controllers
{
    public class EventosController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new FabricaAppRADbContext())
                return View(new Models.Eventos.Index.ViewModel { Eventos = db.Eventos.ToArray() });
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Eventos.Create.ViewModel model)
        {
            using (var db = new FabricaAppRADbContext())
            {
                db.Eventos.Add(new Domain.Admin.Evento
                {
                    Nome = model.Nome
                });
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}