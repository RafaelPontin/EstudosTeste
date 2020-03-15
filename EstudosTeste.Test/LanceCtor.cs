using EstudosTeste.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EstudosTeste.Test
{
    public class LanceCtor
    {
        [Fact]
        public void LancaArgumentExceptionDadoValorNegativo()
        {
            //arranje
            var valorNegativo = -100;

            //Assert
            Assert.Throws<ArgumentException>(
                    () => new Lance(null, valorNegativo)
                );
        }
    }
}
