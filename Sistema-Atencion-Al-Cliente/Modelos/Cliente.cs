using System;

namespace Sistema_Atencion_Al_Cliente.Modelos
{
    internal class Cliente
    {
        /// ---- Getters y Setters ----
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        /// Nombre completo (lectura calculada).
        public string NombreCompleto => string.IsNullOrWhiteSpace(Apellidos)
            ? Nombres
            : $"{Nombres} {Apellidos}";

        public Cliente()
        {
        }

        /// Constructor con parámetros.
        public Cliente(string nombres, string apellidos, string dni)
        {
            Nombres = nombres ?? string.Empty;
            Apellidos = apellidos ?? string.Empty;
            DNI = dni ?? string.Empty;
            FechaRegistro = DateTime.UtcNow;
        }

        public override string ToString() =>
            $"{NombreCompleto} - DNI: {DNI} (Registrado: {FechaRegistro:yyyy-MM-dd HH:mm:ss})";
    }
}
