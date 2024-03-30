using System;

namespace _07FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int pileshkiMenuta = int.Parse(Console.ReadLine());
            int menutaSRiba = int.Parse(Console.ReadLine());
            int vegetarianskiMenuta = int.Parse(Console.ReadLine());

            double pileshkiMenutaCena = pileshkiMenuta * 10.35;
            double menutaSRibaCena = menutaSRiba * 12.40;
            double vegetarianskiMenutaCena = vegetarianskiMenuta * 8.15;

            double obshtaCenaNaMenutata = pileshkiMenutaCena + menutaSRibaCena + vegetarianskiMenutaCena;
            double cenaNaDeserta = 0.2 * obshtaCenaNaMenutata;
            double cenaNaDostavkata = 2.50;

            double obshto = obshtaCenaNaMenutata + cenaNaDeserta + cenaNaDostavkata;

            Console.WriteLine(obshto);

        }
    }
}
