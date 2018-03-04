﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Produces("application/json")]
    [Route("api/Comunas")]
    public class ComunasController : Controller
    {

        private readonly ComunaContext _context;

        public ComunasController(ComunaContext context)
        {
            _context = context;

            if (_context.Comunas.Count() == 0)
            {
                _context.Comunas.Add(new Comuna { Id = 1, Name = "Arica",  Id_Provincia = 1 });
                _context.Comunas.Add(new Comuna { Id = 2, Name = "Camarones", Id_Provincia = 1 });
                _context.Comunas.Add(new Comuna { Id = 3, Name = "Putre", Id_Provincia = 2 });
                _context.Comunas.Add(new Comuna { Id = 4, Name = "General Lagos",  Id_Provincia = 2 });
                _context.Comunas.Add(new Comuna { Id = 5, Name = "Iquique",  Id_Provincia = 3 });
                _context.Comunas.Add(new Comuna { Id = 6, Name = "Alto Hospicio",  Id_Provincia = 3 });
                _context.Comunas.Add(new Comuna { Id = 7, Name = "Pozo Almonte",  Id_Provincia = 4 });
                _context.Comunas.Add(new Comuna { Id = 8, Name = "Camiña",  Id_Provincia = 4 });
                _context.Comunas.Add(new Comuna { Id = 9, Name = "Colchane",  Id_Provincia = 4 });
                _context.Comunas.Add(new Comuna { Id = 10, Name = "Huara", Id_Provincia = 4 });
                _context.Comunas.Add(new Comuna { Id = 11, Name = "Pica", Id_Provincia = 4 });
                _context.Comunas.Add(new Comuna { Id = 12, Name = "Antofagasta", Id_Provincia = 5 });
                _context.Comunas.Add(new Comuna { Id = 13, Name = "Mejillones", Id_Provincia = 5 });
                _context.Comunas.Add(new Comuna { Id = 14, Name = "Sierra Gorda", Id_Provincia = 5 });
                _context.Comunas.Add(new Comuna { Id = 15, Name = "Taltal", Id_Provincia = 5 });
                _context.Comunas.Add(new Comuna { Id = 16, Name = "Calama", Id_Provincia = 6 });
                _context.Comunas.Add(new Comuna { Id = 17, Name = "Ollague", Id_Provincia = 6 });
                _context.Comunas.Add(new Comuna { Id = 18, Name = "San Pedro de Atacama", Id_Provincia = 6 });
                _context.Comunas.Add(new Comuna { Id = 19, Name = "Tocopilla", Id_Provincia = 7 });
                _context.Comunas.Add(new Comuna { Id = 20, Name = "María Elena", Id_Provincia = 7 });
                _context.Comunas.Add(new Comuna { Id = 21, Name = "Copiapó", Id_Provincia = 8 });
                _context.Comunas.Add(new Comuna { Id = 22, Name = "Caldera", Id_Provincia = 8 });
                _context.Comunas.Add(new Comuna { Id = 23, Name = "Tierra Amarilla", Id_Provincia = 8 });
                _context.Comunas.Add(new Comuna { Id = 24, Name = "Chañaral", Id_Provincia = 9 });
                _context.Comunas.Add(new Comuna { Id = 25, Name = "Diego de Almagro", Id_Provincia = 9 });
                _context.Comunas.Add(new Comuna { Id = 26, Name = "Vallenar", Id_Provincia = 10 });
                _context.Comunas.Add(new Comuna { Id = 27, Name = "Alto del Carmen", Id_Provincia = 10 });
                _context.Comunas.Add(new Comuna { Id = 28, Name = "Freirina", Id_Provincia = 10 });
                _context.Comunas.Add(new Comuna { Id = 29, Name = "Huasco", Id_Provincia = 10 });
                _context.Comunas.Add(new Comuna { Id = 30, Name = "La Serena", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 31, Name = "Coquimbo", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 32, Name = "Andacollo", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 33, Name = "La Higuera", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 34, Name = "Paiguano", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 35, Name = "Vicuña", Id_Provincia = 11 });
                _context.Comunas.Add(new Comuna { Id = 36, Name = "Illapel", Id_Provincia = 12 });
                _context.Comunas.Add(new Comuna { Id = 37, Name = "Canela", Id_Provincia = 12 });
                _context.Comunas.Add(new Comuna { Id = 38, Name = "Los Vilos", Id_Provincia = 12 });
                _context.Comunas.Add(new Comuna { Id = 39, Name = "Salamanca", Id_Provincia = 12 });
                _context.Comunas.Add(new Comuna { Id = 40, Name = "Ovalle", Id_Provincia = 13 });
                _context.Comunas.Add(new Comuna { Id = 41, Name = "Combarbalá", Id_Provincia = 13 });
                _context.Comunas.Add(new Comuna { Id = 42, Name = "Monte Patria", Id_Provincia = 13 });
                _context.Comunas.Add(new Comuna { Id = 43, Name = "Punitaqui", Id_Provincia = 13 });
                _context.Comunas.Add(new Comuna { Id = 44, Name = "Río Hurtado", Id_Provincia = 13 });
                _context.Comunas.Add(new Comuna { Id = 45, Name = "Valparaíso", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 46, Name = "Casablanca", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 47, Name = "Concón", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 48, Name = "Juan Fernández", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 49, Name = "Puchuncaví", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 50, Name = "Quintero", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 51, Name = "Viña del Mar", Id_Provincia = 14 });
                _context.Comunas.Add(new Comuna { Id = 52, Name = "Isla de Pascua", Id_Provincia = 15 });
                _context.Comunas.Add(new Comuna { Id = 53, Name = "Los Andes", Id_Provincia = 16 });
                _context.Comunas.Add(new Comuna { Id = 54, Name = "Calle Larga", Id_Provincia = 16 });
                _context.Comunas.Add(new Comuna { Id = 55, Name = "Rinconada", Id_Provincia = 16 });
                _context.Comunas.Add(new Comuna { Id = 56, Name = "San Esteban", Id_Provincia = 16 });
                _context.Comunas.Add(new Comuna { Id = 57, Name = "La Ligua", Id_Provincia = 17 });
                _context.Comunas.Add(new Comuna { Id = 58, Name = "Cabildo", Id_Provincia = 17 });
                _context.Comunas.Add(new Comuna { Id = 59, Name = "Papudo", Id_Provincia = 17 });
                _context.Comunas.Add(new Comuna { Id = 60, Name = "Petorca", Id_Provincia = 17 });
                _context.Comunas.Add(new Comuna { Id = 61, Name = "Zapallar", Id_Provincia = 17 });
                _context.Comunas.Add(new Comuna { Id = 62, Name = "Quillota", Id_Provincia = 18 });
                _context.Comunas.Add(new Comuna { Id = 63, Name = "Calera", Id_Provincia = 18 });
                _context.Comunas.Add(new Comuna { Id = 64, Name = "Hijuelas", Id_Provincia = 18 });
                _context.Comunas.Add(new Comuna { Id = 65, Name = "La Cruz", Id_Provincia = 18 });
                _context.Comunas.Add(new Comuna { Id = 66, Name = "Nogales", Id_Provincia = 18 });
                _context.Comunas.Add(new Comuna { Id = 67, Name = "San Antonio", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 68, Name = "Algarrobo", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 69, Name = "Cartagena", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 70, Name = "El Quisco", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 71, Name = "El Tabo", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 72, Name = "Santo Domingo", Id_Provincia = 19 });
                _context.Comunas.Add(new Comuna { Id = 73, Name = "San Felipe", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 74, Name = "Catemu", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 75, Name = "Llaillay", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 76, Name = "Panquehueo", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 77, Name = "Putaendo", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 78, Name = "Santa María", Id_Provincia = 20 });
                _context.Comunas.Add(new Comuna { Id = 79, Name = "Limache", Id_Provincia = 21 });
                _context.Comunas.Add(new Comuna { Id = 80, Name = "Quilpué", Id_Provincia = 21 });
                _context.Comunas.Add(new Comuna { Id = 81, Name = "Villa Alemana", Id_Provincia = 21 });
                _context.Comunas.Add(new Comuna { Id = 82, Name = "Olmué", Id_Provincia = 21 });
                _context.Comunas.Add(new Comuna { Id = 83, Name = "Rancagua", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 84, Name = "Codegua", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 85, Name = "Coinco", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 86, Name = "Coltauco", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 87, Name = "Doñihue", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 88, Name = "Graneros", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 89, Name = "Las Cabras", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 90, Name = "Machalí", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 91, Name = "Malloa", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 92, Name = "Mostazal", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 93, Name = "Olivar", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 94, Name = "Peumo", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 95, Name = "Pichidegua", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 96, Name = "Quinta de Tilcoco", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 97, Name = "Rengo", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 98, Name = "Requínoa", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 99, Name = "San Vicente", Id_Provincia = 22 });
                _context.Comunas.Add(new Comuna { Id = 100, Name = "Pichilemu", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 101, Name = "La Estrella", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 102, Name = "Litueche", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 103, Name = "Marchihue", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 104, Name = "Navidad", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 105, Name = "Paredones", Id_Provincia = 23 });
                _context.Comunas.Add(new Comuna { Id = 106, Name = "San Fernando", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 107, Name = "Chépica", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 108, Name = "Chimbarongo", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 109, Name = "Lolol", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 110, Name = "Nancagua", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 111, Name = "Palmilla", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 112, Name = "Peralillo", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 113, Name = "Placilla", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 114, Name = "Pumanque", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 115, Name = "Santa Cruz", Id_Provincia = 24 });
                _context.Comunas.Add(new Comuna { Id = 116, Name = "Talca", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 117, Name = "Constitución", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 118, Name = "Curepto", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 119, Name = "Empedrado", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 120, Name = "Maule", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 121, Name = "Pelarco", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 122, Name = "Pencahue", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 123, Name = "Río Claro", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 124, Name = "San Clemente", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 125, Name = "San Rafael", Id_Provincia = 25 });
                _context.Comunas.Add(new Comuna { Id = 126, Name = "Cauquenes", Id_Provincia = 26 });
                _context.Comunas.Add(new Comuna { Id = 127, Name = "Chanco", Id_Provincia = 26 });
                _context.Comunas.Add(new Comuna { Id = 128, Name = "Pelluhue", Id_Provincia = 26 });
                _context.Comunas.Add(new Comuna { Id = 129, Name = "Curicó", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 130, Name = "Hualañé", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 131, Name = "Licantén", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 132, Name = "Molina", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 133, Name = "Rauco", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 134, Name = "Romeral", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 135, Name = "Sagrada Familia", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 136, Name = "Teno", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 137, Name = "Vichuquén", Id_Provincia = 27 });
                _context.Comunas.Add(new Comuna { Id = 138, Name = "Linares", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 139, Name = "Colbún", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 140, Name = "Longaví", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 141, Name = "Parral", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 142, Name = "Retiro", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 143, Name = "San Javier", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 144, Name = "Villa Alegre", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 145, Name = "Yerbas Buenas", Id_Provincia = 28 });
                _context.Comunas.Add(new Comuna { Id = 146, Name = "Concepción", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 147, Name = "Coronel", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 148, Name = "Chiguayante", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 149, Name = "Florida", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 150, Name = "Hualqui", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 151, Name = "Lota", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 152, Name = "Penco", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 153, Name = "San Pedro de la Paz", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 154, Name = "Santa Juana", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 155, Name = "Talcahuano", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 156, Name = "Tomé", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 157, Name = "Hualpén", Id_Provincia = 29 });
                _context.Comunas.Add(new Comuna { Id = 158, Name = "Lebu", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 159, Name = "Arauco", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 160, Name = "Cañete", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 161, Name = "Contulmo", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 162, Name = "Curanilahue", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 163, Name = "Los Alamos", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 164, Name = "Tirúa", Id_Provincia = 30 });
                _context.Comunas.Add(new Comuna { Id = 165, Name = "Los Angeles", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 166, Name = "Antuco", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 167, Name = "Cabrero", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 168, Name = "Laja", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 169, Name = "Mulchén", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 170, Name = "Nacimiento", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 171, Name = "Negrete", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 172, Name = "Quilaco", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 173, Name = "Quilleco", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 174, Name = "San Rosendo", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 175, Name = "Santa Bárbara", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 176, Name = "Tucapel", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 177, Name = "Yumbel", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 178, Name = "Alto Biobío", Id_Provincia = 31 });
                _context.Comunas.Add(new Comuna { Id = 179, Name = "Chillán", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 180, Name = "Bulnes", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 181, Name = "Cobquecura", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 182, Name = "Coelemu", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 183, Name = "Coihueco", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 184, Name = "Chillán Viejo", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 185, Name = "El Carmen", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 186, Name = "Ninhue", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 187, Name = "Ñiquén", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 188, Name = "Pemuco", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 189, Name = "Pinto", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 190, Name = "Portezuelo", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 191, Name = "Quillón", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 192, Name = "Quirihue", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 193, Name = "Ránquil", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 194, Name = "San Carlos", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 195, Name = "San Fabián", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 196, Name = "San Ignacio", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 197, Name = "San Nicolás", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 198, Name = "Treguaco", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 199, Name = "Yungay", Id_Provincia = 32 });
                _context.Comunas.Add(new Comuna { Id = 200, Name = "Temuco", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 201, Name = "Carahue", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 202, Name = "Cunco", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 203, Name = "Curarrehue", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 204, Name = "Freire", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 205, Name = "Galvarino", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 206, Name = "Gorbea", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 207, Name = "Lautaro", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 208, Name = "Loncoche", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 209, Name = "Melipeuco", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 210, Name = "Nueva Imperial", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 211, Name = "Padre Las Casas", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 212, Name = "Perquenco", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 213, Name = "Pitrufquén", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 214, Name = "Pucón", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 215, Name = "Saavedra", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 216, Name = "Teodoro Schmidt", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 217, Name = "Toltén", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 218, Name = "Vilcún", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 219, Name = "Villarrica", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 220, Name = "Cholchol", Id_Provincia = 33 });
                _context.Comunas.Add(new Comuna { Id = 221, Name = "Angol", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 222, Name = "Collipulli", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 223, Name = "Curacautín", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 224, Name = "Ercilla", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 225, Name = "Lonquimay", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 226, Name = "Los Sauces", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 227, Name = "Lumaco", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 228, Name = "Purén", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 229, Name = "Renaico", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 230, Name = "Traiguén", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 231, Name = "Victoria", Id_Provincia = 34 });
                _context.Comunas.Add(new Comuna { Id = 232, Name = "Valdivia", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 233, Name = "Corral", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 234, Name = "Lanco", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 235, Name = "Los Lagos", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 236, Name = "Máfil", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 237, Name = "Mariquina", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 238, Name = "Paillaco", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 239, Name = "Panguipulli", Id_Provincia = 35 });
                _context.Comunas.Add(new Comuna { Id = 240, Name = "La Unión", Id_Provincia = 36 });
                _context.Comunas.Add(new Comuna { Id = 241, Name = "Futrono", Id_Provincia = 36 });
                _context.Comunas.Add(new Comuna { Id = 242, Name = "Lago Ranco", Id_Provincia = 36 });
                _context.Comunas.Add(new Comuna { Id = 243, Name = "Río Bueno", Id_Provincia = 36 });
                _context.Comunas.Add(new Comuna { Id = 244, Name = "Puerto Montt", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 245, Name = "Calbuco", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 246, Name = "Cochamó", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 247, Name = "Fresia", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 248, Name = "Frutillar", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 249, Name = "Los Muermos", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 250, Name = "Llanquihue", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 251, Name = "Maullín", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 252, Name = "Puerto Varas", Id_Provincia = 37 });
                _context.Comunas.Add(new Comuna { Id = 253, Name = "Castro", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 254, Name = "Ancud", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 255, Name = "Chonchi", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 256, Name = "Curaco de Vélez", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 257, Name = "Dalcahue", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 258, Name = "Puqueldón", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 259, Name = "Queilén", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 260, Name = "Quellón", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 261, Name = "Quemchi", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 262, Name = "Quinchao", Id_Provincia = 38 });
                _context.Comunas.Add(new Comuna { Id = 263, Name = "Osorno", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 264, Name = "Puerto Octay", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 265, Name = "Purranque", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 266, Name = "Puyehue", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 267, Name = "Río Negro", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 268, Name = "San Juan de la Costa", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 269, Name = "San Pablo", Id_Provincia = 39 });
                _context.Comunas.Add(new Comuna { Id = 270, Name = "Chaitén", Id_Provincia = 40 });
                _context.Comunas.Add(new Comuna { Id = 271, Name = "Futaleufú", Id_Provincia = 40 });
                _context.Comunas.Add(new Comuna { Id = 272, Name = "Hualaihué", Id_Provincia = 40 });
                _context.Comunas.Add(new Comuna { Id = 273, Name = "Palena", Id_Provincia = 40 });
                _context.Comunas.Add(new Comuna { Id = 274, Name = "Coyhaique", Id_Provincia = 41 });
                _context.Comunas.Add(new Comuna { Id = 275, Name = "Lago Verde", Id_Provincia = 41 });
                _context.Comunas.Add(new Comuna { Id = 276, Name = "Aisén", Id_Provincia = 42 });
                _context.Comunas.Add(new Comuna { Id = 277, Name = "Cisnes", Id_Provincia = 42 });
                _context.Comunas.Add(new Comuna { Id = 278, Name = "Guaitecas", Id_Provincia = 42 });
                _context.Comunas.Add(new Comuna { Id = 279, Name = "Cochrane", Id_Provincia = 43 });
                _context.Comunas.Add(new Comuna { Id = 280, Name = "O'Higgins", Id_Provincia = 43 });
                _context.Comunas.Add(new Comuna { Id = 281, Name = "Tortel", Id_Provincia = 43 });
                _context.Comunas.Add(new Comuna { Id = 282, Name = "Chile Chico", Id_Provincia = 44 });
                _context.Comunas.Add(new Comuna { Id = 283, Name = "Río Ibáñez", Id_Provincia = 44 });
                _context.Comunas.Add(new Comuna { Id = 284, Name = "Punta Arenas", Id_Provincia = 45 });
                _context.Comunas.Add(new Comuna { Id = 285, Name = "Laguna Blanca", Id_Provincia = 45 });
                _context.Comunas.Add(new Comuna { Id = 286, Name = "Río Verde", Id_Provincia = 45 });
                _context.Comunas.Add(new Comuna { Id = 287, Name = "San Gregorio", Id_Provincia = 45 });
                _context.Comunas.Add(new Comuna { Id = 288, Name = "Cabo de Hornos", Id_Provincia = 46 });
                _context.Comunas.Add(new Comuna { Id = 289, Name = "Antártica", Id_Provincia = 46 });
                _context.Comunas.Add(new Comuna { Id = 290, Name = "Porvenir", Id_Provincia = 47 });
                _context.Comunas.Add(new Comuna { Id = 291, Name = "Primavera", Id_Provincia = 47 });
                _context.Comunas.Add(new Comuna { Id = 292, Name = "Timaukel", Id_Provincia = 47 });
                _context.Comunas.Add(new Comuna { Id = 293, Name = "Natales", Id_Provincia = 48 });
                _context.Comunas.Add(new Comuna { Id = 294, Name = "Torres del Paine", Id_Provincia = 48 });
                _context.Comunas.Add(new Comuna { Id = 295, Name = "Santiago", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 296, Name = "Cerrillos", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 297, Name = "Cerro Navia", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 298, Name = "Conchalí", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 299, Name = "El Bosque", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 300, Name = "Estación Central", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 301, Name = "Huechuraba", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 302, Name = "Independencia", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 303, Name = "La Cisterna", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 304, Name = "La Florida", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 305, Name = "La Granja", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 306, Name = "La Pintana", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 307, Name = "La Reina", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 308, Name = "Las Condes", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 309, Name = "Lo Barnechea", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 310, Name = "Lo Espejo", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 311, Name = "Lo Prado", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 312, Name = "Macul", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 313, Name = "Maipú", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 314, Name = "Ñuñoa", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 315, Name = "Pedro Aguirre Cerda", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 316, Name = "Peñalolén", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 317, Name = "Providencia", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 318, Name = "Pudahuel", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 319, Name = "Quilicura", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 320, Name = "Quinta Normal", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 321, Name = "Recoleta", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 322, Name = "Renca", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 323, Name = "San Joaquín", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 324, Name = "San Miguel", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 325, Name = "San Ramón", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 326, Name = "Vitacura", Id_Provincia = 49 });
                _context.Comunas.Add(new Comuna { Id = 327, Name = "Puente Alto", Id_Provincia = 50 });
                _context.Comunas.Add(new Comuna { Id = 328, Name = "Pirque", Id_Provincia = 50 });
                _context.Comunas.Add(new Comuna { Id = 329, Name = "San José de Maipo", Id_Provincia = 50 });
                _context.Comunas.Add(new Comuna { Id = 330, Name = "Colina", Id_Provincia = 51 });
                _context.Comunas.Add(new Comuna { Id = 331, Name = "Lampa", Id_Provincia = 51 });
                _context.Comunas.Add(new Comuna { Id = 332, Name = "Tiltil", Id_Provincia = 51 });
                _context.Comunas.Add(new Comuna { Id = 333, Name = "San Bernardo", Id_Provincia = 52 });
                _context.Comunas.Add(new Comuna { Id = 334, Name = "Buin", Id_Provincia = 52 });
                _context.Comunas.Add(new Comuna { Id = 335, Name = "Calera de Tango", Id_Provincia = 52 });
                _context.Comunas.Add(new Comuna { Id = 336, Name = "Paine", Id_Provincia = 52 });
                _context.Comunas.Add(new Comuna { Id = 337, Name = "Melipilla", Id_Provincia = 53 });
                _context.Comunas.Add(new Comuna { Id = 338, Name = "Alhué", Id_Provincia = 53 });
                _context.Comunas.Add(new Comuna { Id = 339, Name = "Curacaví", Id_Provincia = 53 });
                _context.Comunas.Add(new Comuna { Id = 340, Name = "María Pinto", Id_Provincia = 53 });
                _context.Comunas.Add(new Comuna { Id = 341, Name = "San Pedro", Id_Provincia = 53 });
                _context.Comunas.Add(new Comuna { Id = 342, Name = "Talagante", Id_Provincia = 54 });
                _context.Comunas.Add(new Comuna { Id = 343, Name = "El Monte", Id_Provincia = 54 });
                _context.Comunas.Add(new Comuna { Id = 344, Name = "Isla de Maipo", Id_Provincia = 54 });
                _context.Comunas.Add(new Comuna { Id = 345, Name = "Padre Hurtado", Id_Provincia = 54 });
                _context.Comunas.Add(new Comuna { Id = 346, Name = "Peñaflor", Id_Provincia = 54 });
            
                _context.SaveChanges();

    }
        }

        [HttpGet]
        public IEnumerable<Comuna> GetAll()
        {
            return _context.Comunas.ToList();
        }


        [HttpGet("{id}", Name = "GetComunas")]
        public IActionResult GetById(long id)
        {
            var item = _context.Comunas.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }



    }
}