using System.Net;

namespace BizzebeeSharp.Infrastructure
{
    /// <summary>
    /// An exception thrown when an API call has reached Bizzebee's rate limit.
    /// </summary>
    public class BizzebeeRateLimitException : BizzebeeException
    {
        public BizzebeeRateLimitException() : base() { }

        public BizzebeeRateLimitException(string message): base(message) { }

        public BizzebeeRateLimitException(HttpStatusCode httpStatusCode, string error, string jsonError) : base(httpStatusCode, error, jsonError) { }
    }
}
