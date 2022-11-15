using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{

    public delegate void TimeIsOver(string message);

    public class Oclock
    {
        public int Time { get; private set; }

        public string Message { get; private set; }

        public event TimeIsOver? DelegateEvents;


        public Oclock(int time, string message)
        {
            Time = time;
            Message = message;
        }

        public void Start()
        {            
            Thread.Sleep(Time);
            if(DelegateEvents != null)
            {
                DelegateEvents?.Invoke(Message);
            }            
        }

    }
}
