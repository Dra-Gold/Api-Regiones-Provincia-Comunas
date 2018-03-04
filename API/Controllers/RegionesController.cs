using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Regiones")]
    public class RegionesController : Controller
    {
        private readonly RegionContext _context;

        public RegionesController(RegionContext context)
        {
            _context = context;

            if (_context.Regiones.Count() == 0)
            {
                _context.Regiones.Add(new Region { Id=1, Name = "Arica y Parinacota", Orginal= "XV" });
                _context.Regiones.Add(new Region { Id =2, Name = "Tarapacá", Orginal = "I" });
                _context.Regiones.Add(new Region { Id = 3, Name = "Antofagasta", Orginal = "II" });
                _context.Regiones.Add(new Region { Id = 4, Name = "Atacama", Orginal = "III" });
                _context.Regiones.Add(new Region { Id = 5, Name = "Coquimbo", Orginal = "IV" });
                _context.Regiones.Add(new Region { Id = 6, Name = "Valparaiso", Orginal = "V" });
                _context.Regiones.Add(new Region { Id = 7, Name = "Libertador General Bernardo O\'Higgins", Orginal = "VI" });
                _context.Regiones.Add(new Region { Id = 8, Name = "Maule", Orginal = "VII" });
                _context.Regiones.Add(new Region { Id = 9, Name = "Biobío", Orginal = "VIII" });
                _context.Regiones.Add(new Region { Id = 10, Name = "La Araucanía", Orginal = "IX" });
                _context.Regiones.Add(new Region { Id = 11, Name = "Los Ríos", Orginal = "XIV" });
                _context.Regiones.Add(new Region { Id = 12, Name = "Los Lagos", Orginal = "X" });
                _context.Regiones.Add(new Region { Id = 13, Name = "Aisén del General Carlos Ibáñez del Campo", Orginal = "XI" });
                _context.Regiones.Add(new Region { Id = 14, Name = "Magallanes y de la Antártica Chilena", Orginal = "XII" });
                _context.Regiones.Add(new Region { Id = 15, Name = "Metropolitana de Santiago", Orginal = "RM" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Region> GetAll()
        {
            return _context.Regiones.ToList();
        }


        [HttpGet("{id}", Name = "GetRegiones")]
        public IActionResult GetById(long id)
        {
            var item = _context.Regiones.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }


    }
}