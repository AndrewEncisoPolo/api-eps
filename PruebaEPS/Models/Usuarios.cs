using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PruebaEPS.Models
{
    public class Usuarios
    {
        [Key]
        public Int64 IDUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public Int64 Documento { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Sede { get; set; }
        public string Direccion { get; set; }
        public Int64 IDTipoUsuario { get; set; }
        public Int64 IDTIpodocumento { get; set; }
        public Int64 IDDepartamento { get; set; }
        public Int64 IDCiudad { get; set; }
        public Int64 IDSede { get; set; }
    }
}
