using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class InvalideSurnameException:Exception
    {
        public InvalideSurnameException()
        {

        }
        public InvalideSurnameException(string message):base(message)
        {

        }
    }
}
