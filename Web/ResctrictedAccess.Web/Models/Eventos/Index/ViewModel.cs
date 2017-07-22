namespace ResctrictedAccess.Web.Models.Eventos.Index
{
    using System.Collections.Generic;
    public class ViewModel
    {
        public IEnumerable<Domain.Admin.Evento> Eventos { get; set; }
    }
}