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
        Usuario usu = new Usuario(username, dificultad);
        string obj = Objeto.ObjectToString(usu);
        HttpContext.Session.SetString("usua", obj);

        Juego.LlenarListaPalabras();
        ViewBag.username = username;
        ViewBag.palabra = Juego.CargarPalabra(dificultad);
        return View("Juego");
    }
    public IActionResult FinJuego(int intentos)
    {
       string usu =  HttpContext.Session.GetString("usua");
        Usuario usuario = Objeto.StringToObject<Usuario>(usu);
        usu = usuario.nombre;
        Juego.FinJuego(intentos, usu);
        return RedirectToAction("Index");
    }
}
