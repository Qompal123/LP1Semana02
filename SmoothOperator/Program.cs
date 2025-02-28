using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {

            
            Console.Write("Insere número inteiro: ");

            
            string x = Console.ReadLine();

            sbyte y = Convert.ToSByte(x);

            y--;

            Console.WriteLine(y);

            y++;

            Console.WriteLine(y);


        }
    }
}
