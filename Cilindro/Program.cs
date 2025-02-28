using System;
using System.Globalization;


namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Qual a altura do cilindro: ");

            string alt = Console.ReadLine();

            Console.WriteLine("Qual o raio do cilindro: ");

            string r = Console.ReadLine();

            int altC = int.Parse(alt);

            int rC = int.Parse(r);

            double v = Math.PI * rC * rC * altC;

            double sA = 2 * Math.PI * Math.Pow(rC, 2) + 2 * Math.PI * rC * altC;

            Console.WriteLine(v);
            Console.WriteLine(sA);



        }
    
    }
}
