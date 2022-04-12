using System;

namespace ExerciciosBasicos {
    class Program {
        static void Main(string[] args) {

            ContaBancaria1 C;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Haverá depósito inicial(s / n) ?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine();
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                C = new ContaBancaria1(numero,nome,saldo);
            }
            else {
                C = new ContaBancaria1(numero, nome);
            }
            Console.Clear();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(C);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valor1 = double.Parse(Console.ReadLine());
            C.Deposito(valor1);
            Console.Clear();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(C);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor1 = double.Parse(Console.ReadLine());
            C.Saque(valor1);
            Console.Clear();
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(C);




        }
    }
}
