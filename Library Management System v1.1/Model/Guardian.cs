using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Guardian
    {
        String id;
        String name;
        String NIC;
        String address;
        String phone;
        DateTime updateDate;

        public Guardian(string id, string name, string nIC, string address, String phone, DateTime updateDate)
        {
            this.id = id;
            this.name = name;
            NIC = nIC;
            this.address = address;
            this.phone = phone;
            this.updateDate = updateDate;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public string Address { get => address; set => address = value; }
        public String Phone { get => phone; set => phone = value; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
    }
}
