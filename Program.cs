using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a senha: ");
            int senha = int.Parse(Console.ReadLine());
            Console.WriteLine("digite novamente: ");
            int senha2 = int.Parse(Console.ReadLine( ));
            if (senha == senha2)
            {
                Console.WriteLine("correto");
            }
            else
            {
                Console.WriteLine("senha incorreta");
            }






        }
    }
}
