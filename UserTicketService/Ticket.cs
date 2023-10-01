using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService
{
    public class Ticket
    {


        public int Id { get; }
        public string Description { get; set; }
        public int Price { get; }

        public Ticket(int id, string description, int price)
        {

            Id = id;
            Description = description;
            Price = price;
        }
        

    }
}
