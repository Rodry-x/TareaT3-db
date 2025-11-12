using Sistema_Atencion_Al_Cliente.Modelos;

namespace Sistema_Atencion_Al_Cliente.EstructuraDeDatos
{
    internal class ListaSimple
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
        public bool Eliminar(int dni)
        {
            NodoListaSimple<Cliente>? actual = cabeza;
            NodoListaSimple<Cliente>? anterior = null;
            while (actual != null)
            {
                if (actual.Dato.DNI == dni)
                {
                    if (anterior == null)
                    {
                        cabeza = actual.Siguiente;
                    }
                    else
                    {
                        anterior.Siguiente = actual.Siguiente;
                    }
                    if (actual == cola)
                    {
                        cola = anterior;
                    }
                    tamaño--;
                    return true;
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
            return false;
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
