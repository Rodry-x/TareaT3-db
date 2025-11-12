using System.Text.RegularExpressions;
using Sistema_Atencion_Al_Cliente.EstructuraDeDatos;
using Sistema_Atencion_Al_Cliente.Modelos;
using Sistema_Atencion_Al_Cliente.Utilidades;

namespace Sistema_Atencion_Al_Cliente.Formularios.FormClientes
{
    public partial class FormCola : Form
    {

        // Lista local donde se guardarán los clientes registrados desde este formulario.
        private readonly ListaSimple listaClientes;

        public FormCola()
        {
            listaClientes = new ListaSimple();
            InitializeComponent();
        }

        // Constructor que acepta una lista compartida.
        public FormCola(ListaSimple listaCompartida)
        {
            listaClientes = listaCompartida ?? new ListaSimple();
            InitializeComponent();
        }

        public Panel PanelColaController => panelPonerEnCola;

        private void guardarDatosDelCliente_Click(object sender, EventArgs e)
        {
            // Obtener y limpiar entradas.
            var nombres = txtNombres.Text.Trim();
            var apellidos = txtApellidos.Text.Trim();
            var dniStr = txtDNI.Text.Trim();
            var asunto = txtAsunto?.Text.Trim() ?? string.Empty;

            // Validaciones con helper centralizado.
            if (!Helper.ValidarYNotificar(txtNombres, "El campo Nombres es obligatorio."))
                return;

            if (!Helper.ValidarYNotificar(txtDNI, "El campo DNI es obligatorio."))
                return;

            if (!Helper.ValidarYNotificar(txtAsunto, "El campo Asunto es obligatorio."))
                return;

            // Validar nombres (solo letras y espacios, Unicode aware).
            if (!Regex.IsMatch(nombres, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("El campo Nombres solo puede contener letras y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(apellidos) && !Regex.IsMatch(apellidos, @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("El campo Apellidos solo puede contener letras y espacios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellidos.Focus();
                return;
            }

            // Validar DNI: exactamente 8 dígitos, solo números.
            if (!Regex.IsMatch(dniStr, @"^\d{8}$"))
            {
                MessageBox.Show("El DNI debe contener exactamente 8 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }

            // Convertir a int (ya validado).
            if (!int.TryParse(dniStr, out var dni))
            {
                MessageBox.Show("Error al convertir el DNI.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            // Crear cliente y asignar la hora local de la máquina al registrar.
            var cliente = new Cliente(nombres, apellidos, dni, asunto)
            {
                FechaRegistro = DateTime.Now // hora local del equipo
            };

            // Agregar a la lista.
            listaClientes.Agregar(cliente);

            // Confirmación al usuario.
            MessageBox.Show($"Cliente guardado:\n{cliente}", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos para un nuevo registro.
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDNI.Clear();
            if (txtAsunto != null) txtAsunto.Clear();
            txtNombres.Focus();
        }
    }
}
