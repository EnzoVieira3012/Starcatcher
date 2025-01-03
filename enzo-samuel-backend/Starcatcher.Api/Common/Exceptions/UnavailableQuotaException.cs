using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class UnavailableQuotaException : CustomException
    {
        public UnavailableQuotaException() : base("Quota is unavailable", 400) { }
    }
}