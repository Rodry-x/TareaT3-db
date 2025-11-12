using Sistema_Atencion_Al_Cliente.Formularios.FormClientes;
using Sistema_Atencion_Al_Cliente.Formularios.Historial;
using Sistema_Atencion_Al_Cliente.Utilidades;
using Sistema_Atencion_Al_Cliente.EstructuraDeDatos;

namespace Sistema_Atencion_Al_Cliente.Formularios
{
    public partial class FormContenedor : Form
    {
        public FormContenedor()
        {
            InitializeComponent();
        }

        private FormInicio formInicio;
        private FormCola formPonerEnCola;
        private FormAtender formAtenderCliente;
        private FormHistorial formHistorial;

        // Lista compartida usada por los formularios de clientes.
        private readonly ListaSimple listaCompartida = new ListaSimple();

        public Panel PanelContenedorController => panelInmovil;

        private void cambiarAlPanelInicio_Click(object sender, EventArgs e)
        {
            formInicio = new FormInicio();
            PanelController.CambiarPanel(panelInmovil, formInicio.PanelPrincipalController);
        }

        private void cambiarAlPanelDeCola_Click(object sender, EventArgs e)
        {
            formPonerEnCola = new FormCola(listaCompartida);
            PanelController.CambiarPanel(panelContenedor, formPonerEnCola.PanelColaController);
        }

        private void cambiarAlPanelAtender_Click(object sender, EventArgs e)
        {
            formAtenderCliente = new FormAtender(listaCompartida);
            PanelController.CambiarPanel(panelContenedor, formAtenderCliente.PanelAtenderController);
        }

        private void cambiarAlPanelHistorial_Click(object sender, EventArgs e)
        {
            formHistorial = new FormHistorial(listaCompartida);
            PanelController.CambiarPanel(panelContenedor, formHistorial.PanelHistorialController);
        }
    }
}
