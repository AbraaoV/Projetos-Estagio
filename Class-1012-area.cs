using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012_exercicio_area
{
    internal class Class_1012_area
    {
        public Class_1012_area() { }

        public void solucao1012()
        {
            string[] lado = Console.ReadLine().Split(' ');
            double A = Convert.ToDouble(lado[0]), B = Convert.ToDouble(lado[1]), C = Convert.ToDouble(lado[2]);

            double aTRet, aC, aTrap, aQuad, aRet;
            aTRet = (A * C) / 2;
            aC = C * C * 3.14159;
            aTrap = ((A + B) * C) / 2;
            aQuad = B * B;
            aRet = A * B;

            Console.WriteLine("TRIANGULO: " + aTRet.ToString("F3"));
            Console.WriteLine("CIRCULO: " + aC.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + aTrap.ToString("F3"));
            Console.WriteLine("QUADRADO: " + aQuad.ToString("F3"));
            Console.WriteLine("RETANGULO: " + aRet.ToString("F3"));
        }
        

    }
}
