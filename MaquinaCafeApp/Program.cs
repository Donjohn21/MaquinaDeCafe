using MaquinaCafeApp.Models;
using MaquinaCafeApp.Services;

class Program
{
    static void Main(string[] args)
    {
        // Inicializar componentes con recursos disponibles
        Cafetera cafetera = new Cafetera(30);       // 30 oz de café
        Azucarero azucarero = new Azucarero(20);    // 20 cucharadas de azúcar

        CafeteraService servicio = new CafeteraService(cafetera, azucarero);

        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== MÁQUINA DE CAFÉ ===");
            Console.WriteLine("1. Pequeño (3 oz)");
            Console.WriteLine("2. Mediano (5 oz)");
            Console.WriteLine("3. Grande (7 oz)");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione el tamaño del vaso: ");
            string opcion = Console.ReadLine();

            Vaso vaso = null;

            switch (opcion)
            {
                case "1":
                    vaso = new Vaso("Pequeño", 3);
                    break;
                case "2":
                    vaso = new Vaso("Mediano", 5);
                    break;
                case "3":
                    vaso = new Vaso("Grande", 7);
                    break;
                case "4":
                    salir = true;
                    continue;
                default:
                    Console.WriteLine("Opción inválida. Presione Enter para continuar.");
                    Console.ReadLine();
                    continue;
            }

            Console.Write("¿Cuántas cucharadas de azúcar desea? ");
            int azucar;
            if (!int.TryParse(Console.ReadLine(), out azucar) || azucar < 0)
            {
                Console.WriteLine("Entrada inválida. Presione Enter para continuar.");
                Console.ReadLine();
                continue;
            }

            string resultado = servicio.PrepararCafe(vaso, azucar);
            Console.WriteLine("\n" + resultado);
            Console.WriteLine("\nPresione Enter para continuar...");
            Console.ReadLine();
        }

        Console.WriteLine("\nGracias por usar la máquina de café ☕");
    }
}
