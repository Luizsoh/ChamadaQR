using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResctrictedAccess.Web.Models.Usuarios.Index
{
    public class ViewModel
    {
        public IEnumerable<Domain.Admin.Usuario> Usuarios { get; set; }
    }
}