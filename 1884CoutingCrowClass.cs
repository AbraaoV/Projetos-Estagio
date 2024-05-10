using System;

namespace exercicios1848
{
    internal class Class1848CoutingCrow
    {
        public class Class1848CoutingCrow { }

        public void 1848CoutingCrow()
        {
            int[] resultados = new int[3];
            int contador = 0;

            while (contador < 3)
            {
                string corvo = Console.ReadLine();

                if (corvo == "caw caw")
                {
                    contador++;
                }
                else
                {
                    string valorBinario = "";
                    for (int i = 0; i < 3; i++)
                    {
                        if (corvo[i] == '*')
                        {
                            valorBinario += "1";
                        }
                        else if (corvo[i] == '-')
                        {
                            valorBinario += "0";
                        }
                    }
                    resultados[contador] += Convert.ToInt32(valorBinario, 2);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(resultados[i]);
            }
        }
    }
}
