using System;
using System.Runtime.Serialization;

namespace Lesson13_HomeWork_Exception
{
    [Serializable]
    internal class CustomExсeption : Exception
    {
        public CustomExсeption()
        {
        }

        public CustomExсeption(string message) : base(message)
        {
        }

        public CustomExсeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CustomExсeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}