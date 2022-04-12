using System;

namespace Treino
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero enteiro pfvr!: ");
            string numero =  Console.ReadLine( );
            string[] r = numero.Split(' ');
            int a1 =  int.Parse(r[0]);
            int a2 = int.Parse(r[1]);
            int a3 = int.Parse(r[2]);
            if (a1 > a2)
            {
                Console.WriteLine(a2);
            }else if(a3 > a2)
            {
                Console.WriteLine(a2);
            }
            else
            {
                Console.WriteLine(a3);
            }





        }


    }
}
