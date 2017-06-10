namespace ResctrictedAccess.Web.Domain.Admin
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string RA { get; set; }
        public Usuario Usuario { get; set; }
    }
}