﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace HotelListing.Core.Models
{
    public class RequestParams
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 10;
        public int PageSize {
            get
            {

            return _pageSize;
            }
            set
            {
                _pageSize = (value>maxPageSize)?maxPageSize:value;
            }
        
        }
    }
}
