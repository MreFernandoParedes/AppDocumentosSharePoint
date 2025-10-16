using Microsoft.EntityFrameworkCore;
using AppDocumentosSharePoint.Models;

namespace AppDocumentosSharePoint.Data
{
    public class AplicDbContext : DbContext
    {
        public AplicDbContext(DbContextOptions<AplicDbContext> options)
            : base(options)
        {
        }

        public DbSet<PreguntaRespuestaCanonica> PreguntasRespuestasCanonicas { get; set; }
    }
}
