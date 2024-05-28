using CrudNet8MVC.Data;
using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrudNet8MVC.Controllers
{
    public class HomeController : Controller
    {
        //Esto llamando a la data  para hacer uso de esos modelos 
        private readonly ApplicationDbContext _contexto;
        

        //Este es el constructor y ahora puedo usarlo en cualquier metodo
        public HomeController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            //Pasar la base de datos a una lista
            return View(_contexto.Contacto.ToList());
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
