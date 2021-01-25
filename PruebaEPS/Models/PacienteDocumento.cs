using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class PacienteDocumento
    {
        [Key]
        public Boolean Salida { get; set; }
        public string Mensaje { get; set; }
        public Int64 IDPaciente { get; set; }
    }
}
