using Materiales.Models;
using Materiales.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.Materiales
{
    public class MaterialesService : BaseRepository<Models.Materiales>, IMateriales
    {
        private readonly MaterialesContext _context;

        public MaterialesService(MaterialesContext context)
        {
            _context = context;

        }


        public List<Models.Materiales> Materiales()
        {
            List<Models.Materiales> Materiales;
            using (var contex = new MaterialesContext())
            {
                Materiales = contex.Materiales.Include(x => x.Proveedor).Include(x=>x.UnidadMedida).Include(x=>x.Categoria).ToList();
            }
            return Materiales;
        }

        public void Delete(int id)
        {
            using (var context = new MaterialesContext())
            {
                var Materiales = context.Materiales.Where(x => x.IdMaterial == id);
                context.Entry(Materiales).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Models.Materiales get(int id)
        {
            Models.Materiales Materiales;
            using (var contex = new MaterialesContext())
            {
                Materiales = contex.Materiales.Where(x => x.IdMaterial == id).FirstOrDefault();
            }

            return Materiales;
        }


    }
}
