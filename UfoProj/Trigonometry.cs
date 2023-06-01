using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UfoProj
{
    internal static class Trigonometry
    {
        static public double Sin(double angle, int n)
        {
            double sin = 0;
            for (int i = 0; i < n; ++i)
            {
                int factorial = 1;
                for (int j = 0; j < 2 * (i + 1); ++j)
                {
                    if (i == 0) break;
                    factorial *= (j + 1);
                }

                if (i % 2 == 0)
                {
                    sin += Math.Pow(angle / 180 * Math.PI, 2 * i + 1) / factorial;
                }
                else
                {
                    sin -= Math.Pow(angle / 180 * Math.PI, 2 * i + 1) / factorial;
                }
            }
            return sin;
        }

        static public double Cos(double angle, int n)
        {
            double cos = 0;
            for (int i = 0; i < n; ++i)
            {
                int factorial = 1;
                for (int j = 0; j < 2 * i; ++j)
                {
                    factorial *= (j + 1);
                }

                if (i % 2 == 0)
                {
                    cos += Math.Pow(angle / 180 * Math.PI, 2 * i) / factorial;
                }
                else
                {
                    cos -= Math.Pow(angle / 180 * Math.PI, 2 * i) / factorial;
                }
            }
            return cos;
        }

        static public double Atan(double x, int n)
        {
            double res = 0;
            int sign = 1;

            if (Math.Abs(x) > 1)
            {
                res = Math.PI / 2;
                x = 1 / x;
                sign = -1;
            }


            for (int i = 0; i < n; i++)
            {
                res += sign * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
                sign *= -1;
            }

            return res;
        }
    }
}