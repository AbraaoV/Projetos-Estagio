using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosBeecrowd
{
    internal class Exercicio1050DDD
    {
        public Exercicio1050DDD() { }

        public void fazerExercicio()
        {
            Dictionary<int, string> listDDD = new Dictionary<int, string>()
            {
                {61, "Brasília" },
                {71, "Salvador" },
                {11, "São Paulo" },
                {21, "Rio de Janeiro" },
                {32, "Juiz de Fora"},
                {19, "Campinas"},
                {27, "Vitória"},
                {31, "Belo Horizonte"},
            };

            int input = int.Parse(Console.ReadLine());

            if(listDDD.ContainsKey(input))
            {
                Console.WriteLine(listDDD[input]);
            } else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }

    }
}