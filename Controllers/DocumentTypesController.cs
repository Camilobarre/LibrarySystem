using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Data;

namespace LibrarySystem.Controllers;
[Route("[controller]")]
public class DocumentTypesController : Controller
{
    private readonly ILogger<DocumentTypesController> _logger;

    private readonly AppDbContext _context;

    public DocumentTypesController(ILogger<DocumentTypesController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        // _logger nos ayuda a imprimir en consola
        _logger.LogInformation("Llego al controlador");
        _logger.LogDebug("Llego al controlador");
        _logger.LogWarning("Llego al controlador");
        _logger.LogError("Llego al controlador");
        _logger.LogCritical("Llego al controlador");

        var acaVaAQuedarTodosLosTiposDeDocumentos = _context.DocumentTypes.ToList();
        return View(acaVaAQuedarTodosLosTiposDeDocumentos);
    }
}
