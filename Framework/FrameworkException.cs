using System;
using System.Runtime.Serialization;

namespace Framework
{
    public class FrameworkException : Exception
    {
        public FrameworkException(string message) : base(message)
        {
        }
        public FrameworkException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
