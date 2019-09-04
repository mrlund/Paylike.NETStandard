using Paylike.NETStandard.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Paylike.NETStandard
{
    public class PaylikeApiResponse<T> where T : class
    {
        private ErrorResponse _errorResponse { get; set; }

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
            _errorResponse = error; 
        }

        public PaylikeApiResponse(T source)
        {
            Result = source;
            IsSuccessStatusCode = true; 
        }

        public ErrorResponse GetError()
        {
            return _errorResponse; 
        }


    }
}
