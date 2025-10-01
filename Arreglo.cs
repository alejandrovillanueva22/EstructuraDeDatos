using System;

public class ArregloGen<T> where T : IComparable<T>
{
    private T[] elementos;
    private int contador;

    public ArregloGen(int capacidad)
    {
        elementos = new T[capacidad];
        contador = 0;
    }

    public void Agregar(T elemento)
    {
        if (contador < elementos.Length)
        {
            elementos[contador++] = elemento;
        }
        else
        {
            Console.WriteLine("Arreglo completo, no se pueden agregar mas elementos");
        }
    }

    public T Obtener(int indice)
    {
        if (indice >= 0 && indice < contador)
            return elementos[indice];
        else
            throw new IndexOutOfRangeException("Índice fuera de rango.");
    }

    public void Eliminar(int indice)
    {
        if (indice >= 0 && indice < contador)
        {
            for (int i = indice; i < contador - 1; i++)
            {
                elementos[i] = elementos[i + 1];
            }
            contador--;
        }
        else
        {
            Console.WriteLine("Índice inválido.");
        }
    }

    public void Mostrar()
    {
        for (int i = 0; i < contador; i++)
        {
            Console.Write(elementos[i] + " ");
        }
        Console.WriteLine();
    }

    public void Ordenar()
    {
        // Bubble Sort
        for (int i = 0; i < contador - 1; i++)
        {
            for (int j = 0; j < contador - i - 1; j++)
            {
                if (elementos[j].CompareTo(elementos[j + 1]) > 0)
                {
                    // intercambiar
                    T temp = elementos[j];
                    elementos[j] = elementos[j + 1];
                    elementos[j + 1] = temp;
                }
            }
        }
    }
}