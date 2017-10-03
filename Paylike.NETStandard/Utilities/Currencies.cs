using Newtonsoft.Json;
using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard.Utilities
{
    public static class Currencies
    {
        public static Dictionary<string, CurrencyData> CurrencyDictionary = new Dictionary<string, CurrencyData>(JsonConvert.DeserializeObject<List<CurrencyData>>(
@"[
	    {
		    ""code"": ""AED"",
            ""currency"": ""United Arab Emirates dirham"",
            ""numeric"": ""784"",
            ""exponent"": 2

        },
	    {
		    ""code"": ""AFN"",
		    ""currency"": ""Afghan afghani"",
		    ""numeric"": ""971"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ALL"",
		    ""currency"": ""Albanian lek"",
		    ""numeric"": ""008"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""AMD"",
		    ""currency"": ""Armenian dram"",
		    ""numeric"": ""051"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ANG"",
		    ""currency"": ""Netherlands Antillean guilder"",
		    ""numeric"": ""532"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""AOA"",
		    ""currency"": ""Angolan kwanza"",
		    ""numeric"": ""973"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ARS"",
		    ""currency"": ""Argentine peso"",
		    ""numeric"": ""032"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""AUD"",
		    ""currency"": ""Australian dollar"",
		    ""numeric"": ""036"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""AWG"",
		    ""currency"": ""Aruban florin"",
		    ""numeric"": ""533"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""AZN"",
		    ""currency"": ""Azerbaijani manat"",
		    ""numeric"": ""944"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BAM"",
		    ""currency"": ""Bosnia and Herzegovina convertible mark"",
		    ""numeric"": ""977"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BBD"",
		    ""currency"": ""Barbados dollar"",
		    ""numeric"": ""052"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BDT"",
		    ""currency"": ""Bangladeshi taka"",
		    ""numeric"": ""050"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BGN"",
		    ""currency"": ""Bulgarian lev"",
		    ""numeric"": ""975"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BHD"",
		    ""currency"": ""Bahraini dinar"",
		    ""numeric"": ""048"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""BIF"",
		    ""currency"": ""Burundian franc"",
		    ""numeric"": ""108"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""BMD"",
		    ""currency"": ""Bermudian dollar"",
		    ""numeric"": ""060"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BND"",
		    ""currency"": ""Brunei dollar"",
		    ""numeric"": ""096"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BOB"",
		    ""currency"": ""Boliviano"",
		    ""numeric"": ""068"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BRL"",
		    ""currency"": ""Brazilian real"",
		    ""numeric"": ""986"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BSD"",
		    ""currency"": ""Bahamian dollar"",
		    ""numeric"": ""044"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BTN"",
		    ""currency"": ""Bhutanese ngultrum"",
		    ""numeric"": ""064"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BWP"",
		    ""currency"": ""Botswana pula"",
		    ""numeric"": ""072"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""BYR"",
		    ""currency"": ""Belarusian ruble"",
		    ""numeric"": ""974"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""BZD"",
		    ""currency"": ""Belize dollar"",
		    ""numeric"": ""084"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CAD"",
		    ""currency"": ""Canadian dollar"",
		    ""numeric"": ""124"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CDF"",
		    ""currency"": ""Congolese franc"",
		    ""numeric"": ""976"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CHF"",
		    ""currency"": ""Swiss franc"",
		    ""numeric"": ""756"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CLP"",
		    ""currency"": ""Chilean peso"",
		    ""numeric"": ""152"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CNY"",
		    ""currency"": ""Chinese yuan"",
		    ""numeric"": ""156"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""COP"",
		    ""currency"": ""Colombian peso"",
		    ""numeric"": ""170"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CRC"",
		    ""currency"": ""Costa Rican colon"",
		    ""numeric"": ""188"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CUP"",
		    ""currency"": ""Cuban peso"",
		    ""numeric"": ""192"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CVE"",
		    ""currency"": ""Cape Verde escudo"",
		    ""numeric"": ""132"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""CZK"",
		    ""currency"": ""Czech koruna"",
		    ""numeric"": ""203"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""DJF"",
		    ""currency"": ""Djiboutian franc"",
		    ""numeric"": ""262"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""DKK"",
		    ""currency"": ""Danish krone"",
		    ""numeric"": ""208"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""DOP"",
		    ""currency"": ""Dominican peso"",
		    ""numeric"": ""214"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""DZD"",
		    ""currency"": ""Algerian dinar"",
		    ""numeric"": ""012"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""EGP"",
		    ""currency"": ""Egyptian pound"",
		    ""numeric"": ""818"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ERN"",
		    ""currency"": ""Eritrean nakfa"",
		    ""numeric"": ""232"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ETB"",
		    ""currency"": ""Ethiopian birr"",
		    ""numeric"": ""230"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""EUR"",
		    ""currency"": ""Euro"",
		    ""numeric"": ""978"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""FJD"",
		    ""currency"": ""Fiji dollar"",
		    ""numeric"": ""242"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""FKP"",
		    ""currency"": ""Falkland Islands pound"",
		    ""numeric"": ""238"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GBP"",
		    ""currency"": ""Pound sterling"",
		    ""numeric"": ""826"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GEL"",
		    ""currency"": ""Georgian lari"",
		    ""numeric"": ""981"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GHS"",
		    ""currency"": ""Ghanaian cedi"",
		    ""numeric"": ""936"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GIP"",
		    ""currency"": ""Gibraltar pound"",
		    ""numeric"": ""292"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GMD"",
		    ""currency"": ""Gambian dalasi"",
		    ""numeric"": ""270"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GNF"",
		    ""currency"": ""Guinean franc"",
		    ""numeric"": ""324"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""GTQ"",
		    ""currency"": ""Guatemalan quetzal"",
		    ""numeric"": ""320"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""GYD"",
		    ""currency"": ""Guyanese dollar"",
		    ""numeric"": ""328"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""HKD"",
		    ""currency"": ""Hong Kong dollar"",
		    ""numeric"": ""344"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""HNL"",
		    ""currency"": ""Honduran lempira"",
		    ""numeric"": ""340"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""HRK"",
		    ""currency"": ""Croatian kuna"",
		    ""numeric"": ""191"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""HTG"",
		    ""currency"": ""Haitian gourde"",
		    ""numeric"": ""332"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""HUF"",
		    ""currency"": ""Hungarian forint"",
		    ""numeric"": ""348"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""IDR"",
		    ""currency"": ""Indonesian rupiah"",
		    ""numeric"": ""360"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ILS"",
		    ""currency"": ""Israeli new shekel"",
		    ""numeric"": ""376"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""INR"",
		    ""currency"": ""Indian rupee"",
		    ""numeric"": ""356"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""IQD"",
		    ""currency"": ""Iraqi dinar"",
		    ""numeric"": ""368"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""IRR"",
		    ""currency"": ""Iranian rial"",
		    ""numeric"": ""364"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ISK"",
		    ""currency"": ""Icelandic króna"",
		    ""numeric"": ""352"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""JMD"",
		    ""currency"": ""Jamaican dollar"",
		    ""numeric"": ""388"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""JOD"",
		    ""currency"": ""Jordanian dinar"",
		    ""numeric"": ""400"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""JPY"",
		    ""currency"": ""Japanese yen"",
		    ""numeric"": ""392"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""KES"",
		    ""currency"": ""Kenyan shilling"",
		    ""numeric"": ""404"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""KGS"",
		    ""currency"": ""Kyrgyzstani som"",
		    ""numeric"": ""417"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""KHR"",
		    ""currency"": ""Cambodian riel"",
		    ""numeric"": ""116"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""KMF"",
		    ""currency"": ""Comoro franc"",
		    ""numeric"": ""174"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""KPW"",
		    ""currency"": ""North Korean won"",
		    ""numeric"": ""408"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""KRW"",
		    ""currency"": ""South Korean won"",
		    ""numeric"": ""410"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""KWD"",
		    ""currency"": ""Kuwaiti dinar"",
		    ""numeric"": ""414"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""KYD"",
		    ""currency"": ""Cayman Islands dollar"",
		    ""numeric"": ""136"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""KZT"",
		    ""currency"": ""Kazakhstani tenge"",
		    ""numeric"": ""398"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""LAK"",
		    ""currency"": ""Lao kip"",
		    ""numeric"": ""418"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""LBP"",
		    ""currency"": ""Lebanese pound"",
		    ""numeric"": ""422"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""LKR"",
		    ""currency"": ""Sri Lankan rupee"",
		    ""numeric"": ""144"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""LRD"",
		    ""currency"": ""Liberian dollar"",
		    ""numeric"": ""430"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""LSL"",
		    ""currency"": ""Lesotho loti"",
		    ""numeric"": ""426"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MAD"",
		    ""currency"": ""Moroccan dirham"",
		    ""numeric"": ""504"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MDL"",
		    ""currency"": ""Moldovan leu"",
		    ""numeric"": ""498"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MGA"",
		    ""currency"": ""Malagasy ariary"",
		    ""numeric"": ""969"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MKD"",
		    ""currency"": ""Macedonian denar"",
		    ""numeric"": ""807"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MMK"",
		    ""currency"": ""Myanmar kyat"",
		    ""numeric"": ""104"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MNT"",
		    ""currency"": ""Mongolian tögrög"",
		    ""numeric"": ""496"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MOP"",
		    ""currency"": ""Macanese pataca"",
		    ""numeric"": ""446"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MRO"",
		    ""currency"": ""Mauritanian ouguiya"",
		    ""numeric"": ""478"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MUR"",
		    ""currency"": ""Mauritian rupee"",
		    ""numeric"": ""480"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MVR"",
		    ""currency"": ""Maldivian rufiyaa"",
		    ""numeric"": ""462"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MWK"",
		    ""currency"": ""Malawian kwacha"",
		    ""numeric"": ""454"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MXN"",
		    ""currency"": ""Mexican peso"",
		    ""numeric"": ""484"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MYR"",
		    ""currency"": ""Malaysian ringgit"",
		    ""numeric"": ""458"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""MZN"",
		    ""currency"": ""Mozambican metical"",
		    ""numeric"": ""943"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NAD"",
		    ""currency"": ""Namibian dollar"",
		    ""numeric"": ""516"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NGN"",
		    ""currency"": ""Nigerian naira"",
		    ""numeric"": ""566"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NIO"",
		    ""currency"": ""Nicaraguan córdoba"",
		    ""numeric"": ""558"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NOK"",
		    ""currency"": ""Norwegian krone"",
		    ""numeric"": ""578"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NPR"",
		    ""currency"": ""Nepalese rupee"",
		    ""numeric"": ""524"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""NZD"",
		    ""currency"": ""New Zealand dollar"",
		    ""numeric"": ""554"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""OMR"",
		    ""currency"": ""Omani rial"",
		    ""numeric"": ""512"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""PAB"",
		    ""currency"": ""Panamanian balboa"",
		    ""numeric"": ""590"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PEN"",
		    ""currency"": ""Peruvian Sol"",
		    ""numeric"": ""604"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PGK"",
		    ""currency"": ""Papua New Guinean kina"",
		    ""numeric"": ""598"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PHP"",
		    ""currency"": ""Philippine peso"",
		    ""numeric"": ""608"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PKR"",
		    ""currency"": ""Pakistani rupee"",
		    ""numeric"": ""586"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PLN"",
		    ""currency"": ""Polish złoty"",
		    ""numeric"": ""985"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""PYG"",
		    ""currency"": ""Paraguayan guaraní"",
		    ""numeric"": ""600"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""QAR"",
		    ""currency"": ""Qatari riyal"",
		    ""numeric"": ""634"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""RON"",
		    ""currency"": ""Romanian leu"",
		    ""numeric"": ""946"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""RSD"",
		    ""currency"": ""Serbian dinar"",
		    ""numeric"": ""941"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""RUB"",
		    ""currency"": ""Russian ruble"",
		    ""numeric"": ""643"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""RWF"",
		    ""currency"": ""Rwandan franc"",
		    ""numeric"": ""646"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""SAR"",
		    ""currency"": ""Saudi riyal"",
		    ""numeric"": ""682"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SBD"",
		    ""currency"": ""Solomon Islands dollar"",
		    ""numeric"": ""090"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SCR"",
		    ""currency"": ""Seychelles rupee"",
		    ""numeric"": ""690"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SDG"",
		    ""currency"": ""Sudanese pound"",
		    ""numeric"": ""938"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SEK"",
		    ""currency"": ""Swedish krona"",
		    ""numeric"": ""752"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SGD"",
		    ""currency"": ""Singapore dollar"",
		    ""numeric"": ""702"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SHP"",
		    ""currency"": ""Saint Helena pound"",
		    ""numeric"": ""654"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SLL"",
		    ""currency"": ""Sierra Leonean leone"",
		    ""numeric"": ""694"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SOS"",
		    ""currency"": ""Somali shilling"",
		    ""numeric"": ""706"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SRD"",
		    ""currency"": ""Surinamese dollar"",
		    ""numeric"": ""968"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""STD"",
		    ""currency"": ""São Tomé and Príncipe dobra"",
		    ""numeric"": ""678"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SYP"",
		    ""currency"": ""Syrian pound"",
		    ""numeric"": ""760"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""SZL"",
		    ""currency"": ""Swazi lilangeni"",
		    ""numeric"": ""748"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""THB"",
		    ""currency"": ""Thai baht"",
		    ""numeric"": ""764"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TJS"",
		    ""currency"": ""Tajikistani somoni"",
		    ""numeric"": ""972"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TMT"",
		    ""currency"": ""Turkmenistani manat"",
		    ""numeric"": ""934"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TND"",
		    ""currency"": ""Tunisian dinar"",
		    ""numeric"": ""788"",
		    ""exponent"": 3
	    },
	    {
		    ""code"": ""TOP"",
		    ""currency"": ""Tongan paʻanga"",
		    ""numeric"": ""776"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TRY"",
		    ""currency"": ""Turkish lira"",
		    ""numeric"": ""949"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TTD"",
		    ""currency"": ""Trinidad and Tobago dollar"",
		    ""numeric"": ""780"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TWD"",
		    ""currency"": ""New Taiwan dollar"",
		    ""numeric"": ""901"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""TZS"",
		    ""currency"": ""Tanzanian shilling"",
		    ""numeric"": ""834"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""UAH"",
		    ""currency"": ""Ukrainian hryvnia"",
		    ""numeric"": ""980"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""UGX"",
		    ""currency"": ""Ugandan shilling"",
		    ""numeric"": ""800"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""USD"",
		    ""currency"": ""United States dollar"",
		    ""numeric"": ""840"",
		    ""funding"": true,
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""UYU"",
		    ""currency"": ""Uruguayan peso"",
		    ""numeric"": ""858"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""UZS"",
		    ""currency"": ""Uzbekistan som"",
		    ""numeric"": ""860"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""VEF"",
		    ""currency"": ""Venezuelan bolívar"",
		    ""numeric"": ""937"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""VND"",
		    ""currency"": ""Vietnamese dong"",
		    ""numeric"": ""704"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""VUV"",
		    ""currency"": ""Vanuatu vatu"",
		    ""numeric"": ""548"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""WST"",
		    ""currency"": ""Samoan tala"",
		    ""numeric"": ""882"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""XAF"",
		    ""currency"": ""CFA franc BEAC"",
		    ""numeric"": ""950"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""XCD"",
		    ""currency"": ""East Caribbean dollar"",
		    ""numeric"": ""951"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""XOF"",
		    ""currency"": ""CFA franc BCEAO"",
		    ""numeric"": ""952"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""XPF"",
		    ""currency"": ""CFP franc"",
		    ""numeric"": ""953"",
		    ""exponent"": 0
	    },
	    {
		    ""code"": ""YER"",
		    ""currency"": ""Yemeni rial"",
		    ""numeric"": ""886"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ZAR"",
		    ""currency"": ""South African rand"",
		    ""numeric"": ""710"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ZMK"",
		    ""currency"": ""Zambian kwacha"",
		    ""numeric"": ""894"",
		    ""exponent"": 2
	    },
	    {
		    ""code"": ""ZWL"",
		    ""currency"": ""Zimbabwean dollar"",
		    ""numeric"": ""716"",
		    ""exponent"": 2
	    }
        ]").ToDictionary(x => x.Code));
    }
}
