using EasyCommerce.Users.Dal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCommerce.Users.Dal.Infrastructure
{
    public class UsersContext : IdentityDbContext<UserModel>
    {
        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("Users");
        }
    }
}
