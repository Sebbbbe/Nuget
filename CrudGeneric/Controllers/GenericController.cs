
using CrudGeneric.Services.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Controllers
{
    public class GenericController<T,P> : ControllerBase where T : class where P : class
    {

        private readonly IServiceGeneric<T, P> _serviceGeneric;


        public GenericController(IServiceGeneric<T, P> serviceGeneric)
        {
            _serviceGeneric = serviceGeneric;
        }

        [HttpGet]
        public async Task<List<P>> FindAllGeneric()
        {
            return await _serviceGeneric.FindAllGeneric();
        }

    }
}
