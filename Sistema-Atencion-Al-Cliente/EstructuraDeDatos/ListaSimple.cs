using Sistema_Atencion_Al_Cliente.Modelos;

namespace Sistema_Atencion_Al_Cliente.EstructuraDeDatos
{
    public class ListaSimple
    {
        private NodoListaSimple<Cliente>? cabeza;
        private NodoListaSimple<Cliente>? cola;
        private int tamaño;

        public ListaSimple()
        {
            cabeza = null;
            cola = null;
            tamaño = 0;
        }

        public void Agregar(Cliente dato)
        {
            var nuevoNodo = new NodoListaSimple<Cliente>(dato);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola!.Siguiente = nuevoNodo;
                cola = nuevoNodo;
            }
            tamaño++;
        }

        public Cliente? Buscar(int dni)
        {
            NodoListaSimple<Cliente>? actual = cabeza;
            while (actual != null)
            {
                if (actual.Dato.DNI == dni)
                {
                    return actual.Dato;
                }
                actual = actual.Siguiente;
            }
            return null;
        }
        public int Tamaño() => tamaño;
    }
}
