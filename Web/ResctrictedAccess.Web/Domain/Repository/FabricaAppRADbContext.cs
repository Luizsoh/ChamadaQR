using System.Data.Entity;

namespace ResctrictedAccess.Web.Domain.Repository
{
    public class FabricaAppRADbContext : DbContext
    {
        //public DbSet<Admin.Aluno> Alunos { get; set; }
        public DbSet<Admin.Evento> Eventos { get; set; }
        public FabricaAppRADbContext() : base("MySqlConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Admin.Aluno>().ToTable("aluno");
            //modelBuilder.Entity<Admin.Tempo>().ToTable("Tempo");
            modelBuilder.Entity<Admin.Evento>().ToTable("evento");
            modelBuilder.Entity<Admin.QR>().ToTable("qr_code");
            //modelBuilder.Entity<Admin.Evento>().ToTable("evento");
            //modelBuilder.Entity<Admin.Presenca>().ToTable("presenca");


            //modelBuilder.Entity<Admin.Aluno>().HasOptional(x => x.Usuario).WithRequired(x => x.Aluno).Map(x => x.MapKey("usuario_id"));
            modelBuilder
                .Entity<Admin.Evento>()
                .Property(x => x.Nome)
                .HasColumnName("nome");

            base.OnModelCreating(modelBuilder);
        }
    }
}