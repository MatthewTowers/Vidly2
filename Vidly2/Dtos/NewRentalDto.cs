﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly2.Dtos
{
    public class NewRentalDto
    {
        public int CustomerID { get; set; }
        public List<int> MovieIds { get; set; }
    }
}