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
    public class PacienteDocumentoController : Controller
    {
        private readonly Context _context;

        public PacienteDocumentoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PacienteDocumento> Get(int documento)
        {
            string consulta = Queries.Querie("get_paciente_documento");
            List<PacienteDocumento> data = _context.pacientedocumento.FromSqlRaw(consulta+" "+documento).ToList();
            return data.ToList();
        }
    }
}
