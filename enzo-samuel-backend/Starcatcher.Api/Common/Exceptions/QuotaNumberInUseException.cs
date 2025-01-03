using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class QuotaNumberInUseException : CustomException
    {
        public QuotaNumberInUseException() : base("Quota number already in use", 409) { }
    }
}