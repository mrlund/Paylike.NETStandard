using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard.Entities
{
    public class ErrorResponse
    {
        public string message { get; set; }
        public int code { get; set; }
        public bool client { get; set; }
        public bool merchant { get; set; }

    }
}
