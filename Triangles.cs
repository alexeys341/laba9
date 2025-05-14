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

            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                double p = (a + b + c) / 2;
                double Square = p * (p - a) * (p - b) * (p - c);
                Square = Math.Sqrt(Square);
                return Square;
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

            if ((one._a + one._b > one._c) && (one._b + one._c > one._a) && (one._a + one._c > one._b))
            {
                double p = (one._a + one._b + one._c) / 2;
                squareFirst = p * (p - one._a) * (p - one._b) * (p - one._c);
                squareFirst = Math.Sqrt(squareFirst);
            }
            else
            {
                squareFirst = 0;
            }

            if ((two._a + two._b > two._c) && (two._b + two._c > two._a) && (two._a + two._c > two._b))
            {
                double p = (two._a + two._b + two._c) / 2;
                squareSecond = p * (p - two._a) * (p - two._b) * (p - two._c);
                squareSecond = Math.Sqrt(squareSecond);
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
            double squareSecond ;

            if ((one._a + one._b > one._c) && (one._b + one._c > one._a) && (one._a + one._c > one._b))
            {
                double p = (one._a + one._b + one._c) / 2;
                squareFirst = p * (p - one._a) * (p - one._b) * (p - one._c);
                squareFirst = Math.Sqrt(squareFirst);
            }
            else
            {
                squareFirst = 0;
            }

            if ((two._a + two._b > two._c) && (two._b + two._c > two._a) && (two._a + two._c > two._b))
            {
                double p = (two._a + two._b + two._c) / 2;
                squareSecond = p * (p - two._a) * (p - two._b) * (p - two._c);
                squareSecond = Math.Sqrt(squareSecond);
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


