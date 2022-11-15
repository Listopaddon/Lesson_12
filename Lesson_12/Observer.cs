using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_12.Oclock;

namespace Lesson_12
{
    public class Observer
    {
        public void OutPutMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void OutPutMessageLambda(string message) => Console.WriteLine(message + " - it's Lambda");

        public TimeIsOver time = delegate (string message)
            {
                Console.WriteLine("Anonymus method");
            };

    }
}
