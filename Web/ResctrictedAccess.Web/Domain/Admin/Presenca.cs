using ResctrictedAccess.Web.Domain.Repository;

namespace ResctrictedAccess.Web.Domain.Admin
{
    public class Presenca : IEntity
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Evento Evento { get; set; }
        public Tempo Tempo { get; set; }
    }
}