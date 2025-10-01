
// Programa Principal
class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.WriteLine("\n==== MENÚ ====");
            Console.WriteLine("1. Demostración con enteros");
            Console.WriteLine("2. Demostración con cadenas");
            Console.WriteLine("3. Demostración con alumnos");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    DEnteros();
                    break;
                case 2:
                    DCadenas();
                    break;
                case 3:
                    DAlumnos();
                    break;
            }
        } while (opcion != 4);
    }

    static void DEnteros()
    {
        var numeros = new ArregloGen<int>(6);
        numeros.Agregar(110);
        numeros.Agregar(22);
        numeros.Agregar(87);
        numeros.Agregar(77);
        numeros.Agregar(7);
        numeros.Agregar(26);


        Console.WriteLine("\nAntes de ordenar:");
        numeros.Mostrar();

        numeros.Ordenar();
        Console.WriteLine("Después de ordenar:");
        numeros.Mostrar();

    }

    static void DCadenas()
    {
        var palabras = new ArregloGen<string>(6);
        palabras.Agregar("Cafe");
        palabras.Agregar("Agua");
        palabras.Agregar("Mariposa");
        palabras.Agregar("Pozole");
        palabras.Agregar("Pizza");
        palabras.Agregar("Periodico");

        Console.WriteLine("\nAntes de ordenar:");
        palabras.Mostrar();

        palabras.Ordenar();
        Console.WriteLine("Después de ordenar:");
        palabras.Mostrar();
    }

    static void DAlumnos()
    {
        var alumnos = new ArregloGen<Alumno>(6);
        alumnos.Agregar(new Alumno("Alejando", 85));
        alumnos.Agregar(new Alumno("Erika", 80));
        alumnos.Agregar(new Alumno("Diego", 100));
        alumnos.Agregar(new Alumno("Christian", 100));
        alumnos.Agregar(new Alumno("Gerardo", 90));
        alumnos.Agregar(new Alumno("Elliot", 85));


        Console.WriteLine("\nAntes de ordenar:");
        alumnos.Mostrar();

        alumnos.Ordenar();
        Console.WriteLine("Después de ordenar:");
        alumnos.Mostrar();
    }
}
