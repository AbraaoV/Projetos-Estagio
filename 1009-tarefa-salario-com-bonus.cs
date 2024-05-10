using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1009_salario_com_bonus
{
    internal class 1009_salario_com_bonus
    {
        public 1009_salario_com_bonus() {} //será implementado construtor
        public void solucaoSalarioComBonus()
        {
            string nomeVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double totalVendasMes = double.Parse(Console.ReadLine());
            double totalReceberMes = salarioFixo + 0.15 * totalVendasMes;

            Console.WriteLine("TOTAL = R$ " + totalReceberMes.ToString("0.00"));
        }
    }
}
