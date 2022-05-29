using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class MemberFee
    {
        String id;
        String MID;
        String isPaid;
        String fineCount;
        DateTime lastUpdated;

        public MemberFee(string isPaid, DateTime lastUpdated)
        {
            this.isPaid = isPaid;
            this.lastUpdated = lastUpdated;
        }

        public MemberFee(string id, string mID, string isPaid, string fineCount, DateTime lastUpdated)
        {
            this.id = id;
            MID = mID;
            this.isPaid = isPaid;
            this.fineCount = fineCount;
            this.lastUpdated = lastUpdated;
        }

        public string Id { get => id; set => id = value; }
        public string MID1 { get => MID; set => MID = value; }
        public string IsPaid { get => isPaid; set => isPaid = value; }
        public string FineCount { get => fineCount; set => fineCount = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
    }
}
