using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Services.IService
{
    public interface IServiceGeneric<T,P> where T : class where P : class
    {
        Task<List<P>> FindAllGeneric();
        
    }
}
