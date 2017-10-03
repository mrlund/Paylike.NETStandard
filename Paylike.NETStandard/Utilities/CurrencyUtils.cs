using Newtonsoft.Json;
using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paylike.NETStandard.Utilities
{
    public static class CurrencyUtils
    {
        //TODO: add full list of currencies and their bases 
        //public static HashSet<string> _minorCurrencies = new HashSet<string>() { "KRW", "JPY" };
        public static int ToMinorUnits(this decimal amount, string currency)
        {
            return (int)Math.Round((double)amount * Math.Pow(10, Currencies.CurrencyDictionary[currency].Exponent));
        }

        public static decimal ToMajorUnits(this int amount, string currency)
        {
            return (decimal)(amount / Math.Pow(10, Currencies.CurrencyDictionary[currency].Exponent));
        }

    }
}
