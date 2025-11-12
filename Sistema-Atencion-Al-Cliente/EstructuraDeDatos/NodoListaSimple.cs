
namespace Sistema_Atencion_Al_Cliente.EstructuraDeDatos
{
    internal class NodoListaSimple<TipoDato>
    {
        public TipoDato Dato { get; set; }
        public NodoListaSimple<TipoDato>? Siguiente { get; set; }

        public NodoListaSimple(TipoDato dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
