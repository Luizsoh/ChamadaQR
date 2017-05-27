namespace ResctrictedAccess.Web.Domain.Admin.Espaco
{
    using System.Collections.Generic;

    public class Model
    {
        public Model()
        {
            Eventos = new HashSet<Evento.Model>();
        }
        public string Nome { get; set; }
        ICollection<Evento.Model> Eventos { get; set; }
    }
}