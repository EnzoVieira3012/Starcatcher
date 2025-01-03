using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class ConsortiumIsClosedException : CustomException
    {
        public ConsortiumIsClosedException() : base("Consortium is closed", 400) { }
    }
}