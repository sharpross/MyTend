using MyTend.Entites;
using MyTender.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Models
{
    public class CloseTenderModel
    {
        public Tender Tender { get; set; }

        public UserSystem Winner { get; set; }

        private AuthService Auth { get; set; }

        private FriendModel Friend { get; set; }

        public CloseTenderModel(int userId, int tenderId)
        {
            this.Winner = UserSystem.GetById(userId);
            this.Tender = Tender.GetById(tenderId);
            this.Friend = new FriendModel(this.Winner.Login);
        }

        public void Cancel()
        {
            if (this.Winner.Id == this.Tender.User.Id)
            {
                this.Tender.Cancel();
            }
        }

        public bool Close()
        {
            this.Tender.SetWinner(this.Winner);

            this.Friend.Save();

            return true;
        }
    }
}
