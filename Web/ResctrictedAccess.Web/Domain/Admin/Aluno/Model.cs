namespace ResctrictedAccess.Web.Domain.Admin.Aluno
{
    public class Model
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public Usuario.Model Usuario { get; set; }
    }
}