using System;

public class Persona
{
    // Propiedades
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Estado { get; set; }

    // Métodos
    public void Saludar()
    {
        Console.WriteLine($"¡Hola! Me llamo {Nombre} tengo {Edad} años y soy {Estado}.");
    }
}

public class Program
{
    public static void Main (string[] args)
    {
        // Crear un objeto de la clase Persona
        Persona persona = new Persona
        {
            Nombre = "Alejandro",
            Edad = 36,
            Estado = "Soltero"
        };

        // Llamar al método Saludar
        persona.Saludar();
    }
}



