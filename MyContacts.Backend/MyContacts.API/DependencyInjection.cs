using Microsoft.Extensions.DependencyInjection;
using MyContacts.Domain.Entities;
using MyContacts.Interface.Repositories;
using MyContacts.Interface.Services;
using MyContacts.Repository.Repositories;
using MyContacts.Service.Implementations;

namespace MyContacts.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection services)
        {
            DependenciesRepository(services);
        }

        private static void DependenciesRepository(IServiceCollection services)
        {
            //services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<INaturalPersonRepository, NaturalPersonRepository>();
            services.AddScoped<INaturalPersonService, NaturalPersonService>();
        }
    }
}

