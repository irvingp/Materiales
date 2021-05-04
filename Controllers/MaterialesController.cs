using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Servicio.Materiales;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Materiales.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialesController : ControllerBase
    {
        private IMateriales _servicio;


        public MaterialesController(IMateriales ServicioMateriales)
        {
            _servicio = ServicioMateriales;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<Models.Materiales> Get()
        {
            return _servicio.Materiales();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public Models.Materiales Get(int id)
        {
            return _servicio.get(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody] Models.Materiales _materiales)
        {
            Models.Materiales materiales = new Models.Materiales();
            materiales.Nombre = _materiales.Nombre;
            materiales.Precio = _materiales.Precio;
            materiales.Existencia = _materiales.Existencia;
            materiales.Descripción = _materiales.Descripción;
            materiales.Categoria = _materiales.Categoria;
            materiales.Proveedor = _materiales.Proveedor;
            materiales.UnidadMedida = _materiales.UnidadMedida;
          
            _servicio.save(materiales);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm] Models.Materiales _materiales)
        {
            Models.Materiales materiales = new Models.Materiales();
            materiales.IdMaterial = id;
            materiales.Nombre = _materiales.Nombre;
            materiales.Precio = _materiales.Precio;
            materiales.Existencia = _materiales.Existencia;
            materiales.Descripción = _materiales.Descripción;
            materiales.Categoria = _materiales.Categoria;
            materiales.Proveedor = _materiales.Proveedor;
            materiales.UnidadMedida = _materiales.UnidadMedida;
            _servicio.Modified(materiales);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
