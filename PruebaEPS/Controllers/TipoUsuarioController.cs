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
    public class TipoUsuarioController : Controller
    {
        private readonly Context _context;

        public TipoUsuarioController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoUsuario> Get()
        {
            string consulta = Queries.Querie("get_tipousuario");
            List<TipoUsuario> data = _context.tipousuario.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
