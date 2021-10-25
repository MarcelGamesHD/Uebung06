using System;
using System.Collections.Generic;
using System.Text;

namespace _2021_10_25_verzweigung
{
    class DatentypenFormateConvert
    {
        static void Main(string[] args)
        {
            int zahl;
            Console.WriteLine("Bitte geben Sie eine Ganzzahl ein: ");
            zahl = Convert.ToInt32(Console.ReadLine());
            if (zahl == 0)
            {
                Console.Write("Sie haben eine 0 eingegeben!");
            }
            else
                if (zahl % 2 == 0 && zahl != 0)
            {
                Console.Write("Sie haben eine gerade Zahl eingegeben!");
            }
                else
            {
                Console.Write("Sie haben eine ungerade Zahl eingegeben!");
            }
        }
    }
}