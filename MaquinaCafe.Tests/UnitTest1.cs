using Xunit;
using MaquinaCafeApp.Models;

namespace MaquinaCafe.Tests
{
    public class CafeTests
    {
        [Fact]
        public void Azucarero_Inicializado_Vacio()
        {
            var azucarero = new Azucarero();
            Assert.Equal(0, azucarero.Cantidad);
        }
    }
}
