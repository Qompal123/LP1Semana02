using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo:");

            string x = Console.ReadLine();

            int y = int.Parse(x);

            int div = y / 2;

            int n = y;

            int r = 0;

            int sft = y << n;

            int xor =r ^ y;

            bool age = true;

            if(y <= 10)
            {
                age = true;
            }
                else
            {
                age = false;
            }
            

            Console.WriteLine(div);
            Console.WriteLine(sft);
            Console.WriteLine(xor);
            Console.WriteLine(age);
        }
    }
}
