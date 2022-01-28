
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
    public class GenericController<T> : ControllerBase where T : class
    {

        private readonly IServiceGeneric<T> _serviceGeneric;


        public GenericController(IServiceGeneric<T> serviceGeneric)
        {
            _serviceGeneric = serviceGeneric;
        }

        [HttpGet]
        public async Task<List<T>> FindAllGeneric()
        {
            return await _serviceGeneric.FindAllGeneric();
        }

    }
}
