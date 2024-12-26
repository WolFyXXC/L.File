using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Error
    {
        [Serializable]
        internal class InfinityException : Exception
        {
            public InfinityException()
            {
            }

            public InfinityException(string message) : base(message)
            {
            }

            public InfinityException(string message, Exception innerException) : base(message, innerException)
            {
            }

            protected InfinityException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
    }
}
