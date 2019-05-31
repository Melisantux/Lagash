using System;

namespace Funciones_22052019
{
    class Program
    {
        static int Suma(params int[] a){ //Ejemplo de polimorfismo.
                int suma = 0;
                for (int index = 0; index < a.Length; index++)
                {
                    suma += a[index];
                }

                return suma;
            }

            static int Sumatoria(int numero) // Ejemplo de funcion recursiva (se llama a sí misma).
            {
                // return (numero == 0) ? 0 : numero + Sumatoria(numero - 1);
                if(numero == 0)
                {
                    return 0;
                }else {
                    return numero + Sumatoria(numero - 1);
                }
            }
        static void Main(string[] args)
        {
            var suma = Suma(4,5,6);

            Console.WriteLine(suma);

            var sumatoria = Sumatoria(8);

            Console.WriteLine(sumatoria);
        }
    }
}

//TAREA
// Hacer una funcion que se llame Division() que divida dos numeros enteros.
// SIN USAR EL OPERADOR DIVIDIR /.
//+1) = iteracion.
//+2) = recursiva.