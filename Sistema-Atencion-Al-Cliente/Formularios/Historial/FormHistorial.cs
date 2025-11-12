using Sistema_Atencion_Al_Cliente.Modelos;
using Sistema_Atencion_Al_Cliente.EstructuraDeDatos;

namespace Sistema_Atencion_Al_Cliente.Formularios.Historial
{
    public partial class FormHistorial : Form
    {
        private ListaSimple historialClientes = new ListaSimple();

        public FormHistorial(ListaSimple historialClientes)
        {
            InitializeComponent();
            this.historialClientes = historialClientes;
            MostrarHistorial();
        }

        public Panel PanelHistorialController => panelHistorial;

        private void MostrarHistorial()
        {
            dgvHistorial.Rows.Clear();

            // Acceso a la cabeza de la lista
            var nodo = ObtenerCabeza();
            while (nodo != null)
            {
                var cliente = nodo.Dato;
                dgvHistorial.Rows.Add(
                    $"{cliente.Nombres} {cliente.Apellidos}",
                    cliente.DNI.ToString(),
                    cliente.Asunto,
                    cliente.FechaRegistro.ToString("dd/MM/yyyy HH:mm")
                );
                nodo = nodo.Siguiente;
            }
        }

        // Método auxiliar para acceder a la cabeza de la lista
        private NodoListaSimple<Cliente>? ObtenerCabeza()
        {
            // Usa reflexión porque 'cabeza' es privado
            var campo = typeof(ListaSimple).GetField("cabeza", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return campo?.GetValue(historialClientes) as NodoListaSimple<Cliente>;
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}