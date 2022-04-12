using System;

namespace tarefa_so_arthur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" escreva seus numeros na mesma linha: ");
            string numero1 = Console.ReadLine();
            
            string[] r = numero1.Split(' ');
            int a1 = int.Parse(r[0]);
            double a2 = double.Parse(r[1]);
            double a3 = double.Parse(r[2]);

            a2 *= a3;
            
            Console.WriteLine("você deseja escrever mais numeros?");
            string numero2 = Console.ReadLine();
            if (numero2== numero2)
            {
                 numero2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("você recusou!!!");
            }
            

            string[] v = numero2.Split(' ');
            int a4 = int.Parse(v[0]);
            double a5 = double.Parse(v[1]);
            double a6 = double.Parse(v[2]);
            double valor = a2 + a6;


            Console.WriteLine(valor);
            Console.ReadLine();
            




        }
    }
}
