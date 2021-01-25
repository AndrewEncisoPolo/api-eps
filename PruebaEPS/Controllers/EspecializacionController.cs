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
    public class EspecializacionController : Controller
    {
        private readonly Context _context;

        public EspecializacionController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Especializacion> Get()
        {
            string consulta = Queries.Querie("get_especializacion");
            List<Especializacion> data = _context.especializacion.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
