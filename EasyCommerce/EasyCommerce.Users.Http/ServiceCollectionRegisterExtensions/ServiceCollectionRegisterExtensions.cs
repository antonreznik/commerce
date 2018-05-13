using Microsoft.Extensions.DependencyInjection;
using EasyCommerce.Users.Bll.ServiceCollectionExtensions;

namespace EasyCommerce.Users.Http.ServiceCollectionRegisterExtensions
{
    public static class ServiceCollectionRegisterExtensions
    {
        public static void RegisterUsersModuleServices(this IServiceCollection services, string connectionString)
        {
            services.RegisterUsersDbContext(connectionString);
            services.RegisterIdentity();
        }
    }
}
