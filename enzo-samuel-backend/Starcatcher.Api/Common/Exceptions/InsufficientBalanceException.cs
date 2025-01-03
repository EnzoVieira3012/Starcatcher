using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class InsufficientBalanceException : CustomException
    {
        public InsufficientBalanceException() : base("Insufficient balance", 403) { }
    }
}