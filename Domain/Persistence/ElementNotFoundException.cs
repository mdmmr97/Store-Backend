﻿using System.Runtime.Serialization;

namespace Store_Backend.Domain.Persistence
{
    [Serializable]
    internal class ElementNotFoundException : Exception
    {
        public ElementNotFoundException()
        {
        }

        public ElementNotFoundException(string? message) : base(message)
        {
        }

        public ElementNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ElementNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}