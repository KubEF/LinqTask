using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTask
{
    class Record
    {
        public User Author { get; set; }
        public String Message { get; set; }
        public Record(User author, String message)
        {
            Author = author;
            Message = message;
        }
    }
}
