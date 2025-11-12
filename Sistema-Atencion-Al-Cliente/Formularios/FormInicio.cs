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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        public Panel PanelPrincipalController => panelPrincipal;
        private FormContenedor formContenedor;
        private void cambiarAlPanelInmovil_Click(object sender, EventArgs e)
        {
            formContenedor = new FormContenedor();
            PanelController.CambiarPanel(panelPrincipal,formContenedor.PanelContenedorController);
        }
    }
}
