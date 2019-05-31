using System;

class NotadeCredito : DocumentoLegal
{
    public NotadeCredito(int numero) : base(numero)
    {

    }
    public void Imprimir()
    {
        Console.WriteLine("Soy la NC:" + numero); //Ó this.numero
    }

    //Método de clase:
    static public NotadeCredito LeerDeBaseDeDatos() //Static: es un método dentro de la clase pero no pertenece a ninguna instancia.
    {
        return new NotadeCredito(5);
    }
}