using DressShop.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DressShop.Data
{
    public class OnlineShopDbContext : IdentityDbContext<ApplicationUser,IdentityRole<Guid>,Guid>
    {
        public OnlineShopDbContext(DbContextOptions<OnlineShopDbContext> options)
            : base(options)
        {
        }
    }
}