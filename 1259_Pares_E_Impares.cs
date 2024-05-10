using System;

public class 1259_Pares_E_Impares
{
	public 1259_Pares_E_Impares()
	{

        public 1259_Pares_E_Impares(){ }

        public void ParesImpares()
        {
            int N = int.Parse(Console.ReadLine());
            List<int> par = new List<int>();
            List<int> impar = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                if (valor % 2 == 0) par.Add(valor);
                else impar.Add(valor);
            }
            par.Sort();
            impar.Sort();
            foreach (var item in par)
            {
                Console.WriteLine(item);
            }
            for (int i = impar.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(impar[i]);
            }
        }
    }
}
