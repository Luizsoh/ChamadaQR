using ResctrictedAccess.Web.Domain.Repository;

namespace ResctrictedAccess.Web.Domain.Admin
{
    public class Aluno : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public Usuario Usuario { get; set; }
    }
}