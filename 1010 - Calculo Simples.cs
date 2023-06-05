using System;
using System.Data;
using System.Drawing;
using System.Globalization;

namespace beecrowd
{
    public class Calculo_Simples
    {
        public void getCalc()
        {

            int codigo = int.Parse(Console.ReadLine());
            int numero= int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine());


            int codigo1 = int.Parse(Console.ReadLine());
            int numero1 = int.Parse(Console.ReadLine());
            double valor1 = double.Parse(Console.ReadLine());


            double total = (valor * numero) + (valor1 * numero1);
            
            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }


    }

}