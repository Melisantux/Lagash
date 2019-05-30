using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> f = delegate(int i, int j ) { //forma generica de llamar a cualquier funcion.
                return i+1;
            };

            Func<DocumentoLegal, bool > SiEsPar = delegate(DocumentoLegal dl) {
                return (dl.Monto % 2) == 0;
            };

            list.Where(SiEsPar);
        }
    }
}

//throw new Exception(); <-- Crear una excepcion para cuando aparecen errores.

/* try{
    NombreVariable.Imprimir();
}catch{
    Console.WriteLine("reporteError@gmail.com);
}catch{
    Console.WriteLine("Segui participando");
} */

/*class NoHayPapelException : Exception <- Crear una clase que represente un tipo de error. Debe llamarse NombreException.
{

} */

// => <-- Equivalente a delegate.

/*SiEsPar = (DocumentoLegal dl) => (dl.Monto % 2) == 0;
list.Where(SiEsPar); */

//También puede hacerse: list.Where((DocumentoLegal dl) => (dl.Monto % 2) == 0); <-- Esto se conoce como Lambda Functions.

//Para usar eso ultimo agregar: System.fong

//DateTime permite operar con fechas.

/*Ejemplo:
DateTime fecha = new DateTime (2019, 2, 28);
fecha.AddDays(1); <-- DateTime reconoce automaticamene si un año es bisiesto o no y que meses tienen 30 o 31 dias. */

//Listas: para agregar un elemento: nombreLista.Add(LO QUE QUIERO AGREGAR);

/*foreach (var nom in nombreLista)
{
    Console.WriteLine(nom);
} */

//foreach (var nom in nombreLista.Where( (nn) => nn[0] == 'D');

//foreach se puede usar para todo lo que sea enumerable.

/*Ejercicio:
Hacer un programa que escriba en un archivo de texto un listado de personas y telefonos.
El programa tiene que tambien poder leer el archivo y cargarlo en una coleccion.

Si modifico el archivo, tengo que poder leerlo nuevamente. */