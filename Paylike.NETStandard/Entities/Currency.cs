using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard.Entities
{
    public class CurrencyData
    {
        public string Code { get; set; }
        public string Currency { get; set; }
        public string Numeric { get; set; }
        public int Exponent { get; set; }
    }

}
