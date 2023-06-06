using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Resolvers;

namespace PrimeiroProjeto
{
    public class Consumo
    {
        public void getConsumo()
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double Consumo_Medio_de_Combustível = x / y;

            Console.WriteLine(Consumo_Medio_de_Combustível.ToString("F3") + "km/l");
        }
    }
}
