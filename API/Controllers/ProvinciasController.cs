using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Provincias")]
    public class ProvinciasController : Controller
    {

        private readonly ProvinciaContext _context;

        public ProvinciasController(ProvinciaContext context)
        {
            _context = context;
            _context.Provincias.Add(new Provincia { Id = 1, Name = "Arica", Id_Region = 1 });
            _context.Provincias.Add(new Provincia { Id = 2, Name = "Parinacota", Id_Region = 1 });
            _context.Provincias.Add(new Provincia { Id = 3, Name = "Iquique", Id_Region = 2 });
            _context.Provincias.Add(new Provincia { Id = 4, Name = "Tamarugal", Id_Region = 2});
            _context.Provincias.Add(new Provincia { Id = 5, Name = "Antofagasta", Id_Region = 3 });
            _context.Provincias.Add(new Provincia { Id = 6, Name = "El Loa", Id_Region = 3 });
            _context.Provincias.Add(new Provincia { Id = 7, Name = "Tocopilla", Id_Region = 3 });
            _context.Provincias.Add(new Provincia { Id = 8, Name = "Copiapó", Id_Region = 4 });
            _context.Provincias.Add(new Provincia { Id = 9, Name = "Chañaral", Id_Region = 4 });
            _context.Provincias.Add(new Provincia { Id = 10, Name = "Huasco", Id_Region = 4 });
            _context.Provincias.Add(new Provincia { Id = 11, Name = "Elqui", Id_Region = 5 });
            _context.Provincias.Add(new Provincia { Id = 12, Name = "Choapa", Id_Region = 5 });
            _context.Provincias.Add(new Provincia { Id = 13, Name = "Limarí", Id_Region = 5 });
            _context.Provincias.Add(new Provincia { Id = 14, Name = "Valparaíso", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 15, Name = "Isla de Pascua", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 16, Name = "Los Andes", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 17, Name = "Petorca", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 18, Name = "Quillota", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 19, Name = "San Antonio", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 20, Name = "San Felipe de Aconcagua", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 21, Name = "Marga Marga", Id_Region = 6 });
            _context.Provincias.Add(new Provincia { Id = 22, Name = "Cachapoal", Id_Region = 7 });
            _context.Provincias.Add(new Provincia { Id = 23, Name = "Cardenal Caro", Id_Region = 7 });
            _context.Provincias.Add(new Provincia { Id = 24, Name = "Colchagua", Id_Region = 7 });
            _context.Provincias.Add(new Provincia { Id = 25, Name = "Talca", Id_Region = 8 });
            _context.Provincias.Add(new Provincia { Id = 26, Name = "Cauquenes", Id_Region = 8 });
            _context.Provincias.Add(new Provincia { Id = 27, Name = "Curicó", Id_Region = 8 });
            _context.Provincias.Add(new Provincia { Id = 28, Name = "Linares", Id_Region = 8 });
            _context.Provincias.Add(new Provincia { Id = 29, Name = "Concepción", Id_Region = 9 });
            _context.Provincias.Add(new Provincia { Id = 30, Name = "Arauco", Id_Region = 9 });
            _context.Provincias.Add(new Provincia { Id = 31, Name = "Biobío", Id_Region = 9 });
            _context.Provincias.Add(new Provincia { Id = 32, Name = "Ñuble", Id_Region = 9 });
            _context.Provincias.Add(new Provincia { Id = 33, Name = "Cautín", Id_Region = 10 });
            _context.Provincias.Add(new Provincia { Id = 34, Name = "Malleco", Id_Region = 10 });
            _context.Provincias.Add(new Provincia { Id = 35, Name = "Valdivia", Id_Region = 11 });
            _context.Provincias.Add(new Provincia { Id = 36, Name = "Ranco", Id_Region = 11 });
            _context.Provincias.Add(new Provincia { Id = 37, Name = "Llanquihue", Id_Region = 12 });
            _context.Provincias.Add(new Provincia { Id = 38, Name = "Chiloé", Id_Region = 12 });
            _context.Provincias.Add(new Provincia { Id = 39, Name = "Osorno", Id_Region = 12 });
            _context.Provincias.Add(new Provincia { Id = 40, Name = "Palena", Id_Region = 12 });
            _context.Provincias.Add(new Provincia { Id = 41, Name = "Coyhaique", Id_Region = 13 });
            _context.Provincias.Add(new Provincia { Id = 42, Name = "Aisén", Id_Region = 13});
            _context.Provincias.Add(new Provincia { Id = 43, Name = "Capitán Prat", Id_Region = 13 });
            _context.Provincias.Add(new Provincia { Id = 44, Name = "General Carrera", Id_Region = 13 });
            _context.Provincias.Add(new Provincia { Id = 45, Name = "Magallanes", Id_Region = 14 });
            _context.Provincias.Add(new Provincia { Id = 46, Name = "Antártica Chilena", Id_Region = 14 });
            _context.Provincias.Add(new Provincia { Id = 47, Name = "Tierra del Fuego", Id_Region = 14 });
            _context.Provincias.Add(new Provincia { Id = 48, Name = "Ultima Esperanza", Id_Region = 14 });
            _context.Provincias.Add(new Provincia { Id = 49, Name = "Santiago", Id_Region = 15 });
            _context.Provincias.Add(new Provincia { Id = 50, Name = "CORDILLERA", Id_Region = 15 });
            _context.Provincias.Add(new Provincia { Id = 51, Name = "Chacabuco", Id_Region = 15 });
            _context.Provincias.Add(new Provincia { Id = 52, Name = "Maipo", Id_Region = 15 });
            _context.Provincias.Add(new Provincia { Id = 53, Name = "Melipilla", Id_Region = 15 });
            _context.Provincias.Add(new Provincia { Id = 54, Name = "Talagante", Id_Region = 15 });


        }

        [HttpGet]
        public IEnumerable<Provincia> GetAll()
        {
            return _context.Provincias.ToList();
        }


        [HttpGet("{id}", Name = "GetProvincias")]
        public IActionResult GetById(long id)
        {
            var item = _context.Provincias.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

    }
}