﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentalShowcase.Models;

namespace RentalShowcase.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}