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

namespace Sistema_Atencion_Al_Cliente.Formularios.Grabaciones
{
    public partial class FormExplicacionDelCodigo : Form
    {
        public FormExplicacionDelCodigo()
        {
            InitializeComponent();
        }
        private FormContenedor formContenedor;
        public Panel PanelExplicacionDelCodigo => panelExplicacionDelCodigo;

        private void cambiarAlPanelContenedor_Click(object sender, EventArgs e)
        {
            formContenedor = new FormContenedor();
            PanelController.CambiarPanel(panelExplicacionDelCodigo, formContenedor.PanelContenedorController);
        }
    }
}
