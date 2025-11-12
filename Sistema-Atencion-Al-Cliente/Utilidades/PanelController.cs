
namespace Sistema_Atencion_Al_Cliente.Utilidades
{
    internal static class PanelController
    {
        // Cambia el panel mostrado en un contenedor y libera recursos de los controles previos.
        public static void CambiarPanel(Panel panelContenedor, Panel nuevoPanel, bool disposeOld = true)
        {
            if (panelContenedor is null) throw new ArgumentNullException(nameof(panelContenedor));
            if (nuevoPanel is null) throw new ArgumentNullException(nameof(nuevoPanel));

            // Disponer y eliminar controles existentes para liberar memoria
            if (disposeOld)
            {
                var existentes = panelContenedor.Controls.Cast<Control>().ToArray();
                foreach (var c in existentes)
                {
                    panelContenedor.Controls.Remove(c);
                    try { c.Dispose(); } catch { /* ignorar excepciones de Dispose */ }
                }
            }
            else
            {
                panelContenedor.Controls.Clear();
            }

            // Si el panel que vamos a añadir tiene un padre distinto, quitarlo de su padre anterior
            if (nuevoPanel.Parent != null && nuevoPanel.Parent != panelContenedor)
            {
                nuevoPanel.Parent.Controls.Remove(nuevoPanel);
            }

            nuevoPanel.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(nuevoPanel);
        }
    }
}