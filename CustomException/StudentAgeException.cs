using System;
using System.Runtime.Serialization;

namespace CustomException
{
    public class StudentAgeException : Exception
    {
        public StudentAgeException()
        {
        }

        public StudentAgeException(string message) : base(message)
        {
        }
    }
}