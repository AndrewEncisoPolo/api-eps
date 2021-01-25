using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaEPS.Models;

namespace PruebaEPS.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option) : base(option)
        {

        }

        public DbSet<Departamento> departamento { get; set; }
        public DbSet<Especializacion> especializacion { get; set; }
        public DbSet<HoraCita> horacita { get; set; }
        public DbSet<TipoDocumento> tipodocumento { get; set; }
        public DbSet<TipoUsuario> tipousuario { get; set; }
        public DbSet<Cita> cita { get; set; }
        public DbSet<Paciente> paciente { get; set; }
        public DbSet<Usuarios> usuario { get; set; }
        public DbSet<PacienteCita> pacientecita { get; set; }
        public DbSet<PacienteDocumento> pacientedocumento { get; set; }
        public DbSet<Doctor> doctor { get; set; }
        public DbSet<RegistrarCita> registrarcita {get; set;}
        public DbSet<SalidaRegitroCita> salidaRegitroCitas { get; set; }
        public DbSet<Ciudad> ciudad { get; set; }
    }
}
