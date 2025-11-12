using Sistema_Atencion_Al_Cliente.Formularios.FormClientes;
using Sistema_Atencion_Al_Cliente.Formularios.Historial;
using Sistema_Atencion_Al_Cliente.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public Panel PanelContenedorController => panelInmovil;

        private void cambiarAlPanelInicio_Click(object sender, EventArgs e)
        {
            formInicio = new FormInicio();
            PanelController.CambiarPanel(panelInmovil, formInicio.PanelPrincipalController);
        }

        private void cambiarAlPanelDeCola_Click(object sender, EventArgs e)
        {
            formPonerEnCola = new FormCola();
            PanelController.CambiarPanel(panelContenedor, formPonerEnCola.PanelColaController);
        }

        private void cambiarAlPanelAtender_Click(object sender, EventArgs e)
        {
            formAtenderCliente = new FormAtender();
            PanelController.CambiarPanel(panelContenedor, formAtenderCliente.PanelAtenderController);
        }

        private void cambiarAlPanelHistorial_Click(object sender, EventArgs e)
        {
            formHistorial = new FormHistorial();
            PanelController.CambiarPanel(panelContenedor, formHistorial.PanelHistorialController);
        }
    }
}
