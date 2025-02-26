using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {

            
            Console.Write("Insere número inteiro: ");

            
            string x = Console.ReadLine();

            int y = int.Parse(x);

            y--;

            Console.WriteLine(y);

            y++;

            Console.WriteLine(y);


        }
    }
}
