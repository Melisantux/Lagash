using System;

namespace Meli
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo = 100;
            int empleados = 4;
            int transferencia;
            int [] sueldos = new int[5];

            sueldos[0] = 100;
            sueldos[1] = 250;
            transferencia = empleados * sueldo;
            if(transferencia > sueldos[1]){
                Console.WriteLine("Monto: " + transferencia);
            } else {
                Console.WriteLine("Monto: " + sueldos[1]);
            }

            if((transferencia%2) == 0){ //Probar en casa todo el programa.
                Console.WriteLine("El monto es par.");
            }else {
                Console.WriteLine("El monto es impar");
            }
        }
    }
}

//Hacer un array de 10 posiciones. Imprimir la suma de las 10 posiciones.
//Si es disibile por 3, mencionarlo.