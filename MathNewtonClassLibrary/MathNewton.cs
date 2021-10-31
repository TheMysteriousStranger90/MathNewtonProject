using System;
using static System.Math;

namespace MathNewtonClassLibrary
{
    public static class MathNewton
    {
        public static double SqrtByNewton(this double A, int n, double x, double delta = 1E-10)
        {
            if (A < 0) throw new ArgumentOutOfRangeException($"Variable {nameof(A)} should be more than zero");
            if (n < 1) throw new ArgumentOutOfRangeException($"Variable {nameof(n)} should be more than one");
            if (x < 0) throw new ArgumentOutOfRangeException($"Variable {nameof(x)} should be more than zero");
            if (delta < 0) throw new ArgumentOutOfRangeException($"Variable {nameof(delta)} should be more than zero");
            return RunNewtonAlgorithm(A, n, x, delta);
        }

        private static double RunNewtonAlgorithm(double A, int n, double x, double delta = 1E-10)
        {
            var x1 = (1.0 / n) * ((n - 1) * x + A / Pow(x, n - 1));
            return Abs(x1 - x) < delta ? x1 : RunNewtonAlgorithm(A, n, x1, delta);
        }
    }
}