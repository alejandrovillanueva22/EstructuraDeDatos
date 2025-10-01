// Clase Alumno
public class Alumno : IComparable<Alumno>
{
    public string Nombre { get; set; }
    public int Puntaje { get; set; }

    public Alumno(string nombre, int puntaje)
    {
        Nombre = nombre;
        Puntaje = puntaje;
    }

    public int CompareTo(Alumno otro)
    {
        // Ordenar de mayor a menor
        return otro.Puntaje.CompareTo(this.Puntaje);
    }

    public override string ToString()
    {
        return $"{Nombre} - {Puntaje}";
    }
}
