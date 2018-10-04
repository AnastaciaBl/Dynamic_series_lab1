using System;

namespace dynamic_series_lab1
{
    static class Quantile
    {
        public static double FindQuantileStudenta(double v)
        {
            double answer = 0;
            double u = 1.96;
            //double v = data.AmountOfElements - 2;
            answer += u;
            answer += 1 / v * 0.25 * (Math.Pow(u, 3) + u);
            answer += 1 / Math.Pow(v, 2) * 1.0 / 96 * (5 * Math.Pow(u, 5) + 16 * Math.Pow(u, 3) + 3 * u);
            answer += 1 / Math.Pow(v, 3) * 1.0 / 384 * (3 * Math.Pow(u, 7) + 19 * Math.Pow(u, 5) + 17 * Math.Pow(u, 3) -
                15 * u);
            answer += 1 / Math.Pow(v, 4) * 1.0 / 92160 * (79 * Math.Pow(u, 9) + 779 * Math.Pow(u, 7) + 1482 * Math.Pow(u, 5) -
                1920 * Math.Pow(u, 3) - 945 * u);
            return Math.Round(answer, 4);
        }
    }
}
