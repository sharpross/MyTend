using FluentScheduler;
using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Scheduler.CloseTender
{
    /// <summary>
    /// Задача: закрытие тендера по расписанию в 00:00
    /// </summary>
    public class CloseTenderTask : Registry, ISingleTask, ITask
    {
        public void Init()
        {
            
        }

        public void Run()
        {
            var tenders = Tender
                .FindAll()
                .Where(x => x.IsActive == true)
                .Where(x => x.DateEnd <= DateTime.Now);

            foreach (var tender in tenders)
            {
                tender.IsActive = false;
                tender.Update();
            }
        }

        public void Execute()
        {
            this.Init();

            this.Run();
        }
    }
}
