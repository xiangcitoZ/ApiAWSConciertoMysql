using ApiAWSConciertoMysql.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAWSConciertoMysql.Data
{
    public class ConciertosContext : DbContext
    {
        public ConciertosContext(DbContextOptions<ConciertosContext> options)
            : base(options) { }
        public DbSet<CategoriaEvento> CategoriaEventos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }

    }
}
