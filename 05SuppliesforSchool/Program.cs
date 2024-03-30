using System;

namespace _05SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int himikali = int.Parse(Console.ReadLine());
            int markeri = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double namalenie = int.Parse(Console.ReadLine());

            double namalenieProcent = namalenie / 100;

            double himikaliCena = himikali * 5.80;
            double markeriCena = markeri * 7.20;
            double preparatCena = preparat * 1.20;

            double cena = himikaliCena + markeriCena + preparatCena;

            double cenaNamalena = cena - (cena * namalenieProcent);

            Console.WriteLine(cenaNamalena);
        }
    }
}