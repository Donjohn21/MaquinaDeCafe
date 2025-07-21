namespace MaquinaCafeApp.Models
{
    public class Cafetera
    {
        public int CantidadCafe { get; set; } // en onzas

        public Cafetera(int cantidadInicial)
        {
            CantidadCafe = cantidadInicial;
        }

        public bool TieneCafeSuficiente(int onzasRequeridas)
        {
            return CantidadCafe >= onzasRequeridas;
        }

        public void ServirCafe(int onzas)
        {
            if (TieneCafeSuficiente(onzas))
            {
                CantidadCafe -= onzas;
            }
        }
    }
}
