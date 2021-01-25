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
    public class EditPacienteController : Controller
    {
        
        private readonly Context _context;

        public EditPacienteController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Paciente> Get(int id)
        {
            string consulta = Queries.Querie("get_editpaciente");
            List<Paciente> data = _context.paciente.FromSqlRaw(consulta+" "+id).ToList();
            return data.ToList();
        }

    }
}
