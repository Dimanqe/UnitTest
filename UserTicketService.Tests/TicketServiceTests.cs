using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {

        [Test]
        public void GetTicketPriceMustReturnNotNullableTicket()
        {
            TicketService ticketServiceTest = new TicketService();
            Assert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException> (()=> ticketServiceTest.GetTicketPrice(100));
        }
    }
}
