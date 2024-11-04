using Microsoft.EntityFrameworkCore;
using static NuGet.Packaging.PackagingConstants;
using System.Composition;

namespace Insurance.Models
{
    public class InsuranceDbContext: DbContext
    {

        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options) : base(options) { }

   public DbSet<User> Users { get; set; }
        
        public DbSet<Lifeinsurance> Lifeinsurances { get; set; }

        public DbSet<Healthinsurance> Healthinsurances { get;  set; }


        public DbSet<Motorinsurance> Motorinsurances { get; set;}

        public DbSet<Homeinsurance> Homeinsurances { get;set; }



    }
}
