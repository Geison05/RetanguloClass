using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.WriteLine("Entre  com os dados do retângulo: ");
            Console.Write("Largura: ");
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(R);
        }
    }
}