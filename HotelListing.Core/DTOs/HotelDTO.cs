using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Core.DTOs
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
        public int CountryId { get; set; }
    }

    public  class UpdateHotelDTO : CreateHotelDTO
    {

    }

    public class HotelDTO : CreateHotelDTO
    {
        public int HotelId { get; set; }

        public CountryDTO Country { get; set; }   
    }
}
