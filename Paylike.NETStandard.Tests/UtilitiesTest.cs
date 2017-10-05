using Paylike.NETStandard.Utilities;
using System;
using Xunit;

namespace Paylike.NETStandard.Tests
{
    public class UtilitiesTest
    {
        [Fact]
        public void CanGetCurrencyByCode()
        {
            var danishCrowns = CurrencyUtils.GetCurrency("DKK");

            Assert.NotNull(danishCrowns);
            Assert.Equal("208", danishCrowns.Numeric);

        }


        [Fact]
        public void CanConvertDecimalAmountToMinorUnits()
        {
            decimal decUnits = 100M;
            Assert.Equal(10000, decUnits.ToMinorUnits("DKK"));
            Assert.Equal(100, decUnits.ToMinorUnits("JPY"));
        }


        [Fact]
        public void CanConvertMinorUnitsToMajorUnits()
        {
            int minUnits = 10000;
            Assert.Equal(100, minUnits.ToMajorUnits("DKK"));
            Assert.Equal(10000, minUnits.ToMajorUnits("JPY"));
        }

    }
}
