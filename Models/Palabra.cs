namespace PrimerProyecyo.Models;

public class Palabra
{
    public string texto { get; private set; }
    public int dificultad { get; private set; }
    public Palabra(string Ptexto, int Pdificultad)
    {
        texto = Ptexto;
        dificultad = Pdificultad;
    }
}
