using System;
using System.Data;
using System.Timers;

namespace Stopwatch_Exercise
{
    public class Stopwatch
    {
        private DateTime _startTime = DateTime.UtcNow;
        public System.Timers.Timer ATimer;

        public TimeSpan Duration { get; private set; }
        public bool IsRunning { get; private set; }

        public void Start()
        {
            if (IsRunning)

                throw new InvalidOperationException("the stopwatch has already started running.");

            _startTime = DateTime.UtcNow; 
            IsRunning = true;
        }

        public void Stop()
        {
            if (!IsRunning)
                throw new InvalidOperationException("the stopwatch has not been started");

            IsRunning = false;
            Duration = DateTime.UtcNow - _startTime;
        }

        public  void SetTimer()
        {
            ATimer = new System.Timers.Timer(400);
            ATimer.Elapsed += OnTimedEvent;
            ATimer.AutoReset = true;
            ATimer.Enabled = true;

        } 
        public void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("time Elapsed {0:mm:ss}",e.SignalTime);
        }

    }

}