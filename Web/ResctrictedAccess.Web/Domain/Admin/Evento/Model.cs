namespace ResctrictedAccess.Web.Domain.Admin.Evento
{
    using System.Collections.Generic;

    public class Model
    {
        public Model()
        {
            QRs = new HashSet<QR.Model>();
            Espacos = new HashSet<Espaco.Model>();
            Tempos = new HashSet<Tempo.Model > ();
            Presencas = new HashSet<Presenca.Model>();
        }
        public string Descricao { get; set; }
        public ICollection<QR.Model> QRs { get; set; }
        public ICollection<Espaco.Model> Espacos { get; set; }
        public ICollection<Tempo.Model> Tempos { get; set; }
        public ICollection<Presenca.Model> Presencas { get; set; }
    }
}