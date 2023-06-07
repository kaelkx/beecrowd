using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Resolvers;

namespace PrimeiroProjeto
{
    public class Distancia
    {
        public void getDistancia()
        {


            int distancia = int.Parse(Console.ReadLine());

            int velocidadeX = 60;
            int velocidadeY = 90;

            int velocidadeRelativa = velocidadeY - velocidadeX;

            int tempo = distancia / velocidadeRelativa;

            Console.WriteLine(tempo + " minutos");



        }
    }
}
