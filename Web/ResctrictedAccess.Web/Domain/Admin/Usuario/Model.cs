namespace ResctrictedAccess.Web.Domain.Admin.Usuario
{
    using System.Collections.Generic;
    public class Model
    {
        public string Codigo { get; set; }
        public string Senha { get; set; }
        public Aluno.Model Aluno { get; set; }
        public ICollection<Perfil.Model> Perfis { get; set; }
    }
}