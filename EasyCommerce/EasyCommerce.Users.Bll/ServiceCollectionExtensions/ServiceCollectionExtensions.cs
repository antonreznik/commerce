using EasyCommerce.Users.Dal.Infrastructure;
using EasyCommerce.Users.Dal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EasyCommerce.Users.Bll.ServiceCollectionExtensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterUsersDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<UsersContext>(options => options.UseSqlServer(connectionString));
            return services;
        }

        public static IServiceCollection RegisterIdentity(this IServiceCollection services)
        {
            services.AddIdentity<UserModel, IdentityRole>().AddEntityFrameworkStores<UsersContext>();
            return services;
        }
    }
}
