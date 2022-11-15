namespace Lesson_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oclock oclock = new Oclock(20, "Time is over");
            Observer observer = new Observer();

            oclock.DelegateEvents += observer.OutPutMessage;
            oclock.DelegateEvents += observer.OutPutMessageLambda;
            oclock.DelegateEvents += observer.time;
            oclock.Start();
        }
    }
}