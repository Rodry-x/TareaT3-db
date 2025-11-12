using System;

namespace Sistema_Atencion_Al_Cliente.Modelos
{
    public class Cliente
    {
        /// ---- Getters y Setters ----
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public int DNI { get; set; } = 0;
        public string Asunto { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

        /// Nombre completo (lectura calculada).
        public string NombreCompleto => string.IsNullOrWhiteSpace(Apellidos)
            ? Nombres
            : $"{Nombres} {Apellidos}";

        /// --- Constructor ---
        public Cliente(string nombres, string apellidos, int dni, string asunto)
        {
            Nombres = nombres ?? string.Empty;
            Apellidos = apellidos ?? string.Empty;
            DNI = dni;
            Asunto = asunto ?? string.Empty;
            FechaRegistro = DateTime.UtcNow;
        }

        public override string ToString() =>
            $"{NombreCompleto} - DNI: {DNI.ToString("D8")} - Asunto: {Asunto} (Registrado: {FechaRegistro:yyyy-MM-dd HH:mm:ss})";
    }
}
