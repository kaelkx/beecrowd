using System;
using System.Globalization;

namespace beecrowd
{
   public class Salario
    {
        public void getSalario ()
        {


            int NUMBER = int.Parse(Console.ReadLine());
            int Horas_Trabalhadas = int.Parse(Console.ReadLine());
            float ValorHora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float SALARY = Horas_Trabalhadas * ValorHora;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + SALARY.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));



        }
    }
}
