using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        int suma = num1 + num2;
        int resta = num1 - num2;
        int multiplicacion = num1 * num2;
        double division = (double)num1 / num2;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División: {division}");
    }
}

