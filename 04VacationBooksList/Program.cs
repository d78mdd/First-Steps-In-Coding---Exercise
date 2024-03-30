using System;

namespace _04VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double lihva = double.Parse(Console.ReadLine());

            double natrupanaLihva = suma * (lihva / 100);
            double lihvaZa1Mesec = natrupanaLihva / 12;
            double obshtaSuma = suma + srok * lihvaZa1Mesec;

            Console.WriteLine(obshtaSuma);
        }
    }
}
