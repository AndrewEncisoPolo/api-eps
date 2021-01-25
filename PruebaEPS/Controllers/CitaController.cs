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
    public class CitaController : Controller
    {
        private readonly Context _context;

        public CitaController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cita> Get()
        {
            string consulta = Queries.Querie("get_cita");
            List<Cita> data = _context.cita.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
