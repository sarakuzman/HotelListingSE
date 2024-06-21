using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace HotelListing.Data
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string HotelAdress { get; set; }
        public double HotelRating { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; } 
        public Country Country { get; set; }
        
    }
}
