using System;

namespace _5marco {
    class Program {
        static void Main(string[] args) {
            Aluno1 a;
            a  = new Aluno1();
            Console.WriteLine("digite o nome do aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("digite as três nota: ");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            if (a.total()>=a.Media) {
                Console.WriteLine("você foi aprovado :) ");
            }else if (a.total()<a.Media) {
                Console.WriteLine("você reprovou :( " +",pontos que faltam: " + a.Subtração());
            }






            Console.WriteLine(a);



        }
    }
}