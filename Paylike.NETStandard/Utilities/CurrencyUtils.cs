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
            return (int)Math.Round((double)amount * Math.Pow(10, GetCurrency(currency).Exponent));
        }

        public static decimal ToMajorUnits(this int amount, string currency)
        {
            return (decimal)(amount / Math.Pow(10, GetCurrency(currency).Exponent));
        }

        public static CurrencyData GetCurrency(string Code)
        {
            if (Currencies.ContainsKey(Code))
            {
                return Currencies[Code];
            }
            return null; 
        }

        private static Dictionary<string, CurrencyData> Currencies = new Dictionary<string, CurrencyData>
        {
            {"AED", new CurrencyData { Code = "AED", Currency = "United Arab Emirates dirham", Exponent = 2, Numeric = "784" } },
            {"AFN", new CurrencyData { Code = "AFN", Currency = "Afghan afghani", Exponent = 2, Numeric = "971" } },
            {"ALL", new CurrencyData { Code = "ALL", Currency = "Albanian lek", Exponent = 2, Numeric = "008" } },
            {"AMD", new CurrencyData { Code = "AMD", Currency = "Armenian dram", Exponent = 2, Numeric = "051" } },
            {"ANG", new CurrencyData { Code = "ANG", Currency = "Netherlands Antillean guilder", Exponent = 2, Numeric = "532" } },
            {"AOA", new CurrencyData { Code = "AOA", Currency = "Angolan kwanza", Exponent = 2, Numeric = "973" } },
            {"ARS", new CurrencyData { Code = "ARS", Currency = "Argentine peso", Exponent = 2, Numeric = "032" } },
            {"AUD", new CurrencyData { Code = "AUD", Currency = "Australian dollar", Exponent = 2, Numeric = "036" } },
            {"AWG", new CurrencyData { Code = "AWG", Currency = "Aruban florin", Exponent = 2, Numeric = "533" } },
            {"AZN", new CurrencyData { Code = "AZN", Currency = "Azerbaijani manat", Exponent = 2, Numeric = "944" } },
            {"BAM", new CurrencyData { Code = "BAM", Currency = "Bosnia and Herzegovina convertible mark", Exponent = 2, Numeric = "977" } },
            {"BBD", new CurrencyData { Code = "BBD", Currency = "Barbados dollar", Exponent = 2, Numeric = "052" } },
            {"BDT", new CurrencyData { Code = "BDT", Currency = "Bangladeshi taka", Exponent = 2, Numeric = "050" } },
            {"BGN", new CurrencyData { Code = "BGN", Currency = "Bulgarian lev", Exponent = 2, Numeric = "975" } },
            {"BHD", new CurrencyData { Code = "BHD", Currency = "Bahraini dinar", Exponent = 3, Numeric = "048" } },
            {"BIF", new CurrencyData { Code = "BIF", Currency = "Burundian franc", Exponent = 0, Numeric = "108" } },
            {"BMD", new CurrencyData { Code = "BMD", Currency = "Bermudian dollar", Exponent = 2, Numeric = "060" } },
            {"BND", new CurrencyData { Code = "BND", Currency = "Brunei dollar", Exponent = 2, Numeric = "096" } },
            {"BOB", new CurrencyData { Code = "BOB", Currency = "Boliviano", Exponent = 2, Numeric = "068" } },
            {"BRL", new CurrencyData { Code = "BRL", Currency = "Brazilian real", Exponent = 2, Numeric = "986" } },
            {"BSD", new CurrencyData { Code = "BSD", Currency = "Bahamian dollar", Exponent = 2, Numeric = "044" } },
            {"BTN", new CurrencyData { Code = "BTN", Currency = "Bhutanese ngultrum", Exponent = 2, Numeric = "064" } },
            {"BWP", new CurrencyData { Code = "BWP", Currency = "Botswana pula", Exponent = 2, Numeric = "072" } },
            {"BYR", new CurrencyData { Code = "BYR", Currency = "Belarusian ruble", Exponent = 0, Numeric = "974" } },
            {"BZD", new CurrencyData { Code = "BZD", Currency = "Belize dollar", Exponent = 2, Numeric = "084" } },
            {"CAD", new CurrencyData { Code = "CAD", Currency = "Canadian dollar", Exponent = 2, Numeric = "124" } },
            {"CDF", new CurrencyData { Code = "CDF", Currency = "Congolese franc", Exponent = 2, Numeric = "976" } },
            {"CHF", new CurrencyData { Code = "CHF", Currency = "Swiss franc", Exponent = 2, Numeric = "756" } },
            {"CLP", new CurrencyData { Code = "CLP", Currency = "Chilean peso", Exponent = 2, Numeric = "152" } },
            {"CNY", new CurrencyData { Code = "CNY", Currency = "Chinese yuan", Exponent = 2, Numeric = "156" } },
            {"COP", new CurrencyData { Code = "COP", Currency = "Colombian peso", Exponent = 2, Numeric = "170" } },
            {"CRC", new CurrencyData { Code = "CRC", Currency = "Costa Rican colon", Exponent = 2, Numeric = "188" } },
            {"CUP", new CurrencyData { Code = "CUP", Currency = "Cuban peso", Exponent = 2, Numeric = "192" } },
            {"CVE", new CurrencyData { Code = "CVE", Currency = "Cape Verde escudo", Exponent = 2, Numeric = "132" } },
            {"CZK", new CurrencyData { Code = "CZK", Currency = "Czech koruna", Exponent = 2, Numeric = "203" } },
            {"DJF", new CurrencyData { Code = "DJF", Currency = "Djiboutian franc", Exponent = 0, Numeric = "262" } },
            {"DKK", new CurrencyData { Code = "DKK", Currency = "Danish krone", Exponent = 2, Numeric = "208" } },
            {"DOP", new CurrencyData { Code = "DOP", Currency = "Dominican peso", Exponent = 2, Numeric = "214" } },
            {"DZD", new CurrencyData { Code = "DZD", Currency = "Algerian dinar", Exponent = 2, Numeric = "012" } },
            {"EGP", new CurrencyData { Code = "EGP", Currency = "Egyptian pound", Exponent = 2, Numeric = "818" } },
            {"ERN", new CurrencyData { Code = "ERN", Currency = "Eritrean nakfa", Exponent = 2, Numeric = "232" } },
            {"ETB", new CurrencyData { Code = "ETB", Currency = "Ethiopian birr", Exponent = 2, Numeric = "230" } },
            {"EUR", new CurrencyData { Code = "EUR", Currency = "Euro", Exponent = 2, Numeric = "978" } },
            {"FJD", new CurrencyData { Code = "FJD", Currency = "Fiji dollar", Exponent = 2, Numeric = "242" } },
            {"FKP", new CurrencyData { Code = "FKP", Currency = "Falkland Islands pound", Exponent = 2, Numeric = "238" } },
            {"GBP", new CurrencyData { Code = "GBP", Currency = "Pound sterling", Exponent = 2, Numeric = "826" } },
            {"GEL", new CurrencyData { Code = "GEL", Currency = "Georgian lari", Exponent = 2, Numeric = "981" } },
            {"GHS", new CurrencyData { Code = "GHS", Currency = "Ghanaian cedi", Exponent = 2, Numeric = "936" } },
            {"GIP", new CurrencyData { Code = "GIP", Currency = "Gibraltar pound", Exponent = 2, Numeric = "292" } },
            {"GMD", new CurrencyData { Code = "GMD", Currency = "Gambian dalasi", Exponent = 2, Numeric = "270" } },
            {"GNF", new CurrencyData { Code = "GNF", Currency = "Guinean franc", Exponent = 0, Numeric = "324" } },
            {"GTQ", new CurrencyData { Code = "GTQ", Currency = "Guatemalan quetzal", Exponent = 2, Numeric = "320" } },
            {"GYD", new CurrencyData { Code = "GYD", Currency = "Guyanese dollar", Exponent = 2, Numeric = "328" } },
            {"HKD", new CurrencyData { Code = "HKD", Currency = "Hong Kong dollar", Exponent = 2, Numeric = "344" } },
            {"HNL", new CurrencyData { Code = "HNL", Currency = "Honduran lempira", Exponent = 2, Numeric = "340" } },
            {"HRK", new CurrencyData { Code = "HRK", Currency = "Croatian kuna", Exponent = 2, Numeric = "191" } },
            {"HTG", new CurrencyData { Code = "HTG", Currency = "Haitian gourde", Exponent = 2, Numeric = "332" } },
            {"HUF", new CurrencyData { Code = "HUF", Currency = "Hungarian forint", Exponent = 2, Numeric = "348" } },
            {"IDR", new CurrencyData { Code = "IDR", Currency = "Indonesian rupiah", Exponent = 2, Numeric = "360" } },
            {"ILS", new CurrencyData { Code = "ILS", Currency = "Israeli new shekel", Exponent = 2, Numeric = "376" } },
            {"INR", new CurrencyData { Code = "INR", Currency = "Indian rupee", Exponent = 2, Numeric = "356" } },
            {"IQD", new CurrencyData { Code = "IQD", Currency = "Iraqi dinar", Exponent = 3, Numeric = "368" } },
            {"IRR", new CurrencyData { Code = "IRR", Currency = "Iranian rial", Exponent = 2, Numeric = "364" } },
            {"ISK", new CurrencyData { Code = "ISK", Currency = "Icelandic króna", Exponent = 2, Numeric = "352" } },
            {"JMD", new CurrencyData { Code = "JMD", Currency = "Jamaican dollar", Exponent = 2, Numeric = "388" } },
            {"JOD", new CurrencyData { Code = "JOD", Currency = "Jordanian dinar", Exponent = 3, Numeric = "400" } },
            {"JPY", new CurrencyData { Code = "JPY", Currency = "Japanese yen", Exponent = 0, Numeric = "392" } },
            {"KES", new CurrencyData { Code = "KES", Currency = "Kenyan shilling", Exponent = 2, Numeric = "404" } },
            {"KGS", new CurrencyData { Code = "KGS", Currency = "Kyrgyzstani som", Exponent = 2, Numeric = "417" } },
            {"KHR", new CurrencyData { Code = "KHR", Currency = "Cambodian riel", Exponent = 2, Numeric = "116" } },
            {"KMF", new CurrencyData { Code = "KMF", Currency = "Comoro franc", Exponent = 0, Numeric = "174" } },
            {"KPW", new CurrencyData { Code = "KPW", Currency = "North Korean won", Exponent = 2, Numeric = "408" } },
            {"KRW", new CurrencyData { Code = "KRW", Currency = "South Korean won", Exponent = 0, Numeric = "410" } },
            {"KWD", new CurrencyData { Code = "KWD", Currency = "Kuwaiti dinar", Exponent = 3, Numeric = "414" } },
            {"KYD", new CurrencyData { Code = "KYD", Currency = "Cayman Islands dollar", Exponent = 2, Numeric = "136" } },
            {"KZT", new CurrencyData { Code = "KZT", Currency = "Kazakhstani tenge", Exponent = 2, Numeric = "398" } },
            {"LAK", new CurrencyData { Code = "LAK", Currency = "Lao kip", Exponent = 2, Numeric = "418" } },
            {"LBP", new CurrencyData { Code = "LBP", Currency = "Lebanese pound", Exponent = 2, Numeric = "422" } },
            {"LKR", new CurrencyData { Code = "LKR", Currency = "Sri Lankan rupee", Exponent = 2, Numeric = "144" } },
            {"LRD", new CurrencyData { Code = "LRD", Currency = "Liberian dollar", Exponent = 2, Numeric = "430" } },
            {"LSL", new CurrencyData { Code = "LSL", Currency = "Lesotho loti", Exponent = 2, Numeric = "426" } },
            {"MAD", new CurrencyData { Code = "MAD", Currency = "Moroccan dirham", Exponent = 2, Numeric = "504" } },
            {"MDL", new CurrencyData { Code = "MDL", Currency = "Moldovan leu", Exponent = 2, Numeric = "498" } },
            {"MGA", new CurrencyData { Code = "MGA", Currency = "Malagasy ariary", Exponent = 2, Numeric = "969" } },
            {"MKD", new CurrencyData { Code = "MKD", Currency = "Macedonian denar", Exponent = 2, Numeric = "807" } },
            {"MMK", new CurrencyData { Code = "MMK", Currency = "Myanmar kyat", Exponent = 2, Numeric = "104" } },
            {"MNT", new CurrencyData { Code = "MNT", Currency = "Mongolian tögrög", Exponent = 2, Numeric = "496" } },
            {"MOP", new CurrencyData { Code = "MOP", Currency = "Macanese pataca", Exponent = 2, Numeric = "446" } },
            {"MRO", new CurrencyData { Code = "MRO", Currency = "Mauritanian ouguiya", Exponent = 2, Numeric = "478" } },
            {"MUR", new CurrencyData { Code = "MUR", Currency = "Mauritian rupee", Exponent = 2, Numeric = "480" } },
            {"MVR", new CurrencyData { Code = "MVR", Currency = "Maldivian rufiyaa", Exponent = 2, Numeric = "462" } },
            {"MWK", new CurrencyData { Code = "MWK", Currency = "Malawian kwacha", Exponent = 2, Numeric = "454" } },
            {"MXN", new CurrencyData { Code = "MXN", Currency = "Mexican peso", Exponent = 2, Numeric = "484" } },
            {"MYR", new CurrencyData { Code = "MYR", Currency = "Malaysian ringgit", Exponent = 2, Numeric = "458" } },
            {"MZN", new CurrencyData { Code = "MZN", Currency = "Mozambican metical", Exponent = 2, Numeric = "943" } },
            {"NAD", new CurrencyData { Code = "NAD", Currency = "Namibian dollar", Exponent = 2, Numeric = "516" } },
            {"NGN", new CurrencyData { Code = "NGN", Currency = "Nigerian naira", Exponent = 2, Numeric = "566" } },
            {"NIO", new CurrencyData { Code = "NIO", Currency = "Nicaraguan córdoba", Exponent = 2, Numeric = "558" } },
            {"NOK", new CurrencyData { Code = "NOK", Currency = "Norwegian krone", Exponent = 2, Numeric = "578" } },
            {"NPR", new CurrencyData { Code = "NPR", Currency = "Nepalese rupee", Exponent = 2, Numeric = "524" } },
            {"NZD", new CurrencyData { Code = "NZD", Currency = "New Zealand dollar", Exponent = 2, Numeric = "554" } },
            {"OMR", new CurrencyData { Code = "OMR", Currency = "Omani rial", Exponent = 3, Numeric = "512" } },
            {"PAB", new CurrencyData { Code = "PAB", Currency = "Panamanian balboa", Exponent = 2, Numeric = "590" } },
            {"PEN", new CurrencyData { Code = "PEN", Currency = "Peruvian Sol", Exponent = 2, Numeric = "604" } },
            {"PGK", new CurrencyData { Code = "PGK", Currency = "Papua New Guinean kina", Exponent = 2, Numeric = "598" } },
            {"PHP", new CurrencyData { Code = "PHP", Currency = "Philippine peso", Exponent = 2, Numeric = "608" } },
            {"PKR", new CurrencyData { Code = "PKR", Currency = "Pakistani rupee", Exponent = 2, Numeric = "586" } },
            {"PLN", new CurrencyData { Code = "PLN", Currency = "Polish złoty", Exponent = 2, Numeric = "985" } },
            {"PYG", new CurrencyData { Code = "PYG", Currency = "Paraguayan guaraní", Exponent = 0, Numeric = "600" } },
            {"QAR", new CurrencyData { Code = "QAR", Currency = "Qatari riyal", Exponent = 2, Numeric = "634" } },
            {"RON", new CurrencyData { Code = "RON", Currency = "Romanian leu", Exponent = 2, Numeric = "946" } },
            {"RSD", new CurrencyData { Code = "RSD", Currency = "Serbian dinar", Exponent = 2, Numeric = "941" } },
            {"RUB", new CurrencyData { Code = "RUB", Currency = "Russian ruble", Exponent = 2, Numeric = "643" } },
            {"RWF", new CurrencyData { Code = "RWF", Currency = "Rwandan franc", Exponent = 0, Numeric = "646" } },
            {"SAR", new CurrencyData { Code = "SAR", Currency = "Saudi riyal", Exponent = 2, Numeric = "682" } },
            {"SBD", new CurrencyData { Code = "SBD", Currency = "Solomon Islands dollar", Exponent = 2, Numeric = "090" } },
            {"SCR", new CurrencyData { Code = "SCR", Currency = "Seychelles rupee", Exponent = 2, Numeric = "690" } },
            {"SDG", new CurrencyData { Code = "SDG", Currency = "Sudanese pound", Exponent = 2, Numeric = "938" } },
            {"SEK", new CurrencyData { Code = "SEK", Currency = "Swedish krona", Exponent = 2, Numeric = "752" } },
            {"SGD", new CurrencyData { Code = "SGD", Currency = "Singapore dollar", Exponent = 2, Numeric = "702" } },
            {"SHP", new CurrencyData { Code = "SHP", Currency = "Saint Helena pound", Exponent = 2, Numeric = "654" } },
            {"SLL", new CurrencyData { Code = "SLL", Currency = "Sierra Leonean leone", Exponent = 2, Numeric = "694" } },
            {"SOS", new CurrencyData { Code = "SOS", Currency = "Somali shilling", Exponent = 2, Numeric = "706" } },
            {"SRD", new CurrencyData { Code = "SRD", Currency = "Surinamese dollar", Exponent = 2, Numeric = "968" } },
            {"STD", new CurrencyData { Code = "STD", Currency = "São Tomé and Príncipe dobra", Exponent = 2, Numeric = "678" } },
            {"SYP", new CurrencyData { Code = "SYP", Currency = "Syrian pound", Exponent = 2, Numeric = "760" } },
            {"SZL", new CurrencyData { Code = "SZL", Currency = "Swazi lilangeni", Exponent = 2, Numeric = "748" } },
            {"THB", new CurrencyData { Code = "THB", Currency = "Thai baht", Exponent = 2, Numeric = "764" } },
            {"TJS", new CurrencyData { Code = "TJS", Currency = "Tajikistani somoni", Exponent = 2, Numeric = "972" } },
            {"TMT", new CurrencyData { Code = "TMT", Currency = "Turkmenistani manat", Exponent = 2, Numeric = "934" } },
            {"TND", new CurrencyData { Code = "TND", Currency = "Tunisian dinar", Exponent = 3, Numeric = "788" } },
            {"TOP", new CurrencyData { Code = "TOP", Currency = "Tongan paʻanga", Exponent = 2, Numeric = "776" } },
            {"TRY", new CurrencyData { Code = "TRY", Currency = "Turkish lira", Exponent = 2, Numeric = "949" } },
            {"TTD", new CurrencyData { Code = "TTD", Currency = "Trinidad and Tobago dollar", Exponent = 2, Numeric = "780" } },
            {"TWD", new CurrencyData { Code = "TWD", Currency = "New Taiwan dollar", Exponent = 2, Numeric = "901" } },
            {"TZS", new CurrencyData { Code = "TZS", Currency = "Tanzanian shilling", Exponent = 2, Numeric = "834" } },
            {"UAH", new CurrencyData { Code = "UAH", Currency = "Ukrainian hryvnia", Exponent = 2, Numeric = "980" } },
            {"UGX", new CurrencyData { Code = "UGX", Currency = "Ugandan shilling", Exponent = 2, Numeric = "800" } },
            {"USD", new CurrencyData { Code = "USD", Currency = "United States dollar", Exponent = 2, Numeric = "840" } },
            {"UYU", new CurrencyData { Code = "UYU", Currency = "Uruguayan peso", Exponent = 2, Numeric = "858" } },
            {"UZS", new CurrencyData { Code = "UZS", Currency = "Uzbekistan som", Exponent = 2, Numeric = "860" } },
            {"VEF", new CurrencyData { Code = "VEF", Currency = "Venezuelan bolívar", Exponent = 2, Numeric = "937" } },
            {"VND", new CurrencyData { Code = "VND", Currency = "Vietnamese dong", Exponent = 0, Numeric = "704" } },
            {"VUV", new CurrencyData { Code = "VUV", Currency = "Vanuatu vatu", Exponent = 0, Numeric = "548" } },
            {"WST", new CurrencyData { Code = "WST", Currency = "Samoan tala", Exponent = 2, Numeric = "882" } },
            {"XAF", new CurrencyData { Code = "XAF", Currency = "CFA franc BEAC", Exponent = 0, Numeric = "950" } },
            {"XCD", new CurrencyData { Code = "XCD", Currency = "East Caribbean dollar", Exponent = 2, Numeric = "951" } },
            {"XOF", new CurrencyData { Code = "XOF", Currency = "CFA franc BCEAO", Exponent = 0, Numeric = "952" } },
            {"XPF", new CurrencyData { Code = "XPF", Currency = "CFP franc", Exponent = 0, Numeric = "953" } },
            {"YER", new CurrencyData { Code = "YER", Currency = "Yemeni rial", Exponent = 2, Numeric = "886" } },
            {"ZAR", new CurrencyData { Code = "ZAR", Currency = "South African rand", Exponent = 2, Numeric = "710" } },
            {"ZMK", new CurrencyData { Code = "ZMK", Currency = "Zambian kwacha", Exponent = 2, Numeric = "894" } },
            {"ZWL", new CurrencyData { Code = "ZWL", Currency = "Zimbabwean dollar", Exponent = 2, Numeric = "716" } }
        };

    }
}
