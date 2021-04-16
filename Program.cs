using System;

namespace cs_1._25_CalculaHipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            int cat1, cat2, hipo;

            Console.Clear();

            Console.Write("Digite o valor do primeiro cateto: ");
            cat1 = int.Parse(Console.ReadLine());
            cat1 = Math.Abs(cat1);

            Console.Write("Digite o valor do segundo cateto: ");
            cat2 = int.Parse(Console.ReadLine());
            cat2 = Math.Abs(cat2);

            hipo = (int)Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

            Console.WriteLine($"Valor da hipotenusa: {hipo}");
        }
    }
}
