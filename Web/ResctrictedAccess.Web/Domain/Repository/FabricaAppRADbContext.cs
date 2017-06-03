using System.Data.Entity;

namespace ResctrictedAccess.Web.Domain.Repository
{
    public class FabricaAppRADbContext : DbContext
    {
        public DbSet<Admin.Aluno.Model> Alunos { get; set; }
        public FabricaAppRADbContext() : base("MySqlConnection")
        {

        }
    }
}