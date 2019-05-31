using System;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[9];
            int sumaArray;

            array[0] = 2;
            array[1] = 4;
            array[2] = 6;
            array[3] = 8;
            array[4] = 10;
            array[5] = 12;
            array[6] = 14;
            array[7] = 16;
            array[8] = 18;

            sumaArray = array[0] + array[1] + array[2] + array[3] + array[4];
            sumaArray = sumaArray + array[5] + array[6] + array[7] + array[8];

            Console.WriteLine("La suma es: " + sumaArray);

            struct Persona
            {
                public string nombre;
                public string apellido;
                public long sueldo;
            }

            Persona persona = new Persona();
            persona.nombre = "Diego";
            persona.apellido = "Gonzalez";
            persona.sueldo = 100;

            var otraPersona = new Persona{
                nombre = "Diego",
                apellido = "Gonzalez",
                sueldo = 100
            };
        }
    }
}
