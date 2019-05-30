using System;

class Factura : DocumentoLegal
{
    public Factura(int numero) : base(numero)
    {
        
    }

    public override void Imprimir()
    {
        Console.WriteLine("Soy la FC numero: " + this.GetNumero());
    }
    public void Pagar()
    {
        Console.WriteLine("Factura.Pagar");
    }
}

//Buscar sobre métodos virtuales.
//Métodos virtuales: pongo un método con sentencias y sugiero que si otra clase quiere usarla, puede usar un
//override y modificarla para su gusto. (En general, debería modificarlo con un override).
//Los métodos virtuales se declaran en todo tipo de clases.

//Interface: indica que métodos deben haber en las clases que las heredan. Todos sus métodos son abstractos.
//Interface: básicamente es un contrato, es decir, todas las clases deben utilizar sus métodos SI O SI. Es como
//plantear ciertas reglas que todos las clases deben seguir.
//La interfaz es libre de implementación, únicamente es una declaración.

//EN C#, una clase no puede heredar de multiples clases, pero si puede implementar múltiples interfaces.
//Es decir: una clase puede heredar de una unica clase y de multiples interfaces.