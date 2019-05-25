using System;
using System.Collections.Generic;
using System.Text;

namespace Hiho.Finance
{
    using Math = System.Math;
    using Normal = Hiho.Math.NormalStandardDistribution;

    public static class BlackScholes
    {
        private static double D1(
            double strike,
            double maturity,
            double atm,
            double volatility,
            double riskfreerate
            )
        {
            return (Math.Log(atm / strike) + (riskfreerate + volatility * volatility / 2) * maturity) / (volatility * Math.Sqrt(maturity));
        }

        public static double EuropeanOption(
            double strike,
            double maturity,
            double atm,
            double volatility,
            double riskfreerate,
            OptionType optionType)
        {
            var st = volatility * Math.Sqrt(maturity);
            var d1 = D1(strike, maturity, atm, volatility, riskfreerate);
            var d2 = d1 - st;

            return optionType == OptionType.Call ?
                 atm * Normal.Cdf(d1) - strike * Math.Exp(-riskfreerate * maturity) * Normal.Cdf(d2) :
                 -atm * Normal.Cdf(-d1) + strike * Math.Exp(-riskfreerate * maturity) * Normal.Cdf(-d2);
        }
    }
}
