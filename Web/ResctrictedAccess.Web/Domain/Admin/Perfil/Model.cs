﻿namespace ResctrictedAccess.Web.Domain.Admin.Perfil
{
    using System.Collections.Generic;
    public class Model
    {
        public string Nome { get; set; }
        ICollection<Usuario.Model> Usuarios { get; set; }
    }
}