using Materiales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Materiales.Servicio.Categoria
{
    public class CategorisaServicio : ICategoria
    {
        private Entities.CategoriaEntidad _entity;
       

        public CategorisaServicio(MaterialesContext context)
        {

            _entity = new Entities.CategoriaEntidad(context);
        }

        public List<Models.Categoria> Categorias()
        {
          
            return _entity.getCategorias();
           
        }

        public bool Delete(int id)
        {
            Models.Categoria cat = new Models.Categoria();
            using (var context = new MaterialesContext())
            {
                cat = (Models.Categoria)context.Categoria.Where(x => x.IdCategoria == id).FirstOrDefault();
            }
            return _entity.Delete(cat);
        }

        public bool Modified(Models.Categoria categoria)
        {
            return _entity.Modified(categoria);
        }

        public bool save(Models.Categoria categoria)
        {
            return _entity.Add(categoria);
        }

        public Models.Categoria get(int id)
        {

            return _entity.get(id);
        }
    }
}
