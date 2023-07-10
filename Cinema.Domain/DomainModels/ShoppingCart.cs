﻿using Cinema.Domain.DomainModels;
using Cinema.Domain.Identity;
using System;
using System.Collections.Generic;

namespace Cinema.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {

        public string OwnerId { get; set; }

        public CinemaApplicationUser Owner { get; set; }

        public virtual ICollection<TicketInShoppingCart> TicketInShoppingCarts { get; set; }
    }
}
