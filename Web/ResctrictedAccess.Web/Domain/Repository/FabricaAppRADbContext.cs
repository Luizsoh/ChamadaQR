using System.Data.Entity;

namespace ResctrictedAccess.Web.Domain.Repository
{
    public class FabricaAppRADbContext : DbContext
    {
        public DbSet<Admin.Aluno> Alunos { get; set; }
        public DbSet<Admin.Evento> Eventos { get; set; }
        public FabricaAppRADbContext() : base("MySqlConnection")
        {

        }
    }
}