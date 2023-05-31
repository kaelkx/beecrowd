using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Resolvers;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var NotaA = double.Parse(Console.ReadLine());
            var NotaB = double.Parse(Console.ReadLine());
            var Notac = double.Parse(Console.ReadLine());

            var MEDIA = (NotaA * 2 + NotaB * 3 + Notac * 5) / 100;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));


        }
    }
}
