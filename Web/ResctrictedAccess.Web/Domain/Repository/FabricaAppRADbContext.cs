using System.Data.Entity;

namespace ResctrictedAccess.Web.Domain.Repository
{
    public class FabricaAppRADbContext : DbContext
    {
        public DbSet<Admin.Aluno.Model> Alunos { get; set; }
        public DbSet<Admin.Evento.Model> Eventos { get; set; }
        public FabricaAppRADbContext() : base("MySqlConnection")
        {

        }
    }
}