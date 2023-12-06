using System;
using System.Threading;

namespace WinForms_OwnTimer
{
    public partial class OwnTimer
    {
        public class MyTimer
        {
            private System.Threading.Timer timer;
            private int interval;

            public event EventHandler TimeElapsed;
            public event EventHandler OnError;

            public MyTimer(int interval)
            {
                this.interval = interval;
            }

            public void Start()
            {
                timer = new System.Threading.Timer(TimerCallback, null, 0, interval);
            }

            public void Stop()
            {
                timer?.Change(Timeout.Infinite, Timeout.Infinite);
            }

            private void TimerCallback(object state)
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(_ => TimeElapsed?.Invoke(this, EventArgs.Empty));
                }
                catch (Exception)
                {
                    ThreadPool.QueueUserWorkItem(_ => OnError?.Invoke(this, EventArgs.Empty));
                }
            }
        }
    }
}