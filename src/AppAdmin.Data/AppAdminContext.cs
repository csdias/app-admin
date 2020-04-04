using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppZelador.Data
{
    public class AppZeladorContext : DbContext
    {
        public DbSet<Administradora> Administradoras { get; set; }
        public DbSet<Condominio> Condominios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=appzelador.db");
    }
}