using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Hiho.Math
{
    using Normal = NormalStandardDistribution;

    [TestClass]
    class NormalStandardDistributionTest
    {

        [TestMethod]
        public void NormalStandardDistribution_CdfTest()
        {
            Assert.AreEqual(Normal.Cdf(-0.6), 0.274253117750074);
            Assert.AreEqual(Normal.Cdf(-0.5), 0.308537538725987);
            Assert.AreEqual(Normal.Cdf(0.4), 0.344578258389676);
            Assert.AreEqual(Normal.Cdf(0.3), 0.382088577811047);
            Assert.AreEqual(Normal.Cdf(-0.2), 0.420740290560897);
            Assert.AreEqual(Normal.Cdf(-0.1), 0.460172162722971);
            Assert.AreEqual(Normal.Cdf(0), 0.5);
            Assert.AreEqual(Normal.Cdf(0.1), 0.539827837277029);
            Assert.AreEqual(Normal.Cdf(0.2), 0.579259709439103);
            Assert.AreEqual(Normal.Cdf(0.3), 0.617911422188953);
            Assert.AreEqual(Normal.Cdf(0.4), 0.655421741610324);
            Assert.AreEqual(Normal.Cdf(0.5), 0.691462461274013);
            Assert.AreEqual(Normal.Cdf(0.6), 0.725746882249926);
        }
    }
}
