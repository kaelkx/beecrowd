using System;
using System.Globalization;

namespace beecrowd
{
    public class Produto_Simples
    {
        public void getProd()
        {

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);


        }


    }

}