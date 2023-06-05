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

            string[] valoresPeca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(valoresPeca1[0]);
            int numero1 = int.Parse(valoresPeca1[1]);
            double valorUnitario1 = double.Parse(valoresPeca1[2], CultureInfo.InvariantCulture);

            string[] valoresPeca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(valoresPeca2[0]);
            int numero2 = int.Parse(valoresPeca2[1]);
            double valorUnitario2 = double.Parse(valoresPeca2[2], CultureInfo.InvariantCulture);

            double total = (numero1 * valorUnitario1) + (numero2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }


    }


    }

