using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PruebaEPS.Models
{
    public class Cita
    {
        [Key]
        public Int64 IDCita { get; set; }
        public string Paciente { get; set; }
        public string Doctor { get; set; }
        public string Sede { get; set; }
        public Int64 IDPaciente { get; set; }
        public Int64 IDDoctor { get; set; }
        public Int64 IDSede { get; set; }
        public DateTime Fecha { get; set; }

    }
}
