using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage ="Country Name is Too long.")]
        public string CountryName { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name is Too long.")]

        public string ShortName { get; set; }
    }

    

    public class CountryDTO : CreateCountryDTO
        {
        public int CountryId { get; set; }
        public virtual IList<HotelDTO> Hotels { get; set; }
        }
}
