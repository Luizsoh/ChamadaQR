namespace ResctrictedAccess.Web.Domain.Admin
{
    using System.Collections.Generic;
    public class Perfil
    {
        public string Nome { get; set; }
        ICollection<Usuario> Usuarios { get; set; }
    }
}