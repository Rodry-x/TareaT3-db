using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Sistema_Atencion_Al_Cliente.Modelos;

namespace Sistema_Atencion_Al_Cliente.EstructuraDeDatos
{
    internal sealed class Cola
    {
        private readonly Queue<Cliente> _queue = new();
        private readonly object _sync = new();
        private readonly string _filePath;

        // Instancia única para acceder a la cola desde formularios
        public static Cola Instance { get; } = new Cola();

        private Cola()
        {
            _filePath = Path.Combine(AppContext.BaseDirectory, "cola.json");
            LoadFromFile();
        }

        public int Count
        {
            get { lock (_sync) { return _queue.Count; } }
        }

        // Encola un Cliente y devuelve la posición (1-based)
        public int Enqueue(Cliente cliente)
        {
            if (cliente is null) throw new ArgumentNullException(nameof(cliente));
            lock (_sync)
            {
                _queue.Enqueue(cliente);
                SaveToFile();
                return _queue.Count;
            }
        }

        // Sobre carga práctica: crear y encolar desde datos primitivos
        public int Enqueue(string nombres, string apellidos, string dni)
        {
            var cliente = new Cliente(nombres, apellidos, dni);
            return Enqueue(cliente);
        }

        // Desencola y devuelve el cliente o null si está vacía
        public Cliente? Dequeue()
        {
            lock (_sync)
            {
                if (_queue.Count == 0) return null;
                var c = _queue.Dequeue();
                SaveToFile();
                return c;
            }
        }

        // Mira el siguiente cliente sin quitarlo
        public Cliente? Peek()
        {
            lock (_sync)
            {
                return _queue.Count == 0 ? null : _queue.Peek();
            }
        }

        // Estado actual de la cola como lista
        public List<Cliente> ToList()
        {
            lock (_sync)
            {
                return new List<Cliente>(_queue);
            }
        }

        // Vacía la cola
        public void Clear()
        {
            lock (_sync)
            {
                _queue.Clear();
                SaveToFile();
            }
        }

        // Persiste la cola en disco (cola.json)
        private void SaveToFile()
        {
            try
            {
                var list = ToList();
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(list, options);
                File.WriteAllText(_filePath, json);
            }
            catch
            {
                // Silencioso: en producción registrar el error
            }
        }

        // Carga la cola desde disco si existe
        private void LoadFromFile()
        {
            try
            {
                if (!File.Exists(_filePath)) return;
                var json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<Cliente>>(json) ?? new List<Cliente>();
                lock (_sync)
                {
                    _queue.Clear();
                    foreach (var c in list) _queue.Enqueue(c);
                }
            }
            catch
            {
                // Ignorar errores de deserialización; en producción registrar.
            }
        }
    }
}
