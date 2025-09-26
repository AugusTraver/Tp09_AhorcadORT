namespace PrimerProyecyo.Models;
using Newtonsoft.Json;

public class Usuario
{
    [JsonProperty]
     public string nombre { get; private set; }
    public int cantidadIntentos { get; private set; }
    public Usuario(string pNombre, int Cantida)
    {
        nombre = pNombre;
        Console.WriteLine("NOMBRE !!!!!!!!!!!!!!!!!!!!!!!!" + pNombre + nombre);
        cantidadIntentos = Cantida;
    }
}
