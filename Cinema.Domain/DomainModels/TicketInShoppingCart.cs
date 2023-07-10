using Cinema.Domain.DomainModels;
using System;

namespace Cinema.Domain.DomainModels
{
    public class TicketInShoppingCart : BaseEntity
    {

        public Guid TicketId { get; set; }

        public virtual Ticket Ticket { get; set; }

        public Guid ShoppingCartId { get; set; }

        public virtual ShoppingCart UserCart { get; set; }

        public int Quantity { get; set; }

    }
}
