using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestNumber
{
    public class FindTheNumberCustomException : Exception
    {
        public enum ExceptionType
        {
            No_Such_Class,
            No_Such_Method
        }

        private readonly ExceptionType type;

        public FindTheNumberCustomException(ExceptionType type,string message): base(message)
        {
            this.type = type;
        }
    }
}
