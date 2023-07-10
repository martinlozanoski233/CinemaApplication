﻿using Cinema.Domain.DomainModels;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Domain.Identity
{
    public class CinemaApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public virtual ShoppingCart UserCart { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
