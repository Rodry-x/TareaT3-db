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
        private FormPonerEnCola formPonerEnCola;
        public Panel PanelContenedorController => panelInmovil;

        private void cambiarAlPanelInicio_Click(object sender, EventArgs e)
        {
            formInicio = new FormInicio();
            PanelController.CambiarPanel(panelInmovil, formInicio.PanelPrincipalController);
        }

        private void cambiarAlPanelDeCola_Click(object sender, EventArgs e)
        {
            formPonerEnCola = new FormPonerEnCola();
            PanelController.CambiarPanel(panelContenedor, formPonerEnCola.PanelPonerEnColaController);
        }
    }
}
