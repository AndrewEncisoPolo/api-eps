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
    public class HoraCitaController : Controller
    {
        private readonly Context _context;

        public HoraCitaController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<HoraCita> Get(int iddoctor, DateTime fecha)
        {
            string consulta = Queries.Querie("get_agendadisponible");
            List<HoraCita> data = _context.horacita.FromSqlRaw(consulta+" "+iddoctor+", '"+fecha.ToString("yyyy-MM-dd")+"'").ToList();
            return data.ToList();
        }
    }
}
