namespace ResctrictedAccess.Web.Domain.Admin
{
    using System.Collections.Generic;

    public class Evento
    {
        public string Descricao { get; set; }
        public Usuario Usuario { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }
        public ICollection<QR> QRs { get; set; }
        public Espaco Espaco { get; set; }
        public ICollection<Tempo> Tempos { get; set; }
        public ICollection<Presenca> Presencas { get; set; }
    }
}