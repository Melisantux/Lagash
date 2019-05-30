class Lista<TIPO>
{
    private TIPO[] lista;
    public Lista(TIPO[] miLista){
        this.lista = miLista;
    }

    public int Total()
    {
        int total = 0;
        for(var i = 0; i < lista.Length; f++)
        {
            total += lista(f).Monto;
        }
        return total;
    }
}

//Generic. Buscar.
//Ejemplo de diccionario: var dic = new Dictionary<string, Factura>(); <-- string y factura es que el diccionario puede recibir esos dos tipos.
//var list = new List <-- clase que viene incluida en system collections.

/* class Lista<TIPO> where TIPO : DocumentoLegal */

/* class ComparadorDL : Icomparer<DocumentoLegal>
{
    public int Compare(DocumentoLegal x, DocumentoLegal y)
    {
        if(x.Monto > y.Monto) return -1;
        if(x.Monto < y.Monto) return 1;
        return 0;
    }
} */