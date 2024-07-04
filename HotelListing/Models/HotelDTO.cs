using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel Name is Too long.")]
        public string HotelName { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Adress Name is Too long.")]

        public string HotelAdress { get; set; }

        
        [Required]
        [Range(1,5)]
        public double HotelRating { get; set; }

        [Required]
        public int HotelId { get; set; }
    }

    public class HotelDTO : CreateHotelDTO
    {
        public int HotelId { get; set; }

        public CreateCountryDTO Country { get; set; }   
    }
}
