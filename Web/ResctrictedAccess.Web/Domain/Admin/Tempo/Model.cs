namespace ResctrictedAccess.Web.Domain.Admin.Tempo
{
    using System;
    using System.Collections.Generic;

    public class Model
    {
        public DateTime Valor { get; set; }
        public ICollection<Evento.Model> Eventos { get; set; }
        ICollection<Usuario.Model> Usuarios { get; set; }
        ICollection<Presenca.Model> Presencas { get; set; }
    }
}