#include "gtest/gtest.h"
#include <hiho/finance\BlackSholes.hpp>

TEST(BlackScholesTest, Test) {
	using OptionType = hiho::finance::OptionType;
	namespace bs = hiho::finance::backscholes;

	EXPECT_NEAR(10.450575619322300, bs::europeanOption(100, 1, 100, 0.2, 0.05, OptionType::Call), 1e-4);
	EXPECT_NEAR( 5.573518069393707, bs::europeanOption(100, 1, 100, 0.2, 0.05, OptionType::Put),  1e-4);

	EXPECT_NEAR(20.924371241045776, bs::europeanOption(100, 3, 100, 0.2, 0.05, OptionType::Call), 1e-4);
	EXPECT_NEAR( 6.995168883551568, bs::europeanOption(100, 3, 100, 0.2, 0.05, OptionType::Put),  1e-4);

	EXPECT_NEAR( 6.040077440561824, bs::europeanOption(110, 1, 100, 0.2, 0.05, OptionType::Call), 1e-4);
	EXPECT_NEAR(10.675314135640370, bs::europeanOption(110, 1, 100, 0.2, 0.05, OptionType::Put),  1e-4);

	EXPECT_NEAR(16.210868138551504, bs::europeanOption(110, 3, 100, 0.2, 0.05, OptionType::Call), 1e-4);
	EXPECT_NEAR(10.888745545307848, bs::europeanOption(110, 3, 100, 0.2, 0.05, OptionType::Put),  1e-4);
}