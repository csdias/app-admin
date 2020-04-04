using Microsoft.EntityFrameworkCore;
using AppAdmin.Domain;

namespace AppAdmin.Data
{
    public class AppAdminContext : DbContext
    {
        public DbSet<Administradora> Administradoras { get; set; }
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=app_admin.db");
    }
}