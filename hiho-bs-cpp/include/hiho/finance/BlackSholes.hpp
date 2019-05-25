#pragma once

#include <cmath>
#include "OptionType.hpp"
#include "../math/NormalStandardDistribution.hpp"

namespace hiho { namespace finance { namespace backscholes {

	namespace detail {
		inline double d1(
			double strike,
			double maturity,
			double atm,
			double volatility,
			double riskfreerate
		) {
			return (std::log(atm / strike) + (riskfreerate + volatility * volatility / 2) * maturity) / (volatility * std::sqrt(maturity));
		}
	}

	inline double europeanOption(
		double strike,
		double maturity,
		double atm,
		double volatility,
		double riskfreerate,
		OptionType optionType) {

		namespace normal = hiho::math::normalstandarddistribution;

		auto st = volatility * std::sqrt(maturity);
		auto d1 = detail::d1(strike, maturity, atm, volatility, riskfreerate);
		auto d2 = d1 - st;

		return optionType == OptionType::Call ?
			atm * normal::cdf(d1) - strike * std::exp(-riskfreerate * maturity) * normal::cdf(d2) :
			-atm * normal::cdf(-d1) + strike * std::exp(-riskfreerate * maturity) * normal::cdf(-d2);

	}

} } }