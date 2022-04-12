using System;
using System.Globalization;

namespace Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            int quant = int.Parse(Console.ReadLine());
           
            Produto[] a=new Produto[quant];
            for(int i = 0; i < quant; i++)
            {

                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                a[i] = new Produto { Nome = nome ,Preco =  preco};
                
            }
            // double sam = 0.00;
            Console.WriteLine(a[0].Preco.ToString("F2"));

            Console.ReadLine();

        }
    }
}
