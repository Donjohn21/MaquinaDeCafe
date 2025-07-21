namespace MaquinaCafeApp.Models
{
    public class Vaso
    {
        public string Tamaño { get; set; }
        public int CantidadOnzas { get; set; }

        public Vaso(string tamaño, int onzas)
        {
            Tamaño = tamaño;
            CantidadOnzas = onzas;
        }
    }
}
