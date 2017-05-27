namespace ResctrictedAccess.Web.Domain.Admin.Tempo
{
    using System;
    using System.Collections.Generic;

    public class Model
    {
        public Model()
        {
            Eventos = new HashSet<Evento.Model>();
            Usuarios = new HashSet<Usuario.Model>();
            Presencas = new HashSet<Presenca.Model>();
            QRs = new HashSet<QR.Model>();
        }
        public DateTime Valor { get; set; }
        public ICollection<Evento.Model> Eventos { get; set; }
        public ICollection<Usuario.Model> Usuarios { get; set; }
        public ICollection<Presenca.Model> Presencas { get; set; }
        public ICollection<QR.Model> QRs { get; set; }
    }
}