using System.Runtime.Serialization;

namespace task1scenarios.StepDefinitions
{
    [Serializable]
    internal class ElementVisibilityException : Exception
    {
        public ElementVisibilityException()
        {
        }

        public ElementVisibilityException(string? message) : base(message)
        {
        }

        public ElementVisibilityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ElementVisibilityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}