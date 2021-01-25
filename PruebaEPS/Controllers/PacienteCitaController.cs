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
    public class PacienteCitaController : Controller
    {
        private readonly Context _context;

        public PacienteCitaController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PacienteCita> Get(int id)
        {
            string consulta = Queries.Querie("get_paciente_id");
            List<PacienteCita> data = _context.pacientecita.FromSqlRaw(consulta+" "+id).ToList();
            return data.ToList();
        }
    }
}
