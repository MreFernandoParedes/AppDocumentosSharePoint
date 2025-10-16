using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppDocumentosSharePoint.Data; // Reemplaza con el namespace real de tu DbContext
using AppDocumentosSharePoint.Models; // Reemplaza con el namespace real de tu modelo

public class QAController : Controller
{
    private readonly AplicDbContext _context;

    public QAController(AplicDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var lista = await _context.PreguntasRespuestasCanonicas
            .Where(p => p.Vigente == true)
            .OrderByDescending(p => p.FechaRegistro)
            .ToListAsync();

        return View(lista);
    }
}
