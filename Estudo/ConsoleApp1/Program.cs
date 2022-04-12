using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto p = new Produto("pc", 500.00, 10);

            p.Nome = "cminhao";

            Console.WriteLine(p.Nome);
            Console.WriteLine( p.Preco);
        }
    }
}
