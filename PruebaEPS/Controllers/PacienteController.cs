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
    public class PacienteController : Controller
    {
        private readonly Context _context;

        public PacienteController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Paciente> Get()
        {
            string consulta = Queries.Querie("get_paciente");
            List<Paciente> data = _context.paciente.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
