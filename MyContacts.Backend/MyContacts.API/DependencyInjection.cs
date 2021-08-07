using Microsoft.Extensions.DependencyInjection;
using MyContacts.Interface.Repositories;
using MyContacts.Repository.Repositories;

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
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
