using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public partial class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
    }
}
