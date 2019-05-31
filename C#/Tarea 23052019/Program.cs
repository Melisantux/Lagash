using System;

namespace Tarea
{
    class Program
    {
        //Función para dividir que da como resultado un entero.
        static int Division(int dividendo, int divisor)
        {
            int contador = 0;
            int resultado = dividendo;
            while(resultado >= 0 && resultado >= divisor)
            {
                resultado = resultado - divisor;
                contador++;
            }

            return contador;
        }

        //Intento de hacerla con recursiva, no supe como resolverlo porque al usar recursividad,
        //se me "reiniciaba" el contador.
        /*static int DivisionRecursiva(int dividendo, int divisor)
        {
            int resultado;
            int contador = 0;
            
            resultado = dividendo - divisor;
            return (resultado >= 0 && resultado <= divisor) ? contador : DivisionRecursiva(resultado, divisor);
        }*/
        static void Main(string[] args)
        {
            int numeroUno = 57;
            int numeroDos = 6;
            int resultado;
            //int prueba;

            resultado = Division(numeroUno, numeroDos);
            //prueba = DivisionRecursiva(numeroUno, numeroDos);

            Console.WriteLine(resultado);
            //Console.WriteLine(prueba);


        }
    }
}
