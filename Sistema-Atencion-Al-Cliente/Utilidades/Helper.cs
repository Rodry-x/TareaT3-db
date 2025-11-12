
namespace Sistema_Atencion_Al_Cliente.Utilidades
{
    internal static class Helper
    {
        /// Valida que el TextBox no esté vacío; muestra un MessageBox y pone el Focus si no es válido.
        /// Devuelve true cuando el campo es válido.
        public static bool ValidarYNotificar(TextBox campo, string mensaje)
        {
            if (string.IsNullOrWhiteSpace(campo.Text.Trim()))
            {
                MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                campo.Focus();
                return false;
            }
            return true;
        }
    }
}
