using System;

public class 1043Triangulo
{
	public 1043Triangulo()
	{

        public 1043Triangulo(){
        }

		public void Triangulo()
		{
            string[] input = Console.ReadLine().Split(' ');

            double a = Convert.ToDouble(input[0]);
            double b = Convert.ToDouble(input[1]);
            double c = Convert.ToDouble(input[2]);

            if (a + b > c && b + c > a && a + c > b)
            {
                double perimetro = a + b + c;
                Console.WriteLine("Perimetro = " + perimetro.ToString("0.0"));
            }
            else
            {
                double trapezio = (a + b) * c / 2;
                Console.WriteLine("Area = " + trapezio.ToString("0.0"));
            }
        }

	}
}
