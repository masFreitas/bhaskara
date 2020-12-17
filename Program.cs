using System;

namespace ExercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULAR BHASKARA!!!");
            double a, b, c, delta, x1, x2, raiz;

            Console.WriteLine("Informe um numero inteiro para 'a':");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero inteiro para 'b':");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe um numero inteiro para 'c':");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b,2) - (4*a*c);

            Console.WriteLine("delta é {0}", delta);
            raiz = Math.Sqrt(delta);
            
            x1 = (-(b) + raiz) / (2*a);
            x2 = (-(b) - raiz) / (2*a);
            Console.WriteLine("x' é {0}", x1);
            Console.WriteLine("x''é {0}", x2);

        }
    }
}
