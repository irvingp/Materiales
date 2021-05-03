using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Models
{
    public class Materiales
    {
        public int IdMaterial { get; set; }
        public String Nombre { get; set; }
        public String Descripción { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }
        public Proveedor Proveedor { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        public decimal Existencia { get; set; }
    }
}
