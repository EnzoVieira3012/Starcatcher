using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class UnauthorizedException : CustomException
    {
        public UnauthorizedException() : base("Invalid Credentials", 401) { }
    }
}