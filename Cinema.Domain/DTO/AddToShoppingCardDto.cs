using Cinema.Domain.DomainModels;
using System;

namespace Cinema.Domain.DTO
{
    public class AddToShoppingCardDto
    {
        public Ticket SelectedTicket { get; set; }

        public Guid SelectedTicketId { get; set; }

        public int Quantity { get; set; }

    }
}
