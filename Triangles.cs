using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows.Controls;
using System.Xml.Linq;

namespace lab9
{

    /// <summary>
    /// Класс называется Triangles потому что так написано в задании, не бейте меня за это
    /// Класс состоит из 3 полей - сторон треугольника и различных методов и переопределений:
    /// метод Give - заполняет поля класса
    /// метод Check - проверка корректности, возвращает true при существовании треугольника, иначе false
    /// метод Check2 - проверка длины строк, возвращает true при их длине не более 300 символов, иначе false
    /// метод Check3 - проверка суммы длин строк, возвращает true при их суммарной длине не более 300 символов, иначе false
    /// перегрузка оператора "-"  - подсчет площади треугольника - возвращает площадь, если треугольник существует, иначе - 0
    /// перегрузка bool - возвращает true, если данные стороны образуют треугольник, иначе вернет false
    /// перегрузка double - возвращает периметр треугольника при его существовании, иначе вернет 0
    /// перегрузка оператора ">" - возвращает true, если площадь первого треугольника больше, чем площадь второго треугольника, иначе вернет false
    /// перегрузка оператора "<" - возвращает true, если площадь второго треугольника больше, чем площадь первого треугольника, иначе вернет false
    /// </summary>
    class Triangles
    {
        private double _a = 0;
        private double _b = 0;
        private double _c = 0;

        public static double operator -(Triangles trial)
        {
            double a = trial._a;
            double b = trial._b;
            double c = trial._c;

            double sqP;// это для корней сторон  в треугольниках
            double sqA;
            double sqB;
            double sqC;

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c) / 2;
                sqP = Math.Sqrt(p);
                sqA = Math.Sqrt(p - a);
                sqB = Math.Sqrt(p - b);
                sqC = Math.Sqrt(p - c);
                return sqP * (sqA) * (sqB) * (sqC);
            }
            else
            {
                return 0;
            }
        }

        public static explicit operator bool(Triangles trial)
        {
            double a = trial._a;
            double b = trial._b;
            double c = trial._c;
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("Такой треугольник существует");
                return true;
            }
            else if ((a + b == c) || (b + c == a) || (a + c == b))
            {
                Console.WriteLine("Это не треугольник, а прямая линия");
                return false;
            }
            Console.WriteLine("Это не треугольник, а какие-то три отрезка");
            return false;
        }

        public static implicit operator double(Triangles trial)
        {
            double a = trial._a;
            double b = trial._b;
            double c = trial._c;
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double Perimetr = a + b + c;
                return Perimetr;
            }
            return 0;
        }

        public static bool operator >(Triangles one, Triangles two) // тут triangles one и two это просто треугольник 1 и треугольник 2, их надо сравнить
        {
            double squareFirst;
            double squareSecond;
            double sqP;// это для корней сторон  в треугольниках
            double sqA;
            double sqB;
            double sqC;

            if ((one._a + one._b > one._c) && (one._b + one._c > one._a) && (one._a + one._c > one._b))
            {
                double p = (one._a + one._b + one._c) / 2;
                sqP = Math.Sqrt(p);
                sqA = Math.Sqrt(p - one._a);
                sqB = Math.Sqrt(p - one._b);
                sqC = Math.Sqrt(p - one._c);
                squareFirst = sqP * (sqA) * (sqB) * (sqC);
            }
            else
            {
                squareFirst = 0;
            }

            if ((two._a + two._b > two._c) && (two._b + two._c > two._a) && (two._a + two._c > two._b))
            {
                double p = (two._a + two._b + two._c) / 2;
                sqP = Math.Sqrt(p);
                sqA = Math.Sqrt(p - two._a);
                sqB = Math.Sqrt(p - two._b);
                sqC = Math.Sqrt(p - two._c);
                squareSecond = sqP * (sqA) * (sqB) * (sqC);
            }
            else
            {
                squareSecond = 0;
            }

            if (squareFirst > squareSecond)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(Triangles one, Triangles two)//тут triangles one и two это просто треугольник 1 и треугольник 2, их надо сравнить
        {
            double squareFirst;
            double squareSecond;
            double sqP;
            double sqA;
            double sqB;
            double sqC;


            if ((one._a + one._b > one._c) && (one._b + one._c > one._a) && (one._a + one._c > one._b))
            {
                double p = (one._a + one._b + one._c) / 2;
                sqP = Math.Sqrt(p);
                sqA = Math.Sqrt(p - one._a);
                sqB = Math.Sqrt(p - one._b);
                sqC = Math.Sqrt(p - one._c);
                squareFirst = sqP * (sqA) * (sqB) * (sqC);
            }
            else
            {
                squareFirst = 0;
            }

            if ((two._a + two._b > two._c) && (two._b + two._c > two._a) && (two._a + two._c > two._b))
            {
                double p = (two._a + two._b + two._c) / 2;
                sqP = Math.Sqrt(p);
                sqA = Math.Sqrt(p - two._a);
                sqB = Math.Sqrt(p - two._b);
                sqC = Math.Sqrt(p - two._c);
                squareSecond = sqP * (sqA) * (sqB) * (sqC);
            }
            else
            {
                squareSecond = 0;
            }

            if (squareFirst < squareSecond)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string ToString(double something)
        {
            string line = something + "";
            return line;
        }

        private void Give(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public bool Check(string a, string b, string c)
        {
            double correctA;
            double correctB;
            double correctC;
            if ((a == "") || (b == "") || (c == ""))
            {
                return false;
            }

            try
            {
                correctA = Double.Parse(a);
                try
                {
                    correctB = Double.Parse(b);
                    try
                    {
                        correctC = Double.Parse(c);
                    }
                    catch (FormatException)
                    {
                        return false;
                    }
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }
            if ((correctA + correctB > correctC) && (correctB + correctC > correctA) && (correctA + correctC > correctB))
            {
                Give(correctA, correctB, correctC);
                return true;
            }
            return false;
        }

        public bool Check2(string a, string b, string c)
        {
            if ((a.Length > 300)|| (b.Length > 300)|| (c.Length > 300))
            {
                return false;
            }
            return true;
        }

        public bool Check3(string a, string b, string c)
        {
            if (((2*a.Length + b.Length + c.Length)>600) ||((a.Length + 2*b.Length + c.Length) > 600)||(a.Length + b.Length + 2*c.Length) > 600)
            {
                return false;
            }
            return true;
        }

        /*public void check(Triangles class_name)
        {
            a = class_name.a;
            b = class_name.b;
            c = class_name.c;

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("Такой треугольник существует");
            }
            else if ((a + b == c) || (b + c == a) || (a + c == b))
            {
                Console.WriteLine("Это не треугольник, а прямая линия");
            }
            else
            {
                Console.WriteLine("Это не треугольник, а какие-то три отрезка");
            }
        }*/
    }
}


