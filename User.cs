using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class User
    {
        private static int _counter=0;
        private string _name { get; set; }
       private string _surname { get; set; }
        private string _password { get; set; }
        public int Id { get; set; }
        public User(string name,string surname)
        {
            _counter++;
            Id = _counter;
            
           


        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if(value!= null && value.Length <= 8 && value[0] >= 'A' && value[0] <= 'Z')
                {
                    _password = value;
                }
                else
                {
                    throw new InvalidePasswordException();
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value!=null && value.IsNormalized())
                {
                    _name = value;
                }
                else
                {
                    throw new InvalideNameException();
                }
                
            }

        }
        public string Surname
        {
            get
            {
                return Surname;
            }
            set
            {
                if(value!=null && value.IsNormalized())
                {
                    _surname = value;
                }
                else
                {
                    throw new InvalideSurnameException();
                }

            }
        }
    }
}
