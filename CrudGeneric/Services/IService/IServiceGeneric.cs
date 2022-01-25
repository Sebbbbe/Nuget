using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Services.IService
{
    public interface IServiceGeneric<T> where T : class
    {
        Task<List<T>> FindAllGeneric(T t);
        Task<T> FindGeneric(T t);
    }
}
