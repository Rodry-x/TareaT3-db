using System;
using System.Windows.Forms;
using Sistema_Atencion_Al_Cliente.EstructuraDeDatos;

namespace Sistema_Atencion_Al_Cliente.Formularios
{
    public partial class FormPonerEnCola : Form
    {
        public FormPonerEnCola()
        {
            InitializeComponent();
        }

        public Panel PanelPonerEnColaController => panelPonerEnCola;

        private void guardarDatosDelCliente_Click(object sender, EventArgs e)
        {
            var nombres = txtNombres.Text.Trim();
            var apellidos = txtApellidos.Text.Trim();
            var dni = txtDNI.Text.Trim();

            if (string.IsNullOrEmpty(nombres))
            {
                MessageBox.Show("Introduzca los nombres del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return;
            }

            if (string.IsNullOrEmpty(apellidos))
            {
                MessageBox.Show("Introduzca los apellidos del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Introduzca el DNI del cliente.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }

            try
            {
                // Usar nombre totalmente cualificado para evitar ambigüedades
                var cliente = new Modelos.Cliente(nombres, apellidos, dni);

                // Encolar usando la clase Cola
                var posicion = Cola.Instance.Enqueue(cliente);

                // Uso de los getters del modelo para mostrar información al usuario
                MessageBox.Show(
                    $"Cliente: {cliente.NombreCompleto} (DNI: {cliente.DNI})\nGuardado en la cola.\nPosición: {posicion}",
                    "Guardado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Limpiar para nuevo ingreso
                txtNombres.Clear();
                txtApellidos.Clear();
                txtDNI.Clear();
                txtNombres.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
