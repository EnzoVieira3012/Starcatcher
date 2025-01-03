using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class WalletNotFoundException : CustomException
    {
        public WalletNotFoundException() : base("Wallet not found", 404) { }
    }
}