using Materiales.Models;
using Materiales.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Materiales.Servicio.Categoria
{
    public class CategorisaServicio : BaseRepository<Models.Categoria>,  ICategoria
    {
       
        private readonly MaterialesContext _context;
       
        public CategorisaServicio(MaterialesContext context)
        {
            _context = context;
           
        }            
       

        public List<Models.Categoria> Categorias()
        {
            List<Models.Categoria> categorias;
            using (var contex = new MaterialesContext())
            {
                categorias = contex.Categoria.Where(x => x.EstadoCategoria == true).ToList();
            }
            return categorias;
        }

        public void  Delete(int categoria)
        {
            using (var context = new MaterialesContext())
            {
                var cat = context.Categoria.Where(x => x.IdCategoria == categoria);
                context.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();                
            }
        }

        public Models.Categoria get(int id)
        {
            Models.Categoria cat;
            using (var contex = new MaterialesContext())
            {
                cat = contex.Categoria.Where(x => x.IdCategoria == id).FirstOrDefault();
            }

            return cat;
        }

        
    }
}
