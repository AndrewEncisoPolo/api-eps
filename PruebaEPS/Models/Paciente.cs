using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace PruebaEPS.Models
{
    public class Paciente
    {
        [Key]
        public Int64 IDPaciente { get; set; }
        public string Nombre { get; set; }
        public string TipoDocumento { get; set; }
        public Int64 Documento { get; set; }
        public Int64 NroSeguroSocial { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Sede { get; set; }
        public Int64 CodigoPostal { get; set; }
        public string Direccion { get; set; }
        public Int64 Telefono { get; set; }
        public Int64 IDTipodocumento { get; set; }
        public Int64 IDDepartamento { get; set; }
        public Int64 IDCiudad { get; set; }
        public Int64 IDSede { get; set; }
    }
}
