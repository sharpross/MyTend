using FluentScheduler;
using MyTend.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTend.Services.EmailService;

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
                .FindAll();

            if (tenders.Count() > 0)
            {
                tenders = tenders.Where(x => x.IsActive == true)
                    .Where(x => x.DateEnd <= DateTime.Now).ToArray();
            }

            foreach (var tender in tenders)
            {
                tender.IsActive = false;

                tender.Update();

                this.Notifie(tender);
            }
        }

        private void Notifie(Tender tender)
        {
            var service = new EmailService(tender.User.Email);

            service.CloseTenderByTime(tender.Title, tender.Id, tender.User.FullName);
        }

        public void Execute()
        {
            this.Init();

            this.Run();
        }
    }
}
