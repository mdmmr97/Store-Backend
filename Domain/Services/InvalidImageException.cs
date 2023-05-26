﻿using System.Runtime.Serialization;

namespace Store_Backend.Domain.Services
{
    [Serializable]
    internal class InvalidImageException : Exception
    {
        public InvalidImageException()
        {
        }

        public InvalidImageException(string? message) : base(message)
        {
        }

        public InvalidImageException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidImageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}