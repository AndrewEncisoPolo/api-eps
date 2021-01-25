using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class RegistrarCita
    {
        [Key]
        public Int64 IDUsuario { get; set; }
        public Int64 IDPaciente { get; set; }
        public Int64 IDSede { get; set; }
        public Int64 IDHoraCita { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class SalidaRegitroCita { 
        [Key]
        public Boolean Salida { get; set; }
        public string Mensaje { get; set; }
    }
}
