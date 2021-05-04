using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.Materiales
{
    public interface IMateriales
    {
        public List<Models.Materiales> Materiales();
        public bool save(Models.Materiales Proveedor);
        public bool Modified(Models.Materiales Proveedor);
        public void Delete(int id);
        public Models.Materiales get(int id);
    }
}
