using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class EmailInUseException : CustomException
    {
        public EmailInUseException() : base("Email already in use", 409) { }
    }
}