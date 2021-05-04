using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.Proveedor
{
    public interface IProveedor
    {
        public List<Models.Proveedor> Proveedor();
        public bool save(Models.Proveedor Proveedor);
        public bool Modified(Models.Proveedor Proveedor);
        public void Delete(int id);
        public Models.Proveedor get(int id);
    }
}
