using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tools.Exceptions
{
    internal class InvalidSurnameException : Exception
    {
        public InvalidSurnameException(string surname) : base($"Error! Entered surname {surname} is invalid. You must use a-z letters of both registers.")
        {

        }
    }
}

