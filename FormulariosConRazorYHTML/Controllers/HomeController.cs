using System.Diagnostics;
using FormulariosConRazorYHTML.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FormulariosConRazorYHTML.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly equiposDbContext _equiposDbContext;

        public HomeController(ILogger<HomeController> logger, equiposDbContext equiposDbContext)
        {
            _logger = logger;
            _equiposDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            List<SelectListItem> listaMarcas;
            
            try
            {
                // Intentar obtener las marcas desde la base de datos
                listaMarcas = _equiposDbContext.marcas
                    .Select(m => new SelectListItem
                    {
                        Value = m.id.ToString(),
                        Text = m.nombre_marca
                    })
                    .ToList();
                
                // Si no hay registros, inicializar una lista vacía
                if (listaMarcas == null || !listaMarcas.Any())
                {
                    _logger.LogInformation("No se encontraron marcas en la base de datos.");
                    listaMarcas = new List<SelectListItem>();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores de conexión a la BD o cualquier otro error
                _logger.LogError(ex, "Error al obtener las marcas desde la base de datos");
                listaMarcas = new List<SelectListItem>();
            }
            
            ViewData["Marcas"] = listaMarcas;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
