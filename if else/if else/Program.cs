using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {

            int hora = int.Parse(Console.ReadLine()); ;
            if (hora < 12)
            {
                
                Console.WriteLine("é bom dia"); }else if(hora < 18){
                Console.WriteLine("é boa tarde");

            }
            else { Console.WriteLine("é boa noite"); }



        }
    }
}
