using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Models;
using Materiales.Servicio.Proveedor;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Materiales.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private IProveedor _servicio;


        public ProveedorController(IProveedor ServiceCategoria)
        {
            _servicio = ServiceCategoria;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<Proveedor> Get()
        {
            return _servicio.Proveedor();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public Proveedor Get(int id)
        {
            return _servicio.get(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody] Proveedor prov)
        {
            Proveedor Proveedor = new Proveedor();
            Proveedor.NombreProveedor = prov.NombreProveedor;
            Proveedor.EstadoProveedor = prov.EstadoProveedor;
            _servicio.save(Proveedor);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm] String NombreProveedor)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = id;
            proveedor.NombreProveedor = NombreProveedor;
            _servicio.Modified(proveedor);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
