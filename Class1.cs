using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ExceptionHandling
{
    class Class1
    {
    }
    [Serializable]
    class StudentNotFoundException : Exception
    {
        public string StudentName { get; set; }
        public StudentNotFoundException() { }

        public StudentNotFoundException(string message) : base(message)  {}

    //Console.WriteLine("alling base class message displayed here");
        public StudentNotFoundException(string Message, Exception InnerException) : base(Message, InnerException) {}

        public StudentNotFoundException(string message, string studentName)
    : this(message)
        {
            StudentName = StudentName;
        }
        
 
    }
}
