using System;
using System.Globalization;

namespace beecrowd
{
    public class AreaDoCirculo
    {
        public void getArea()
        {

            double raio = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            
            
            //A = 12.5664
        }
    }
}

