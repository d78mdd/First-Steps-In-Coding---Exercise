using System;

namespace _03DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiStranici = int.Parse(Console.ReadLine());
            int straniciZa1Chas = int.Parse(Console.ReadLine());
            int dni = int.Parse(Console.ReadLine());

            int obshtoVreme = broiStranici / straniciZa1Chas;
            int chasoveNaDen = obshtoVreme / dni;

            Console.WriteLine(chasoveNaDen);
        }
    }
}
