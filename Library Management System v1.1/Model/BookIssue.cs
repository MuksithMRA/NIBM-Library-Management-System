using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class BookIssue
    {
        String id;
        String BID;
        String MID;
        String LID;
        DateTime issuedDateTime;
        DateTime returnDateTime;

        public BookIssue(string id, string bID, string mID, string lID, DateTime issuedDateTime, DateTime returnDateTime)
        {
            this.id = id;
            BID = bID;
            MID = mID;
            LID = lID;
            this.issuedDateTime = issuedDateTime;
            this.returnDateTime = returnDateTime;
        }

        public string Id { get => id; set => id = value; }
        public string BID1 { get => BID; set => BID = value; }
        public string MID1 { get => MID; set => MID = value; }
        public string LID1 { get => LID; set => LID = value; }
        public DateTime IssuedDateTime { get => issuedDateTime; set => issuedDateTime = value; }
        public DateTime ReturnDateTime { get => returnDateTime; set => returnDateTime = value; }
    }
}
