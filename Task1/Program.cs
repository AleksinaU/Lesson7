using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static double GetSquare(double x, double y, double z, double p)
        {
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double p1 = (double)(x1 + y1 + z1) / 2;
            double s1 = GetSquare(x1, y1, z1, p1);
            Console.WriteLine("Введите стороны второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double p2 = (double)(x2 + y2 + z2) / 2;
            double s2 = GetSquare(x2, y2, z2, p2);
            if (s1 > s2)
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            else
                if (s1 < s2)
                Console.WriteLine("Площадь второго треугольника больше площади первого");
            else
                if (s1 == s2)
                Console.WriteLine("Площади треугольников равны");
            else
                Console.WriteLine("Некорректно заданы длины сторон");
            Console.ReadKey();
        }
    }
}
