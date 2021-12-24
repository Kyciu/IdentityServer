using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityServer.Data
{
    public class IdentityAppDbContext : IdentityDbContext
    {
        public IdentityAppDbContext(DbContextOptions<IdentityAppDbContext> options)
          : base(options)
        {
        }
    }
}