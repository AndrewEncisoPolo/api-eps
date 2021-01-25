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
    public class UsuariosController : Controller
    {
        private readonly Context _context;

        public UsuariosController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            string consulta = Queries.Querie("get_usuarios");
            List<Usuarios> data = _context.usuario.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
