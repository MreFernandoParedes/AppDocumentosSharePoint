using Microsoft.EntityFrameworkCore;
using AppDocumentosSharePoint.Models; // Asegúrate que el namespace coincida

namespace AppDocumentosSharePoint.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<PreguntaRespuestaCanonica> PreguntasRespuestasCanonicas { get; set; }
    }
}
