using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Materiales.Models
{
  
    public class Categoria
    {
   
        public int  IdCategoria {get;set;}
        public String NombreCategoria { get; set; }
        public bool EstadoCategoria { get; set; }
    }
}
