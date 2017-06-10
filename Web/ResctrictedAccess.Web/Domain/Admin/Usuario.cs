namespace ResctrictedAccess.Web.Domain.Admin
{
    using System.Collections.Generic;
    public class Usuario
    {
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public Aluno Aluno { get; set; }
        public ICollection<Perfil> Perfis { get; set; }
    }
}