using MathNet.Numerics.Distributions;

namespace Hiho.Math
{
    public static class NormalStandardDistribution
    {
        public static double Cdf(double x)
        {
            return Normal.CDF(0, 1, x);
        }
    }
}
