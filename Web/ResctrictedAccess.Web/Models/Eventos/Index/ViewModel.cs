using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResctrictedAccess.Web.Models.Eventos.Index
{
    public class ViewModel
    {
        public IEnumerable<Domain.Admin.Evento.Model> Eventos { get; set; }
    }
}