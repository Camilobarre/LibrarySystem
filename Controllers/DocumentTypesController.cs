using Microsoft.AspNetCore.Mvc;
using LibrarySystem.Data;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

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


        // Metodo index de forma sincrona
        var AllDocumentTypes = _context.DocumentTypes.ToList();
        return View(AllDocumentTypes);
    }

    // Metodo index de forma asincrona
    public async Task<IActionResult> IndexAsync()
    {
        var AllDocumentTypes = await _context.DocumentTypes.ToListAsync();
        return View(AllDocumentTypes);
    }

    [Route("Create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(DocumentType documentType)
    {
        if (ModelState.IsValid)
        {
            _context.Add(documentType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        else
        {
            _logger.LogError("Error Saving");
            return View(documentType);
        }
    }
}
