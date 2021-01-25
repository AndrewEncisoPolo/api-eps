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
    public class DoctorController : Controller
    {
        private readonly Context _context;

        public DoctorController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Doctor> Get(int sede, int especializacion)
        {
            string consulta = Queries.Querie("get_doctor");
            List<Doctor> data = _context.doctor.FromSqlRaw(consulta+" "+sede+", "+ especializacion).ToList();
            return data.ToList();
        }
    }
}
