using System;


namespace _06Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boia = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());

            double nailonSuma = (nailon + 2) * 1.50;
            double boiaSuma = boia * 14.50 * 1.1;
            double razreditelSuma = razreditel * 5;
            double torbichkiSuma = 0.40;

            double obshtaSumaZaMateriali = nailonSuma + boiaSuma + razreditelSuma + torbichkiSuma;

            double sumaZaMaistori = 0.3 * obshtaSumaZaMateriali * chasove;

            double krainaSuma = obshtaSumaZaMateriali + sumaZaMaistori;

            Console.WriteLine(krainaSuma);
        }
    }
}
