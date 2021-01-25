using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class Doctor
    {
        [Key]
        public Int64 IDUsuario { get; set; }
        public string Nombre { get; set; }
    }
}
