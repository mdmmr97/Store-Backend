using System.Runtime.Serialization;

namespace Store_Backend.Domain.Persistence
{
    [Serializable]
    internal class ForeingKeyException : Exception
    {
        public ForeingKeyException() { }
        public ForeingKeyException(string? message) : base(message) { }
        public ForeingKeyException(string? message, Exception? innerException) : base(message, innerException) { }
        protected ForeingKeyException(SerializationInfo info , StreamingContext context) : base(info, context) { }
    }
}
