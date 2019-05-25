using System;

namespace HihoMain
{
    using Normal = Hiho.Math.NormalStandardDistribution;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Normal.Cdf(-0.6) - 0.274253117750074);
            Console.WriteLine(Normal.Cdf(-0.5) - 0.308537538725987);
            Console.WriteLine(Normal.Cdf(-0.4) - 0.344578258389676);
            Console.WriteLine(Normal.Cdf(-0.3) - 0.382088577811047);
            Console.WriteLine(Normal.Cdf(-0.2) - 0.420740290560897);
            Console.WriteLine(Normal.Cdf(-0.1) - 0.460172162722971);
            Console.WriteLine(Normal.Cdf(0) - 0.5);
            Console.WriteLine(Normal.Cdf(0.1) - 0.539827837277029);
            Console.WriteLine(Normal.Cdf(0.2) - 0.579259709439103);
            Console.WriteLine(Normal.Cdf(0.3) - 0.617911422188953);
            Console.WriteLine(Normal.Cdf(0.4) - 0.655421741610324);
            Console.WriteLine(Normal.Cdf(0.5) - 0.691462461274013);
            Console.WriteLine(Normal.Cdf(0.6) - 0.725746882249926);
        }
    }
}
