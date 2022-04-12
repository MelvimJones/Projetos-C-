using System;

namespace Treino01 {
    class Program {
        static void Main(string[] args) {
            ContaBancaria Conta=new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());

            }
            Console.WriteLine(Conta);




        }
    }
}
