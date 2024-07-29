using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace HotelListing.Data.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {

        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    HotelId = 1,
                    HotelName = "Sandals Resort and Spa",
                    HotelAdress = "Negril",
                    CountryId = 1,
                    HotelRating = 4.5
                },
                new Hotel
                {
                    HotelId = 2,
                    HotelName = "Comfort Suites",
                    HotelAdress = "George Town",
                    CountryId = 3,
                    HotelRating = 4.3
                },
                new Hotel
                {
                    HotelId = 3,
                    HotelName = "Grand Palladium",
                    HotelAdress = "Nassua",
                    CountryId = 2,
                    HotelRating = 4
                }
                );
        }
    }
}
