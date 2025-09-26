using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecyo.Models;

namespace PrimerProyecyo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (Juego.ListaJugadores == null)
            Juego.LlenarListaPalabras();
        ViewBag.ListaJugadores = Juego.DevolverListaUsuarios();
        return View();
    }

    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Console.WriteLine("username");
        HttpContext.Session.SetString("usua", username);
        Juego.LlenarListaPalabras();
        ViewBag.username = username;
        ViewBag.palabra = Juego.CargarPalabra(dificultad);
        return View("Juego");
    }
    public IActionResult FinJuego(int intentos)
    {
        string usu = HttpContext.Session.GetString("usua");
        Usuario usuario = new Usuario(usu,intentos);
        Juego.FinJuego(intentos, usu);
        return RedirectToAction("Index");
    }
}
