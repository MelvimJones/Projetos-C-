using System;
using System.Globalization;

namespace Vetores17 {
    class Program {
        static void Main(string[] args) {
           vetor1  a;
            a = new vetor1();
            Console.Write("escreva três numeros na mesma linha: ");
            a.numero1 = Console.ReadLine();
            string[] b = a.numero1.Split(' ');
            a.veto1 = int.Parse(b[0]);
            a.veto2 = int.Parse(b[1]);
            a.veto3 = int.Parse(b[2]);



            if (a.veto1 > a.veto2) {
                Console.WriteLine("o numero " + a.veto1 + " é o maior :)");
            }else if (a.veto2>a.veto1) {
                Console.WriteLine("o numero " + a.veto2 + " é o maior :)");
            }
            else {
                Console.WriteLine("o numero " + a.veto3 + " é o maior :)");
            }


        }
    }
}
