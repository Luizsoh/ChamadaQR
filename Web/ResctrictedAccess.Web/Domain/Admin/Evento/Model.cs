namespace ResctrictedAccess.Web.Domain.Admin.Evento
{
    using System.Collections.Generic;

    public class Model
    {
        public string Descricao { get; set; }
        public Usuario.Model Usuario { get; set; }
        public ICollection<Usuario.Model> Usuarios { get; set; }
        public ICollection<QR.Service> QRs { get; set; }
        public Espaco.Model Espaco { get; set; }
        public ICollection<Tempo.Model> Tempos { get; set; }
        public ICollection<Presenca.Model> Presencas { get; set; }
    }
}