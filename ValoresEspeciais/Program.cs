using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Valores Máximos e Mínimos de Tipos Numéricos:");

            Console.WriteLine($"Byte: Máximo = {byte.MaxValue}, Mínimo = {byte.MinValue}");

            Console.WriteLine($"SByte: Máximo = {sbyte.MaxValue}, Mínimo = {sbyte.MinValue}");

            Console.WriteLine($"Short: Máximo = {short.MaxValue}, Mínimo = {short.MinValue}");

            Console.WriteLine($"UShort: Máximo = {ushort.MaxValue}, Mínimo = {ushort.MinValue}");

            Console.WriteLine($"Int: Máximo = {int.MaxValue}, Mínimo = {int.MinValue}");

            Console.WriteLine($"UInt: Máximo = {uint.MaxValue}, Mínimo = {uint.MinValue}");

            Console.WriteLine($"Long: Máximo = {long.MaxValue}, Mínimo = {long.MinValue}");

            Console.WriteLine($"ULong: Máximo = {ulong.MaxValue}, Mínimo = {ulong.MinValue}");

            Console.WriteLine($"Float: Máximo = {float.MaxValue}, Mínimo = {float.MinValue}");

            Console.WriteLine($"Double: Máximo = {double.MaxValue}, Mínimo = {double.MinValue}");

            Console.WriteLine($"Decimal: Máximo = {decimal.MaxValue}, Mínimo = {decimal.MinValue}");


            Console.WriteLine("\nValores Especiais:");

            Console.WriteLine($"Float: +∞ = {float.PositiveInfinity}, -∞ = {float.NegativeInfinity}, NaN = {float.NaN}");
            Console.WriteLine($"Double: +∞ = {double.PositiveInfinity}, -∞ = {double.NegativeInfinity}, NaN = {double.NaN}");

        }
    }
}