﻿using API.Models;
using System.Threading.Tasks;

namespace API.Services.IServices
{
    public interface IDoorService
    {
        Task<List<Output>> FindEntriesByDoor(string name);

        Task<List<Output>> FindEntriesByCode(string name);

        Task<List<Output>> FindEntriesByTag(string name);

        Task<List<Output>> FindEntriesByDörrBenämning(string name);


        Task<List<Output>> FindEntriesByTenant(string name);

        Task<List<Tenant>> ListTenantsAt(string name);

        Task<Output> CreateData(string dörrBenämning, string code, string tag, string person);

        Task<List<Output>> ListTwentyOutputTables();

    }
}
