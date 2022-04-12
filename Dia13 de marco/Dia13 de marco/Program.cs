using System;

namespace Dia13_de_marco {
    class Program {
        static void Main(string[] args) {
            ContaBancaria Conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldoIn = double.Parse(Console.ReadLine());
                Conta = new ContaBancaria(numero, nome, saldoIn);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(Conta);
            }
            else {
                Conta = new ContaBancaria(numero, nome);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(Conta);
            }
            Console.WriteLine("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            Conta.AdValor(valor);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(Conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            double valor1 = double.Parse(Console.ReadLine());
            Conta.SaqValor(valor1);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(Conta);















        }
    }
}
