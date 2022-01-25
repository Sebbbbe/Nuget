using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Models
{
    public class ModelGeneric<T> where T : class
    {
        public T T1 { get; set; }
     


    }
}
