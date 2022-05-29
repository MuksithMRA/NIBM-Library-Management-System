using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Fine
    {
        String id;
        String MID;
        String BID;
        String LID;
        String reason;

        public Fine(string id, string mID, string bID, string lID, string reason)
        {
            this.id = id;
            MID = mID;
            BID = bID;
            LID = lID;
            this.reason = reason;
        }

        public string Id { get => id; set => id = value; }
        public string MID1 { get => MID; set => MID = value; }
        public string BID1 { get => BID; set => BID = value; }
        public string LID1 { get => LID; set => LID = value; }
        public string Reason { get => reason; set => reason = value; }
    }
}
