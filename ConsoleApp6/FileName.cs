using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class StopWatch
    
        {
            private DateTime startTime;
            private DateTime endTime;

            public DateTime StartTime => startTime;
            public DateTime EndTime => endTime;

            public StopWatch()
            {
                startTime = DateTime.Now;
            }

            public void Start()
            {
                startTime = DateTime.Now;
            }

            public void Stop()
            {
                endTime = DateTime.Now;
            }

            public DateTime GetStartTime()
            {
                return startTime;
            }
            public DateTime GetEndTime()
            {
                return endTime;
            }
            public double GetElapseTime()
            {
                /* double startTicks = startTime.Millisecond;
                double endTicks = endTime.Millisecond;
                return endTicks - startTicks; */
                return endTime.Millisecond - startTime.Millisecond;

            }
        }
    }

