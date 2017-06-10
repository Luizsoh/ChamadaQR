using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResctrictedAccess.Web.Controllers
{
    public class SimulacaoController : Controller
    {
        public static ICollection<ControleEvento> ControlesEventos { get; set; }
        static SimulacaoController()
        {
            ControlesEventos = new Collection<ControleEvento>();
        }

        public ActionResult Qr()
        {
            var controleEvento = ControleEvento.CriarNovo();
            ControlesEventos.Add(controleEvento);
            return View(controleEvento);
        }

        [HttpPost]
        public JsonResult Limpar()
        {
            ControlesEventos = ControlesEventos.Where(x => !x.FoiUtilizado).ToList();
            return Json("Lista Limpa!");

        }

        [HttpPost]
        public JsonResult Ler(int Id)
        {
            var query = ControlesEventos.Where(x => x.Alvo.GetHashCode() == Id);

            if (query.Any(x => x.FoiUtilizado))
                return Json("QR já utilizado!");

            query.ToList().ForEach(x => { x.FoiUtilizado = true; });
            return Json("Lido com Sucesso!");

        }

        [HttpPost]
        public JsonResult Sincronizar(int Id)
        {
            var query = ControlesEventos.Where(x => x.Alvo.GetHashCode() == Id);
            if (!query.Any() || query.Any(x => x.FoiUtilizado))
            {
                var controleEvento = ControleEvento.CriarNovo();
                ControlesEventos.Add(controleEvento);
                return Json(new { Mensagem = "QR Alterado!", Model = controleEvento });
            }

            return Json(new { Mensagem = "QR Disponível!" });
        }


        public class ControleEvento
        {
            public Evento Alvo { get; set; }
            public bool FoiUtilizado { get; set; }
            public string QRCodeStringEmBase64
            {
                get
                {
                    return Convert.ToBase64String(Alvo.CriarQrCode());
                }
            }

            public static ControleEvento CriarNovo()
            {
                return new ControleEvento()
                {
                    FoiUtilizado = false,
                    Alvo = Evento.CriarNovo()
                };
            }

        }

        public class Evento
        {
            public int IdentificadorUnico { get { return GetHashCode(); } }
            public string Nome { get; set; }
            public DateTime Inicio { get; set; }
            public DateTime Termino { get; set; }
            public byte[] CriarQrCode()
            {
                Evento evento = this;
                string texto = evento.TranformarEmStringJSON();
                byte[] r = Domain.Admin.QR.Criar(texto);
                return r;
            }

            public string TranformarEmStringJSON()
            {
                Evento evento = this;
                return Newtonsoft.Json.JsonConvert.SerializeObject(evento);
            }

            public static Evento CriarNovo()
            {
                return new Evento()
                {
                    Nome = "Fábrica de aplicativos",
                    Inicio = DateTime.Now,
                    Termino = DateTime.Now.AddHours(4)
                };
            }
        }
    }
}