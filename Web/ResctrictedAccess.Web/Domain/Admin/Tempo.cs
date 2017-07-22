namespace ResctrictedAccess.Web.Domain.Admin
{
    using ResctrictedAccess.Web.Domain.Repository;
    using System;
    using System.Collections.Generic;

    public class Tempo : IEntity
    {
        public int Id { get; set; }
        public DateTime Valor { get; set; }
        public ICollection<Evento> Eventos { get; set; }
        ICollection<Usuario> Usuarios { get; set; }
        ICollection<Presenca> Presencas { get; set; }
    }
}