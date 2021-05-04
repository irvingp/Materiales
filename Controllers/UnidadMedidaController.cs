using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Models;
using Materiales.Servicio.UnidadMedida;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Materiales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadMedidaController : ControllerBase
    {
        private IUnidadMedida _servicio;


        public UnidadMedidaController(IUnidadMedida ServicioUnidadMedida)
        {
            _servicio = ServicioUnidadMedida;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<UnidadMedida> Get()
        {
            return _servicio.Proveedor();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public UnidadMedida Get(int id)
        {
            return _servicio.get(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody] UnidadMedida unidadMedida)
        {
            UnidadMedida unidad = new UnidadMedida();
            unidad.NombreUnidadMedida = unidadMedida.NombreUnidadMedida;
            unidad.EstadoUnidadMedida = unidadMedida.EstadoUnidadMedida;
            _servicio.save(unidad);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm] String NombreUnidadMedida)
        {
            UnidadMedida unidad = new UnidadMedida();
            unidad.IdUnidadMedida = id;
            unidad.NombreUnidadMedida = NombreUnidadMedida;
            _servicio.Modified(unidad);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
