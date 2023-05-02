using Manero.Models.Entities;
using Manero.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Manero.Context
{
    public class IdentityContext : IdentityDbContext<AppUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {

        }
        public DbSet<AddressEntity> AspNetAddresses { get; set; }
        public DbSet<UserAddressEntity> AspNetUserAddresses { get; set; }
    }
}
