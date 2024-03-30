using System;

namespace _09FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int daljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double obemNaAkvariuma = daljina * shirochina * visochina;
            double obemVLitri = obemNaAkvariuma / 1000;
            double zaetoProstranstvo = procent / 100;
            double nujniLitri = obemVLitri * ( 1 - zaetoProstranstvo);

            Console.WriteLine(nujniLitri);

        }
    }
}
