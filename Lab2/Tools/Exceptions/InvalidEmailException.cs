using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tools.Exceptions
{
    internal class InvalidEmailException : Exception
    {
        public InvalidEmailException(string email) : base($"Error! You entered invalid email: {email}")
        {

        }
    }
}
