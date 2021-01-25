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
    public class TipoDocumentoController : Controller
    {
        private readonly Context _context;

        public TipoDocumentoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TipoDocumento> Get()
        {
            string consulta = Queries.Querie("get_tipodocumento");
            List<TipoDocumento> data = _context.tipodocumento.FromSqlRaw(consulta).ToList();
            return data.ToList();
        }
    }
}
