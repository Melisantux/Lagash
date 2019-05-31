using System;

namespace Clase
{
    class Program
    {
        enum TipoEmpleado {
                Empleado, LU, Contratado
            }

            struct Persona{
                public string Nombre;
                public string Apellido;
                public long Sueldo;
                public TipoEmpleado Tipo;
            }
        static void Main(string[] args)
        {

            Persona p = new Persona();
            p.Nombre = "Diego";
            p.Apellido = "Gonzalez";
            p.Sueldo = 100;
            p.Tipo = TipoEmpleado.Empleado;

            var otraP = new Persona{
                Nombre = "Melanie",
                Apellido = "Santuccio",
                Sueldo = 100,
                Tipo = TipoEmpleado.LU
            };

            Console.WriteLine(otraP.Nombre + " " + otraP.Apellido + " "+ otraP.Tipo);

            
        }
    }
}
