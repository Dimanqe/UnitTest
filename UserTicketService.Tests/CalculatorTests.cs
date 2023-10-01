using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UserTicketService.Tests
{

    public class CalculatorTests
    {


        [Fact]
        public void SubtractionMustReturnNotNullValue()
        {
            var calculator = new Calculator();
            Assert.True( calculator.Subraction(5, 2)==3);

        }

        [Fact]
        public void DivisionMustReturnNullValue() 
        {  
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException> (()=> calculator.Division(5,0));
        
        }


        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(200, 10) == 20);
        }


        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Subraction(200, 10) == 190);
        }

    }
}
