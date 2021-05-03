using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales;

namespace Materiales.Servicio.Categoria
{
    interface ICategoria 
    {
        public List<Models.Categoria> Categorias();
        public bool save(Models.Categoria categoria);
        public bool Modified(Models.Categoria categoria);
        public bool Delete(int categoria);
        public Models.Categoria get(int id);

    }
}
