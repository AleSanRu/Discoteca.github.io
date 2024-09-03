using Microsoft.AspNetCore.Mvc;
using Discoteca.Models;
using System.Collections.Generic;
using System.Linq;

namespace Discoteca.Controllers
{
    [ApiController]
    [Route("Discoteca")]
    public class DiscotecaController : ControllerBase
    {
        //DATOS
        #region Datos Para Prueba
        private static List<DiscotecaDatos> discotecas = new List<DiscotecaDatos>
        {
            new DiscotecaDatos
{
    Id = 0001,
    Nombre = "DJD",
    Cover = 20,
    Propietario = "Marcelo",
    Tragos = 10,
    Ubicacion = "Nunca Jamas",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0002,
    Nombre = "Pepitos",
    Cover = 25,
    Propietario = "Juan Mata",
    Tragos = 15,
    Ubicacion = "Perez",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0003,
    Nombre = "El Rincón",
    Cover = 30,
    Propietario = "Ana López",
    Tragos = 12,
    Ubicacion = "Centro",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0004,
    Nombre = "La Cueva",
    Cover = 18,
    Propietario = "Luis García",
    Tragos = 8,
    Ubicacion = "Montaña",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0005,
    Nombre = "Bar&Roll",
    Cover = 22,
    Propietario = "Sofia Martínez",
    Tragos = 20,
    Ubicacion = "Plaza",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0006,
    Nombre = "The Spot",
    Cover = 27,
    Propietario = "Carlos Pérez",
    Tragos = 16,
    Ubicacion = "Avenida",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0007,
    Nombre = "El Lounge",
    Cover = 24,
    Propietario = "Verónica Ruiz",
    Tragos = 14,
    Ubicacion = "Norte",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0008,
    Nombre = "Café y Más",
    Cover = 19,
    Propietario = "Jorge Hernández",
    Tragos = 11,
    Ubicacion = "Sur",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0009,
    Nombre = "El Barón",
    Cover = 23,
    Propietario = "Laura Gómez",
    Tragos = 13,
    Ubicacion = "Este",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0010,
    Nombre = "Rumba y Cia",
    Cover = 28,
    Propietario = "Antonio Morales",
    Tragos = 18,
    Ubicacion = "Oeste",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0011,
    Nombre = "La Terraza",
    Cover = 26,
    Propietario = "Elena Vargas",
    Tragos = 17,
    Ubicacion = "Río",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0012,
    Nombre = "La Barra",
    Cover = 21,
    Propietario = "Federico Núñez",
    Tragos = 9,
    Ubicacion = "Lago",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0013,
    Nombre = "Chill Out",
    Cover = 29,
    Propietario = "María Pérez",
    Tragos = 22,
    Ubicacion = "Puerto",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0014,
    Nombre = "La Esquina",
    Cover = 31,
    Propietario = "Óscar García",
    Tragos = 25,
    Ubicacion = "Campo",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0015,
    Nombre = "Pub&Fun",
    Cover = 25,
    Propietario = "Mónica Fernández",
    Tragos = 20,
    Ubicacion = "Colina",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0016,
    Nombre = "Ritmo",
    Cover = 20,
    Propietario = "Ricardo López",
    Tragos = 10,
    Ubicacion = "Centro Histórico",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0017,
    Nombre = "El Refugio",
    Cover = 22,
    Propietario = "Cristina Ríos",
    Tragos = 14,
    Ubicacion = "Jardines",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0018,
    Nombre = "Los Amigos",
    Cover = 18,
    Propietario = "Luis Fernández",
    Tragos = 12,
    Ubicacion = "Zona Rosa",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0019,
    Nombre = "La Bodeguita",
    Cover = 30,
    Propietario = "Patricia Martínez",
    Tragos = 16,
    Ubicacion = "Playa",
    Activa = true
},
new DiscotecaDatos
{
    Id = 0020,
    Nombre = "Noche Viva",
    Cover = 27,
    Propietario = "Luis Castillo",
    Tragos = 19,
    Ubicacion = "Monte",
    Activa = true
}

        };
        #endregion
        //GET
        #region GET: /Discoteca/ListarDiscoteca
        [HttpGet]
        [Route("ListarDiscoteca")]
        public dynamic ListarDiscoteca()
        {
            return discotecas;
        }
        #endregion
        //POST
        #region POST: /Discoteca/GuardarDiscoteca
        [HttpPost]
        [Route("GuardarDiscoteca")]
        public IActionResult GuardarDiscoteca([FromBody] DiscotecaDatos nuevaDiscoteca)
        {
            discotecas.Add(nuevaDiscoteca);
            return Ok(new { mensaje = "Discoteca guardada correctamente", discoteca = nuevaDiscoteca });
        }
        #endregion
        //PUT
        #region PUT: /Discoteca/ActualizarDiscoteca/{id}
        [HttpPut]
        [Route("ActualizarDiscoteca/{id}")]
        public IActionResult ActualizarDiscoteca(int id, [FromBody] DiscotecaDatos discotecaActualizada)
        {
            var discoteca = discotecas.FirstOrDefault(d => d.Id == id);
            if (discoteca == null)
            {
                return NotFound(new { mensaje = "Discoteca no encontrada" });
            }

            discoteca.Nombre = discotecaActualizada.Nombre;
            discoteca.Cover = discotecaActualizada.Cover;
            discoteca.Propietario = discotecaActualizada.Propietario;
            discoteca.Tragos = discotecaActualizada.Tragos;
            discoteca.Ubicacion = discotecaActualizada.Ubicacion;
            discoteca.Activa = discotecaActualizada.Activa;

            return Ok(new { mensaje = "Discoteca actualizada correctamente", discoteca });
        }
        #endregion
        //DELETE
        #region /Discoteca/EliminarDiscoteca/{id}
        [HttpDelete]
        [Route("EliminarDiscoteca/{id}")]
        public IActionResult EliminarDiscoteca(int id)
        {
            var discoteca = discotecas.FirstOrDefault(d => d.Id == id);
            if (discoteca == null)
            {
                return NotFound(new { mensaje = "Discoteca no encontrada" });
            }

            discotecas.Remove(discoteca);
            return Ok(new { mensaje = "Discoteca eliminada correctamente" });
        }
        #endregion
    }
}
