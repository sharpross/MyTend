using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentScheduler;

namespace MyTend.Scheduler.ClearSmsSendFacts
{
    public class ClearFacts : Registry
    {
        public ClearFacts()
        {
            Schedule<ClearSmsSendFacts>()
                .ToRunEvery(1).Days().At(0, 5);
        }
    }
}
