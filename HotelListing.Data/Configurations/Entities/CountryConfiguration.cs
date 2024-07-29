using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.Data.Configurations.Entities
{
    public class CountryConfiguration:IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Cayman Island",
                    ShortName = "CI"
                }
                );
        }

    }
}
