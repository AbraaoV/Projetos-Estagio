using System;


namespace Beecrowd1036


internal class 1036-Formula-de-Bhaskara
{
    public 1036-Formula-de-Bhaskara() { }

    public void Formula de Bhaskara()
    {


        string[] d;
        double a, b, c, delta, deltasqrt, root1, root2;
        decimal r1, r2;

        d = Console.ReadLine().Split(' ');

        a = Convert.ToDouble(d[0]);
        b = Convert.ToDouble(d[1]);
        c = Convert.ToDouble(d[2]);

        delta = (b * b) - (4 * a * c);

        if (delta < 0 || a == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }

        else
        {

            deltasqrt = Math.Sqrt(delta);

            root1 = (-b + deltasqrt) / (2 * a);

            root2 = (-b - deltasqrt) / (2 * a);

            r1 = Convert.ToDecimal(string.Format("{0:.00000}", root1));
            r2 = Convert.ToDecimal(string.Format("{0:.00000}", root2));

            Console.WriteLine("R1 = " + r1);
            Console.WriteLine("R2 = " + r2);
        }

    }

}