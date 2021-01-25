using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Models
{
    public class TipoDocumento
    {
        [Key]
        public Int64 IDTipoDocumento { get; set; }
        public string Nombre { get; set; }
    }
}
