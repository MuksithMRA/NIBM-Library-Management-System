using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    public class Librarian
    {
        String id;
        String name;
        String address;
        String email;
        String NIC;
        String phone;
        DateTime updatedDate;
        DateTime addedDate;

        public Librarian(string id, string name, string address, string email,  string nIC, String phone , DateTime updatedDate, DateTime addedDate)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.updatedDate = updatedDate;
            this.addedDate = addedDate;
            NIC = nIC;
            this.phone = phone;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public DateTime UpdatedDate { get => updatedDate; set => updatedDate = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
        public string NIC1 { get => NIC; set => NIC = value; }
        public String Phone { get => phone; set => phone = value; }
    }
}
