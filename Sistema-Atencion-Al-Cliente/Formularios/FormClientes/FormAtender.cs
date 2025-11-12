using Sistema_Atencion_Al_Cliente.EstructuraDeDatos;
using Sistema_Atencion_Al_Cliente.Modelos;
using System.Text.RegularExpressions;

namespace Sistema_Atencion_Al_Cliente.Formularios.FormClientes
{
    public partial class FormAtender : Form
    {
        private ListaSimple listaClientes;

        // Constructor por defecto: asegurar inicialización para evitar NRE en diseño.
        public FormAtender()
        {
            listaClientes = new ListaSimple();
            InitializeComponent();
        }

        // Nuevo constructor que recibe la lista desde FormCola u otro origen.
        public FormAtender(ListaSimple listaCompartida)
        {
            InitializeComponent();
            listaClientes = listaCompartida ?? new ListaSimple();
            // No añadir datos de ejemplo: se usa la lista compartida tal cual está.
        }

        public Panel PanelAtenderController => panelAtender;

        private void BuscarDNI_Click(object sender, EventArgs e)
        {
            string dniTexto = txtDNI.Text.Trim();

            if (string.IsNullOrWhiteSpace(dniTexto))
            {
                MessageBox.Show("Ingrese un DNI válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sean exactamente 8 dígitos numéricos (misma regla que en FormCola)
            if (!Regex.IsMatch(dniTexto, @"^\d{8}$"))
            {
                MessageBox.Show("El DNI debe contener exactamente 8 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return;
            }

            // Convertir a int antes de buscar
            if (!int.TryParse(dniTexto, out var dni))
            {
                MessageBox.Show("Error al convertir el DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Focus();
                return;
            }

            Cliente? encontrado = listaClientes.Buscar(dni);

            if (encontrado != null)
            {
                lblResultado.ForeColor = Color.Green;
                lblResultado.Text =
                    $"✅ Cliente encontrado:\n" +
                    $"👤 {encontrado.NombreCompleto}\n" +
                    $"🪪 DNI: {encontrado.DNI:D8}\n" +
                    $"🗂 Asunto: {encontrado.Asunto}\n" +
                    $"📅 Fecha: {encontrado.FechaRegistro:dd/MM/yyyy HH:mm}";
            }
            else
            {
                lblResultado.ForeColor = Color.Red;
                lblResultado.Text = "❌ Cliente no encontrado.";
            }
        }
    }
}
