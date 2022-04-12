using System;

namespace teste4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("digite um numero inteiro: ");
            int NUMERO = int.Parse(Console.ReadLine());
            Console.WriteLine("digite uma caractere, do seu sexo:  ");
            char caractere = char.Parse(Console.ReadLine());
            Console.WriteLine("sua altura: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("escreva tudo em apenas uma linha: ");
            string frase = Console.ReadLine();
            string[] r = frase.Split(' ');
            string a1 = r[0];
            string a2 = r[1];
            string a3 = r[2];
            string a4 = r[3];

            Console.WriteLine(NUMERO);
            Console.WriteLine(caractere);
            Console.WriteLine(numero2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            Console.ReadLine();
        }
    }
}
