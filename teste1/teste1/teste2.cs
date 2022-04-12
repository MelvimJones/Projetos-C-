using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o preço de algun produto: ");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o nome, idade e altura");
            string td = Console.ReadLine();
            string[] ta = td.Split(' ');
            string a1 = ta[0];
            int a2 = int.Parse(ta[1]);
            float a3 = float.Parse(ta[2]);
            



            //----------------------------------------------------------
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(a1);

            Console.WriteLine(a2);
            Console.WriteLine(a3);
            
            



            Console.ReadLine();
        }
    }
}
