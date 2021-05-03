using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Models;
using Materiales.Repository;

namespace Materiales.Entities
{
    public class CategoriaEntidad : BaseRepository<Categoria>

    {
        private MaterialesContext context2;

        public CategoriaEntidad(MaterialesContext context)
        {
            this.context2 = context;
        }

        public List<Categoria> getCategorias()
        {
            List<Categoria> categorias;
            using (var contex = new MaterialesContext())
            {
                categorias = contex.Categoria.Where(x => x.EstadoCategoria == true).ToList();
            }
            return categorias;
        }

        public Categoria get(int id)
        {
            Categoria cat;
            using (var contex = new MaterialesContext())
            {
                cat = (Categoria)contex.Categoria.Where(x => x.IdCategoria == id).FirstOrDefault();
            }

            return cat;
        }

       
    }
}
