using System;
using System.Threading;


//created a stopwatch with C#, able to calculate start, end time and duration of the watch

namespace StopWatch
{
    class Program
    
    {
        
        private static void Main(string[] args)
        {
            var stopwatch = new StopWawtch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start();
                Thread.Sleep(1000);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to Start.");
                
            }
        }
    }

    public class StopWatch
    {
        
        private bool _running;
        private DateTime _startTime;
        private DateTime _endTime;

        public void Start()
        {
            if (_running)  
                throw new InvalidOperationException("The stopwatch is running");

            _startTime = DateTime.Now; 
            _running = true;

        }

        public void Stop()
        {
            if (!_running)

                if (_running) 
                    throw new InvalidOperationException("The stopwatch is not running");

            _endTime = DateTime.Now; 
            _running = false;

        }
    }

    public TimeSpan GetInterval()
    {
       private DateTime duration;
    duration = _endTime - _startTime;
    }

}