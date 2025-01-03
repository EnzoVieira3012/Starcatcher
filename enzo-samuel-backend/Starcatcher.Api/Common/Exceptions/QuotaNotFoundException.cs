using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class QuotaNotFoundException : CustomException
    {
        public QuotaNotFoundException() : base("Quota not found", 404) { }
    }
}