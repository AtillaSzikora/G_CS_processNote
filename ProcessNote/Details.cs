using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessNote
{
    public class Details
    {
        public string ProcessName { get; }
        public TimeSpan CPUUsage { get; }
        public long MemoryUsage { get; }
        public double RunningTime { get; }
        public DateTime StartTime { get; }
        ProcessThreadCollection Threads { get; }

        public Details(System.Diagnostics.Process aProcess)
        {
            ProcessName = aProcess.ProcessName;
            CPUUsage = aProcess.PrivilegedProcessorTime;
            MemoryUsage = aProcess.PagedMemorySize64;
            StartTime = aProcess.StartTime;
            RunningTime = (DateTime.Now - StartTime).TotalMilliseconds;
            Threads = aProcess.Threads;
        }
    }
}
