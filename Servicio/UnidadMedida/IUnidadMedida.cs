using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Servicio.UnidadMedida
{
    public interface IUnidadMedida
    {
        public List<Models.UnidadMedida> Proveedor();
        public bool save(Models.UnidadMedida Proveedor);
        public bool Modified(Models.UnidadMedida Proveedor);
        public void Delete(int id);
        public Models.UnidadMedida get(int id);
    }
}
