namespace ResctrictedAccess.Web.Domain.Admin
{
    using ResctrictedAccess.Web.Domain.Repository;
    using System.Collections.Generic;
    public class Perfil : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        ICollection<Usuario> Usuarios { get; set; }
    }
}