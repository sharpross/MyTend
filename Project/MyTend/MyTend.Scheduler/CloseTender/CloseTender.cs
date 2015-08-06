using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace MyTend.Scheduler.CloseTender
{
    public class CloseTender : Registry
    {
        public CloseTender()
        {
            Schedule<CloseTenderTask>()
                .ToRunEvery(1).Days()
                .At(0, 0);
        }
    }
}
