using System;
using System.Collections;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //var dl = new DocumentoLegal(1); //El objeto pertenece a una única clase.

            var fc = new Factura(2);

            var nc = new NotadeCredito(1);

            var nc2 = new NotadeCredito(2);

            object algo = (DocumentoLegal)fc; //Object me permite crear una variable genérica que puede recibir lo que sea ya que hereda de una clase BASE que se llama Object.

            nc.Imprimir();
            nc2.Imprimir();

            var facturas = new Factura[3];
            facturas[0] = new Factura(1);
            facturas[1] = new Factura(2);
            facturas[2] = new Factura(3);

            ListaDeFacturas listaF= new ListaDeFacturas(facturas);
            listaF.Total();


            bool si = (dl is DocumentoLegal);

            Console.WriteLine(si);

            si= (dl is Factura);
            Console.WriteLine(si);
            si= (fc is DocumentoLegal);
            Console.WriteLine(si);
            si = (fc is Factura);
            Console.WriteLine(si);

            fc.Enviar();
            hacerAlgoConDocumentos(dl);
            hacerAlgoConDocumentos(fc); //También le puedo pasar fc o nc porque tanto Factura como Nota de Credito, hereda de Documento Legal.

            var nnc = NotadeCredito.LeerDeBaseDeDatos();

            NotadeCredito onc = null; //Se considera una mala práctica ya que da lugar a errores muy comunes.

            //onc.Imprimir(); //<-- Errores como este.


        }

        static void hacerAlgoConDocumentos(DocumentoLegal dl)
        {
            dl.Imprimir();
        }
    }
}

//DLL: es un archivo binario (una libreria dinámica). Cuando compilamos en C#, lo que generamos es una DLL.
//Namespace: buscar.

//Package Manager: permite referenciar (llamar) librerías de otras personas.

//Estructura de proyecto:
//Solucion:
// - Proyecto: genera una DLL (assembly).
// - Proyecto: genera una DLL (assembly).

//Buscar GAC (directorio que maneja todas las librerias (assemblys)).

//SOLID (5 Principios de diseño de objetos que deben tenerse en cuenta)
//S: Single responsibility principle.

