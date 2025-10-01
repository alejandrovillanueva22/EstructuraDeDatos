using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

enum EstadoAlumno { Aprobado, Reprobado }

struct Direccion
{
    public string Calle;
    public int Numero;
}

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public List<double> Calificaciones { get; set; } = new List<double>();
    public EstadoAlumno Estado { get; set; }
    public Direccion Direccion { get; set; }

    public double CalcularPromedio() => Calificaciones.Count > 0 ? Calificaciones.Average() : 0.0;
}

class Program
{
    static List<Estudiante> estudiantes = new List<Estudiante>();

    static void Main()
    {
        Console.WriteLine("=== Registro de Estudiantes ===");
        while (true)
        {
            Console.WriteLine("1. Agregar estudiante\n2. Mostrar estudiantes\n3. Guardar en archivo\n4. Salir");
            var opcion = Console.ReadLine();
            if (opcion == "1") AgregarEstudiante();
            else if (opcion == "2") MostrarEstudiantes();
            else if (opcion == "3") GuardarArchivo();
            else if (opcion == "4") break;
        }
    }

    static void AgregarEstudiante()
    {
        var est = new Estudiante();
        Console.Write("Nombre: ");
        est.Nombre = Console.ReadLine();

        Console.Write("Edad: ");
        int edad;
        while (!int.TryParse(Console.ReadLine(), out edad))
        {
            Console.Write("Edad inválida. Intenta de nuevo: ");
        }
        est.Edad = edad;

        
        Direccion dir = new Direccion();
        Console.Write("Calle: ");
        dir.Calle = Console.ReadLine();

        Console.Write("Número: ");
        int numero;
        while (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Número inválido. Intenta de nuevo: ");
        }
        dir.Numero = numero;

        est.Direccion = dir;



        Console.Write("Calificaciones (separadas por coma): ");
        var califStr = Console.ReadLine().Split(',');
        foreach (var c in califStr)
        {
            if (double.TryParse(c, out double nota))
                est.Calificaciones.Add(nota);
        }

        double promedio = est.CalcularPromedio();
        est.Estado = promedio >= 6.0 ? EstadoAlumno.Aprobado : EstadoAlumno.Reprobado;

        estudiantes.Add(est);
        Console.WriteLine("Estudiante agregado.");
    }

    static void MostrarEstudiantes()
    {
        foreach (var e in estudiantes)
        {
            Console.WriteLine($"Nombre: {e.Nombre}, Edad: {e.Edad}, Promedio: {e.CalcularPromedio():F2}, Estado: {e.Estado}");
        }
    }

    static void GuardarArchivo()
    {
        using var writer = new StreamWriter("estudiantes.txt");
        foreach (var e in estudiantes)
        {
            writer.WriteLine($"{e.Nombre}|{e.Edad}|{e.CalcularPromedio()}|{e.Estado}");
        }
        Console.WriteLine("Datos guardados en estudiantes.txt");
    }
}
