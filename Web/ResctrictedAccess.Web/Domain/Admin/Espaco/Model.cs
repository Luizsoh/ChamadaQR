namespace ResctrictedAccess.Web.Domain.Admin.Espaco
{
    using System.Collections.Generic;

    public class Model
    {
        public string Nome { get; set; }
        ICollection<Evento.Model> Eventos { get; set; }
    }
}