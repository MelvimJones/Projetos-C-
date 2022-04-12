using System;

namespace if_else_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite uma senha em numeros pfvr: ");
           int senha = int.Parse(Console.ReadLine());
            Console.WriteLine("digite novamente: ");
            int senha2 = int.Parse(Console.ReadLine());
            if (senha == senha2) { 
                Console.WriteLine("senha correta"); }
            else { Console.WriteLine("senha incorreta"); }




        }
    }
}
