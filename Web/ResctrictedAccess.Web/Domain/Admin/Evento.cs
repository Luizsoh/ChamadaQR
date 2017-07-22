namespace ResctrictedAccess.Web.Domain.Admin
{
    using ResctrictedAccess.Web.Domain.Repository;
    using System.Collections.Generic;

    public class Evento : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<QR> QRs { get; set; }
        //public Espaco Espaco { get; set; }
        //public ICollection<Tempo> Tempos { get; set; }
        //public ICollection<Presenca> Presencas { get; set; }
    }
}