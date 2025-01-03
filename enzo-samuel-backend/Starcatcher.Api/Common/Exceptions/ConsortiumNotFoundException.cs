using System;

namespace Starcatcher.Api.Common.Exceptions
{
    public class ConsortiumNotFoundException : CustomException
    {
        public ConsortiumNotFoundException() : base("Consortium not found", 404) { }
    }
}