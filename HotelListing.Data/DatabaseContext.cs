using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using HotelListing.Data.Configurations.Entities;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());


        }

        
    }
}
