using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class Ciudad
    {
        [Key]
        public Int64 IDCiudad { get; set; }
        public string Nombre { get; set; }
    }
}
