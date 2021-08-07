using Microsoft.Extensions.DependencyInjection;
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
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<INaturalPersonGetAllService, NaturalPersonGetAllService>();
        }
    }
}

