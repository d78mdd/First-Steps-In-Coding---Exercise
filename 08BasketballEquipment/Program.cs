using System;

namespace _08BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int taksa = int.Parse(Console.ReadLine());

            double kecove = taksa * 0.6;
            double ekip = kecove * 0.8;
            double topka = ekip / 4;
            double aksesoari = topka / 5;

            double obshto = taksa + kecove + ekip + topka + aksesoari;

            Console.WriteLine(obshto);
        }
    }
}
