using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Cuál es tu nombre?");
        string nombre = Console.ReadLine(); // Lee el nombre del usuario

        Console.WriteLine($"¡Hola, {nombre}! ¿Cuál es tu edad?");
        int edad = int.Parse(Console.ReadLine()); // Convierte la entrada a entero

        Console.WriteLine($"Genial, {nombre}. Tienes {edad} años. ¡Sigue aprendiendo C#!");
    }
}

