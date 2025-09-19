namespace PrimerProyecyo.Models;

public static class Juego
{
    public static List<Palabra> ListaPalabras { get; private set; }
    public static List<Usuario> ListaJugadores { get; private set; }
    public static Usuario JugadorAcutal { get; private set; }
    public static void LlenarListaPalabras()
    {
        ListaPalabras.Add(new Palabra("Perro", 1));
        ListaPalabras.Add(new Palabra("Gato", 1));
        ListaPalabras.Add(new Palabra("Tolo", 1));
        ListaPalabras.Add(new Palabra("Fito", 1));
        ListaPalabras.Add(new Palabra("For", 1));
        ListaPalabras.Add(new Palabra("Vector", 1));
        ListaPalabras.Add(new Palabra("Lista", 1));
        ListaPalabras.Add(new Palabra("Array", 1));
        ListaPalabras.Add(new Palabra("Paso", 1));
        ListaPalabras.Add(new Palabra("Iara", 1));

        // Nivel de dificultad 2 (palabras intermedias)
        ListaPalabras.Add(new Palabra("Montaña", 2));
        ListaPalabras.Add(new Palabra("Avion", 2));
        ListaPalabras.Add(new Palabra("Poyin", 2));
        ListaPalabras.Add(new Palabra("Pelicula", 2));
        ListaPalabras.Add(new Palabra("Cielo", 2));
        ListaPalabras.Add(new Palabra("Peron", 2));
        ListaPalabras.Add(new Palabra("Hieron", 2));
        ListaPalabras.Add(new Palabra("Mariposa", 2));
        ListaPalabras.Add(new Palabra("Morgan", 2));
        ListaPalabras.Add(new Palabra("Reloj", 2));

        // Nivel de dificultad 3 (palabras avanzadas)
        ListaPalabras.Add(new Palabra("Computadora", 3));
        ListaPalabras.Add(new Palabra("Fotografia", 3));
        ListaPalabras.Add(new Palabra("Antiguo", 3));
        ListaPalabras.Add(new Palabra("Dinosaurio", 3));
        ListaPalabras.Add(new Palabra("Peligroso", 3));
        ListaPalabras.Add(new Palabra("Inmortal", 3));
        ListaPalabras.Add(new Palabra("Biblioteca", 3));
        ListaPalabras.Add(new Palabra("Eclipse", 3));
        ListaPalabras.Add(new Palabra("Ciencia", 3));
        ListaPalabras.Add(new Palabra("Calamuchita", 3));

        // Nivel de dificultad 4 (palabras complejas)
        ListaPalabras.Add(new Palabra("Anticonstitucionalmente", 4));
        ListaPalabras.Add(new Palabra("Pneumonoultramicroscopicsilicovolcanoconiosis", 4));
        ListaPalabras.Add(new Palabra("Electroencefalografista", 4));
        ListaPalabras.Add(new Palabra("Hipopotomonstrosesquipedaliofobia", 4));
        ListaPalabras.Add(new Palabra("Esternocleidomastoideo", 4));
        ListaPalabras.Add(new Palabra("Otorrinolaringologia", 4));
        ListaPalabras.Add(new Palabra("Fluorurosilicato", 4));
        ListaPalabras.Add(new Palabra("hipopotomonstrosesquipedaliofobia ", 4));
        ListaPalabras.Add(new Palabra("MiniPekka", 4));
        ListaPalabras.Add(new Palabra("Desoxirribonucleico", 4));
    }
    public static void InicializarJuego(string usuario, int dificultad)
    {
        Usuario usu = new Usuario(usuario, 0);
        JugadorAcutal = usu;
    }

    public static string CargarPalabra(int dificultad)
    {
        List<Palabra> palabrasDif = null;
        Random rnd = new Random();
        int indice = rnd.Next(0, 11);
        int numeroAleatorio = rnd.Next(1, 11);
        int i = 0;
        do
        {
            if (ListaPalabras[i].dificultad == dificultad)
            {
                palabrasDif.Add(ListaPalabras[i]);
            }
            i++;
        } while (i >= ListaPalabras.Count);
        return palabrasDif[indice].texto;
    }

    public static void FinJuego(int intentos)
    {
        string nombre = JugadorAcutal.nombre;
        Usuario jugadorA = new Usuario(nombre, intentos);
        ListaJugadores.Add(jugadorA);
    }
    public static List<Usuario> DevolverListaUsuarios()
    {
        return ListaJugadores.OrderBy(u => u.cantidadIntentos).ToList();
    }
    public static void AgregarJugador(Usuario usuario)
    {
        ListaJugadores.Add(usuario);
    }
}

