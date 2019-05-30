using System;

abstract class DocumentoLegal //Al hacer una clase abstracta, ya no puedo crear instancias (new) de la clase.
{
    public int numero; //Public: Lo pueden ver todas las clases.
    private int codEnBaseDeDatos; //Solo lo puede ver esta clase.
    protected int fechaAlta; //Solo se puede acceder desde la clase y las clases que heredan pero no desde "afuera".

    public int GetNumero()
    {
        return numero;
    }

    protected void SetNumero(int numeroUno)
    {
        this.numero = numeroUno;
    }

    public DateTime Fecha{ //Para reemplazar los metodos SetNumero y GetNumero y hacerlos todo en un mismo método.
        get
        {
            return Fecha;
        }
        protected set
        {
            Fecha = value;
        }
    }

    //Proteger los datos poniendoles seguridad utilizando private o protected se llama encapsulamiento.
    public void Enviar()
    {
        Console.WriteLine("DocumentoLegal.enviar");
    }
    private void GuardarEnBaseDeDatos()
    {
        
    }

    public DocumentoLegal(int numeroUno) //Método de instancia llamado CONSTRUCTOR.
    {
        this.numero = numeroUno;
    }

    abstract public void Imprimir();
}