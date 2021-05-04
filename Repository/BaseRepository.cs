using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Materiales.Models;

namespace Materiales.Repository
{
    public class BaseRepository<T>
    {
       
        public bool save(T entidad)
        {
            bool a = false; 
            using (var contex = new MaterialesContext())
            {
                contex.Entry(entidad).State =Microsoft.EntityFrameworkCore.EntityState.Added;
               if(contex.SaveChanges() == 4)
                {
                    a = true;
                }
            }
          return a;
        }

        public bool Modified(T entidad)
        {
            bool a = false;
            using (var contex = new MaterialesContext())
            {
                contex.Entry(entidad).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                if (contex.SaveChanges() == 3)
                {
                    a = true;
                }
            }
            return a;

        }

        
    }
}
