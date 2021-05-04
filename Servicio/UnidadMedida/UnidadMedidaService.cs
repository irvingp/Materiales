using Materiales.Models;
using Materiales.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.UnidadMedida
{
    public class UnidadMedidaService: BaseRepository<Models.UnidadMedida>, IUnidadMedida
    {
        private readonly MaterialesContext _context;

        public UnidadMedidaService(MaterialesContext context)
        {
            _context = context;

        }


        public List<Models.UnidadMedida> Proveedor()
        {
            List<Models.UnidadMedida> UnidadMedida;
            using (var contex = new MaterialesContext())
            {
                UnidadMedida = contex.UnidadMedida.Where(x => x.EstadoUnidadMedida == true).ToList();
            }
            return UnidadMedida;
        }

        public void Delete(int id)
        {
            using (var context = new MaterialesContext())
            {
                var UnidadMedida = context.UnidadMedida.Where(x => x.IdUnidadMedida == id);
                context.Entry(UnidadMedida).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Models.UnidadMedida get(int id)
        {
            Models.UnidadMedida UnidadMedida;
            using (var contex = new MaterialesContext())
            {
                UnidadMedida = contex.UnidadMedida.Where(x => x.IdUnidadMedida == id).FirstOrDefault();
            }

            return UnidadMedida;
        }
    }
}
