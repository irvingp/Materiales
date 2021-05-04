using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Materiales.Servicio.Categoria;
using Materiales.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Materiales.Controllers
{
       
   
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private ICategoria _servicio;
      

        public CategoriaController(ICategoria ServiceCategoria)
        {
            _servicio = ServiceCategoria;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public IEnumerable<Categoria> Get()
        {
            return _servicio.Categorias();            
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public Categoria Get(int id)
        {
            return _servicio.get(id);
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public void Post([FromBody] Categoria Cate)
        {
            Categoria cat = new Categoria();
            cat.NombreCategoria = Cate.NombreCategoria;
            cat.EstadoCategoria = Cate.EstadoCategoria;
            _servicio.save(cat);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromForm] String NombreCategoria)
        {
            Categoria cat = new Categoria();
            cat.IdCategoria = id;
            cat.NombreCategoria = NombreCategoria;
            _servicio.Modified(cat);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _servicio.Delete(id);
        }
    }
}
