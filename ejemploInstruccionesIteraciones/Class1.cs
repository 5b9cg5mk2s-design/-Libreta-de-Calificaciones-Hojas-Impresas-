using System;

// Fig. 5.7: LibroCalificaciones.cs
// Clase LibroCalificaciones que resuelve el problema del promedio de la clase
// usando la repetición controlada por un centinela.
public class LibroCalificaciones
{
    private string nombreCurso; // nombre del curso

    public LibroCalificaciones(string nombre)
    {
        NombreCurso = nombre;
    }

    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!\n",
            NombreCurso);
    }

    // determina el promedio de un número arbitrario de calificaciones
    public void DeterminarPromedioClase()
    {
        int total; // suma de las calificaciones
        int contadorCalif; // número de calificaciones introducidas
        int calificacion; // valor de la calificación
        double promedio; // número con punto decimal para el promedio

        // fase de inicialización
        total = 0;
        contadorCalif = 0;

        // fase de procesamiento
        Console.Write("Escriba calificación o -1 para salir: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        // itera hasta que se lee el valor centinela (-1)
        while (calificacion != -1)
        {
            total = total + calificacion; // suma calificacion a total
            contadorCalif = contadorCalif + 1; // incrementa el contador

            
            Console.Write("Escriba calificación o -1 para salir: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        } // fin de while

        // PARTE COMPLETADA: Fase de terminación (Cálculo del promedio real)
        if (contadorCalif != 0)
        {
            // usa conversión explícita (cast) para calcular el promedio con decimales
            promedio = (double)total / contadorCalif;
            Console.WriteLine("\nEl total de las {0} calificaciones introducidas es {1}",
                contadorCalif, total);
            Console.WriteLine("El promedio de la clase es {0:F2}", promedio);
        }
        else
        {
            Console.WriteLine("No se introdujeron calificaciones");
        }
    } // fin del método DeterminarPromedioClase
} // fin de la clase LibroCalificaciones