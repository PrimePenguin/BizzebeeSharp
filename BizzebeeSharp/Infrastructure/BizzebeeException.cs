using System;
using System.Net;

namespace BizzebeeSharp.Infrastructure
{
    public class BizzebeeException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        /// <summary>An error code for this type of error</summary>
        public string Error { get; set; }

        /// <summary>A human readable description of the error</summary>
        //[JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        public BizzebeeException() { }

        public BizzebeeException(string message) : base(message) { }

        public BizzebeeException(HttpStatusCode httpStatusCode, string error, string description) : base(error)
        {
            HttpStatusCode = httpStatusCode;
            Error = error;
            ErrorDescription = description;
        }
    }
}
