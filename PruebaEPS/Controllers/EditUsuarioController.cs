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
    public class EditUsuarioController : Controller
    {
        private readonly Context _context;

        public EditUsuarioController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Usuarios> Get(int id)
        {
            string consulta = Queries.Querie("get_editusuarios");
            List<Usuarios> data = _context.usuario.FromSqlRaw(consulta + " " + id).ToList();
            return data.ToList();
        }
    }
}
