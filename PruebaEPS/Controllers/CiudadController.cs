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
    public class CiudadController : Controller
    {
        private readonly Context _context;

        public CiudadController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Ciudad> Get(int id)
        {
            string consulta = Queries.Querie("get_ciudad");
            List<Ciudad> data = _context.ciudad.FromSqlRaw(consulta+" "+id).ToList();
            return data.ToList();
        }
    }
}
