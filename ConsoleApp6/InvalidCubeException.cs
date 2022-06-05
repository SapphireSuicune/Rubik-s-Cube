using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksSolver
{
    public class InvalidCubeException : Exception
    {
        public InvalidCubeException() { }
        public InvalidCubeException(string message) : base(message) { }
        public InvalidCubeException (string message, Exception innerException) : base(message, innerException) { }
    }
}
