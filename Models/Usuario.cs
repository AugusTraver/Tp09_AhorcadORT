namespace PrimerProyecyo.Models;

public class Usuario
{
    public string nombre {get; private set;} 
    public int cantidadIntentos {get; private set;} 
public Usuario(string pNombre, int Cantida)
{
    nombre = pNombre;
    cantidadIntentos = Cantida;
}
}
