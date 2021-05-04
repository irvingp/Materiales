using Materiales.Models;
using Materiales.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.Proveedor
{
    public class ProveedorService: BaseRepository<Models.Proveedor>, IProveedor
    {
        private readonly MaterialesContext _context;

        public ProveedorService(MaterialesContext context)
        {
            _context = context;

        }


        public List<Models.Proveedor> Proveedor()
        {
            List<Models.Proveedor> categorias;
            using (var contex = new MaterialesContext())
            {
                categorias = contex.Proveedor.Where(x => x.EstadoProveedor == true).ToList();
            }
            return categorias;
        }

        public void Delete(int id)
        {
            using (var context = new MaterialesContext())
            {
                var cat = context.Proveedor.Where(x => x.IdProveedor == id);
                context.Entry(cat).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Models.Proveedor get(int id)
        {
            Models.Proveedor cat;
            using (var contex = new MaterialesContext())
            {
                cat = contex.Proveedor.Where(x => x.IdProveedor == id).FirstOrDefault();
            }

            return cat;
        }

    }
}
