using System.Diagnostics;

namespace Sistema_Atencion_Al_Cliente.Utilidades
{
    internal class AbrirUrl
    {
        public static void AbrirEnNavegador(string url, IWin32Window? owner = null, LinkLabel? linkLabel = null)
        {
            // --- Validar que la URL no esté vacía --- //
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("La URL no puede estar vacía.", nameof(url));

            // --- Marcar el LinkLabel como visitado si se proporciona --- //
            if (linkLabel is not null)
                linkLabel.LinkVisited = true;

            // --- Intentar abrir la URL en el navegador predeterminado --- //
            try
            {
                // Usar ProcessStartInfo para abrir la URL
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }

            // --- Capturar cualquier excepción y mostrar un mensaje de error --- //
            catch (Exception ex)
            {
                string msg = $"No se pudo abrir el navegador: {ex.Message}";
                if (owner is not null)
                    MessageBox.Show(owner, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
