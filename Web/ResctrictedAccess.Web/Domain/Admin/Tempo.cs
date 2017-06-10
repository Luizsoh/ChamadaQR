namespace ResctrictedAccess.Web.Domain.Admin
{
    using System;
    using System.Collections.Generic;

    public class Tempo
    {
        public DateTime Valor { get; set; }
        public ICollection<Evento> Eventos { get; set; }
        ICollection<Usuario> Usuarios { get; set; }
        ICollection<Presenca> Presencas { get; set; }
    }
}