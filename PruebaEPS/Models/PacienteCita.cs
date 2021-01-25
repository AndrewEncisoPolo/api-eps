using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class PacienteCita
    {
        [Key]
        public Int64 IDPaciente { get; set; }
        public string NombrePaciente { get; set; }
        public string TipoDocumento { get; set; }
        public Int64 Documento { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Sede { get; set; }
        public Int64 IDSede { get; set; }
    }
}
