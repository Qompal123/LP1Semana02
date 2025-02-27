using System;
using System.Globalization;


namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input the height of the cylendar.");

            string read = Console.ReadLine();

            int alt = int.Parse(read);

            Console.WriteLine("Input the radius of the cylendar.");

            string reaD = Console.ReadLine();

            int r = int.Parse(read);

            double v = Math.PI * r * r * alt;

            double sA = 2 * Math.PI * Math.Pow(r,2) + 2 * Math.PI * r * alt:

            Console.WriteLine(v);
            Console.WriteLine(sA);



        }
    
    }
}
