using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome.Exceptions
{
    [Serializable]
    public class EmployeeContainsALetterException : Exception
    {
        public EmployeeContainsALetterException()
        {
        }

        public EmployeeContainsALetterException(string message) : base(message)
        {
        }

        public EmployeeContainsALetterException(string message, Exception inner) : base(message, inner)
        {
        }

        protected EmployeeContainsALetterException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
