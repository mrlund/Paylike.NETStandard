using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard
{
    public class PaylikeApiResponse<T> where T : class
    {
        public bool IsSuccessStatusCode { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public T Result { get; set; }

        public PaylikeApiResponse()
        {
            IsSuccessStatusCode = false; 
        }

        public PaylikeApiResponse(ErrorResponse error)
        {
            IsSuccessStatusCode = false;
            ErrorMessage = error?.message;
            ErrorCode = error?.code;
        }

        public PaylikeApiResponse(T source)
        {
            Result = source;
            IsSuccessStatusCode = true; 
        }


    }
}
