using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class HoraCita
    {
        [Key]
        public Int64 IDHoraCita { get; set; }
        public string Rango { get; set; }
    }
}
