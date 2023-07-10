using Cinema.Domain.DomainModels;
using Cinema.Domain.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Cinema.Domain.DomainModels
{
    public class Order : BaseEntity
    {

        public string UserId { get; set; }

        public CinemaApplicationUser User { get; set; }

        public IEnumerable<TicketInOrder> TicketInOrders { get; set; }

    }
}
