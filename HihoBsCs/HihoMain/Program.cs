using Hiho.Finance;
using System;

namespace HihoMain
{
    using Normal = Hiho.Math.NormalStandardDistribution;
    using BS = Hiho.Finance.BlackScholes;

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

            Console.WriteLine(BS.EuropeanOption(100, 1, 100, 0.2, 0.05, OptionType.Call) - 10.450575619322300);
            Console.WriteLine(BS.EuropeanOption(100, 1, 100, 0.2, 0.05, OptionType.Put) - 5.573518069393707);
            Console.WriteLine(BS.EuropeanOption(100, 3, 100, 0.2, 0.05, OptionType.Call) - 20.924371241045776);
            Console.WriteLine(BS.EuropeanOption(100, 3, 100, 0.2, 0.05, OptionType.Put) - 6.995168883551568);
            Console.WriteLine(BS.EuropeanOption(110, 1, 100, 0.2, 0.05, OptionType.Call) - 6.040077440561824);
            Console.WriteLine(BS.EuropeanOption(110, 1, 100, 0.2, 0.05, OptionType.Put) - 10.675314135640370);
            Console.WriteLine(BS.EuropeanOption(110, 3, 100, 0.2, 0.05, OptionType.Call) - 16.210868138551504);
            Console.WriteLine(BS.EuropeanOption(110, 3, 100, 0.2, 0.05, OptionType.Put) - 10.888745545307848);
        }
    }
}
