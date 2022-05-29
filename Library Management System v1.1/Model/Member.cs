using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Member
    {
        String memberId;
        String name;
        String address;
        String phoneNo;
        String NIC;
    
        String guardianId;
        DateTime updated_date;
        DateTime added_date;

        public Member(string memberId, string name, string address, String phoneNo, string nIC, String guardianId, DateTime updated_date, DateTime added_date)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phoneNo = phoneNo;
            NIC = nIC;
            this.guardianId = guardianId;
            this.updated_date = updated_date;
            this.added_date = added_date;
        
        }

        public string MemberId { get => memberId; set => memberId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public String PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public DateTime Updated_date { get => updated_date; set => updated_date = value; }
        public DateTime Added_date { get => added_date; set => added_date = value; }
        public String GuardianId { get => guardianId; set => guardianId = value; }
    }
}
