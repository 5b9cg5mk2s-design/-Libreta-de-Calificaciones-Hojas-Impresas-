// 1. CLASE DE PRUEBA (Donde arranca el programa)
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        // crea el objeto miLibroCalificaciones y pasa el nombre del curso
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
            "CS101 Introducción a la programación en C#");

        miLibroCalificaciones.MostrarMensaje(); // muestra el mensaje de bienvenida
        miLibroCalificaciones.DeterminarPromedioClase(); // encuentra el promedio
    } // fin de Main
}