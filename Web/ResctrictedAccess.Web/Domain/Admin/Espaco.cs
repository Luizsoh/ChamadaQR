namespace ResctrictedAccess.Web.Domain.Admin
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Espaco
    {
        public string Nome { get; set; }
        ICollection<Evento> Eventos { get; set; }
    }
}