using System;
namespace Laba1
{
    public class Program
    {
        static public double Tester(double xy1, double xy2, double xy3)
        {
            double P = xy1 + xy2 + xy3;
            Console.WriteLine(xy1.ToString() + " + " + xy2.ToString() + " + " + xy3.ToString() + " = " + P.ToString());
            return P;
        }
        public static int Main()
        {
            int x1, x2, x3, y1, y2, y3;
            double xy1, xy2, xy3, P, S, p;
            Console.WriteLine("Координати першої точки:");
            Console.Write("x:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координати другої точки:");
            Console.Write("x:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координати третьої точки:");
            Console.Write("x:");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y:");
            y3 = Convert.ToInt32(Console.ReadLine());
            xy1 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            xy2 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            xy3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            P = xy1 + xy2 + xy3;
            p = P / 2;
            Console.WriteLine($"Периметр трикутника (P):{P} ");
            S = Math.Sqrt(p * (p - xy1) * (p - xy2) * (p - xy3));
            Console.WriteLine("Площа трикутника (S): " + S);
            return 0;
        }
    }
}
