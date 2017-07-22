namespace ResctrictedAccess.Web.Domain.Admin
{
    using ResctrictedAccess.Web.Domain.Repository;
    using System.Collections.Generic;
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public Aluno Aluno { get; set; }
        public ICollection<Perfil> Perfis { get; set; }
    }
}