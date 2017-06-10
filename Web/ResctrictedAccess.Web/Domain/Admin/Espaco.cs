namespace ResctrictedAccess.Web.Domain.Admin
{
    using ResctrictedAccess.Web.Domain.Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class Espaco : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        ICollection<Evento> Eventos { get; set; }
    }
}