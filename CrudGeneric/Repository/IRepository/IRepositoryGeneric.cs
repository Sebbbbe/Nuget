using CrudGeneric.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Repository.IRepository
{
    public interface IRepositoryGeneric<T> where T : class
    {
        Task<List<T>> FindAllGeneric();
       

    }
}
