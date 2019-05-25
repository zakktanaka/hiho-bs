#pragma once

#include <cmath>

namespace hiho { namespace math { namespace normalstandarddistribution {

	inline double cdf(double x) { 
		static double sqrttwo = std::sqrt(2);
		return (1 + std::erf(x / sqrttwo)) / 2;
	}

} } }