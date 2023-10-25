using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class InvalideNameException:Exception
    {
        public InvalideNameException()
        {

        }
        public InvalideNameException(string message):base(message)
        {

        }
    }
   
}
