using Microsoft.AspNetCore.Http;
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
    public class DepartamentoController : Controller
    {
        private readonly Context _context;

        public DepartamentoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Departamento> Get()
        {
            string consulta = Queries.Querie("get_departamento");
            List<Departamento> data = _context.departamento.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
