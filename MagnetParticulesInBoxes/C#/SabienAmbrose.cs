//link: https://www.codewars.com/kata/magnet-particules-in-boxes/solutions
using System;

namespace MagnetParticlesInBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            double output = Doubles(1, 10);
            Console.WriteLine(output);
        }

        public static double Doubles(int maxk, int maxn) {
            double sum = 0;
            for (int k = 1; k <= maxk; k++) {
                for (int n = 1; n <= maxn; n++) {
                    sum += 1 / (k * MathF.Pow(n + 1, 2 * k));
                }
            }

            return sum;
        }
    }
}
