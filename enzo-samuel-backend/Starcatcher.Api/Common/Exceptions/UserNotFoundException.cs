using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class UserNotFoundException : CustomException
    {
        public UserNotFoundException() : base("User not found", 404) { }
    }
}