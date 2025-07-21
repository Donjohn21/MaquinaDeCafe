using MaquinaCafeApp.Models;

namespace MaquinaCafeApp.Services
{
    public class CafeteraService
    {
        private Cafetera _cafetera;
        private Azucarero _azucarero;

        public CafeteraService(Cafetera cafetera, Azucarero azucarero)
        {
            _cafetera = cafetera;
            _azucarero = azucarero;
        }

        public string PrepararCafe(Vaso vaso, int cucharadasAzucar)
        {
            if (!_cafetera.TieneCafeSuficiente(vaso.CantidadOnzas))
                return "❌ No hay suficiente café.";

            if (!_azucarero.TieneAzucarSuficiente(cucharadasAzucar))
                return "❌ No hay suficiente azúcar.";

            _cafetera.ServirCafe(vaso.CantidadOnzas);
            _azucarero.UsarAzucar(cucharadasAzucar);

            return $"✅ Café servido: {vaso.Tamaño} ({vaso.CantidadOnzas} oz) con {cucharadasAzucar} cucharada(s) de azúcar.";
        }
    }
}
