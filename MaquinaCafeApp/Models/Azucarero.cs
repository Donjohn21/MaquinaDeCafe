namespace MaquinaCafeApp.Models
{
    public class Azucarero
    {
        public int CantidadAzucar { get; set; } // en cucharadas

        public Azucarero(int cantidadInicial)
        {
            CantidadAzucar = cantidadInicial;
        }

        public bool TieneAzucarSuficiente(int cucharadas)
        {
            return CantidadAzucar >= cucharadas;
        }

        public void UsarAzucar(int cucharadas)
        {
            if (TieneAzucarSuficiente(cucharadas))
            {
                CantidadAzucar -= cucharadas;
            }
        }
    }
}
