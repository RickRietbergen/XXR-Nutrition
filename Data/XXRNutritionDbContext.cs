using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using XXR_Nutrition.Models;

namespace XXR_Nutrition.Database
{
    public class XXRNutritionDbContext : IdentityDbContext<User>
    {
        public XXRNutritionDbContext(DbContextOptions<XXRNutritionDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
