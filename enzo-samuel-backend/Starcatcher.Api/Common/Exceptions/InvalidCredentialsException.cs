using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class InvalidCredentialsException : CustomException
    {
        public InvalidCredentialsException() : base("Invalid credentials", 400) { }
    }
}