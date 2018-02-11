using System;
using FluentScheduler;
using MyTend.Entites;

namespace MyTend.Scheduler.ClearSmsSendFacts
{
    public class ClearSmsSendFacts : Registry, ISingleTask, ITask
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            
        }

        public void Run()
        {
            var facts = SmsSendFact.FindAll();

            foreach (var fact in facts)
            {
                fact.Delete();
            }
        }
    }
}
