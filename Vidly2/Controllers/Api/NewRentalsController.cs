﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly2.Dtos;

namespace Vidly2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        [HttpPost]
        public IHttpActionResult CreateRentals(NewRentalDto newRental)
        {
            throw new NotImplementedException();
        }
    }
}
