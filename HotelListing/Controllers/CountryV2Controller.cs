using Asp.Versioning;
using AutoMapper;
using HotelListing.Core.DTOs;
using HotelListing.Core.IRepository;
using HotelListing.Core.Models;
using HotelListing.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelListing.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {


        private DatabaseContext _context;

        public CountryV2Controller(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }

}

