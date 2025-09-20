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
        ViewBag.ListaJugadores = Juego.ListaJugadores;
        return View();
    }

    [HttpPost]
    public IActionResult Comenzar(string username, int dificultad)
    {
        Usuario usu = new Usuario(username, dificultad);
        string obj = Objeto.ObjectToString(usu);
        HttpContext.Session.SetString("usua", obj);

        Juego.LlenarListaPalabras();
        ViewBag.username = username;
        ViewBag.palabra = Juego.CargarPalabra(dificultad);
        return View("Juego");
    }
    [HttpPost]
    [HttpPost]
    public IActionResult FinJuego(int intentos)
    {
        string juego = HttpContext.Session.GetString("usua");
        Usuario usu = Objeto.StringToObject<Usuario>(juego);
        Juego.AgregarJugador(usu);
        return RedirectToAction("Index");
    }
}
