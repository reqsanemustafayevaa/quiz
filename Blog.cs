using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Blog
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        private static int counter = 0;
        public Blog()
        {
            counter++;
            Id =counter.ToString();
        }

    }
}
