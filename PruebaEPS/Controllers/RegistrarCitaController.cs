using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaEPS.Data;
using PruebaEPS.Models;
using PruebaEPS.Query;

namespace PruebaEPS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegistrarCitaController : Controller
    {
        private readonly Context _context;

        public RegistrarCitaController(Context context)
        {
            _context = context;
        }

        [HttpPost]
        public IEnumerable<SalidaRegitroCita> Post(RegistrarCita registrarCita)
        {
            string consulta = Queries.Querie("insert_cita");
            List<SalidaRegitroCita> data = _context.salidaRegitroCitas.FromSqlRaw(consulta + " " + registrarCita.IDUsuario + ", " + registrarCita.IDPaciente + ", " + registrarCita.IDSede + ", " + registrarCita.IDHoraCita + ", " + registrarCita.Fecha.ToString("yyyy-MM-dd")).ToList();
            return data.ToList();
        }
    }
}
