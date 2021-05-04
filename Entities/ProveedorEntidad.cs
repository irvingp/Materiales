using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Models;
using Materiales.Repository;

namespace Materiales.Entities
{
    public class ProveedorEntidad : BaseRepository<ProveedorEntidad>
    {
        MaterialesContext context2;

        public ProveedorEntidad(MaterialesContext context)
        {
            this.context2 = context;
        }

        public List<Proveedor> getCategorias()
        {
            List<Proveedor> proveedor;
            using (var contex = new MaterialesContext())
            {
                proveedor = contex.Proveedor.Where(x => x.EstadoProveedor == true).ToList();
            }
            return proveedor;
        }

        public Proveedor get(int id)
        {
            Proveedor cat;
            using (var contex = new MaterialesContext())
            {
                cat = contex.Proveedor.Where(x => x.IdProveedor == id).FirstOrDefault();
            }

            return cat;
        }

    }
}
