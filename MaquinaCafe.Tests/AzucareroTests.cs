using MaquinaCafeApp.Models;
using Xunit;

public class AzucareroTests
{
    [Fact]
    public void Azucarero_Inicializado_Correctamente()
    {
        int cantidadInicial = 5;
        var azucarero = new Azucarero(cantidadInicial);

        Assert.Equal(cantidadInicial, azucarero.CantidadAzucar);
    }

    [Fact]
    public void UsarAzucar_DecrementaCantidadCorrectamente()
    {
        int cantidadInicial = 5;
        var azucarero = new Azucarero(cantidadInicial);

        azucarero.UsarAzucar(2);

        Assert.Equal(3, azucarero.CantidadAzucar);
    }

    [Fact]
    public void UsarAzucar_NoDecrementaSiNoHaySuficiente()
    {
        int cantidadInicial = 2;
        var azucarero = new Azucarero(cantidadInicial);

        azucarero.UsarAzucar(5);

        Assert.Equal(cantidadInicial, azucarero.CantidadAzucar);
    }
}
