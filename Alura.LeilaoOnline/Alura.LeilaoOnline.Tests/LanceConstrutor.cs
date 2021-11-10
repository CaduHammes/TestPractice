using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnline.Tests
{
    public class LanceConstrutor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //Arrenge
            var valorNegativo = -100;

            //Assert
            Assert.Throws<ArgumentException>(

                //Act
                () => new Lance(null, valorNegativo)
            );
        }
    }
}
