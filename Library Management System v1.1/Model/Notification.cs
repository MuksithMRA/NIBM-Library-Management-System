using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Notification
    { 

        String id;
        String LID;
        String description;
        DateTime recievedDateTime;

        public Notification(string id, string lID, string description, DateTime recievedDateTime)
        {
            this.id = id;
            LID = lID;
            this.description = description;
            this.recievedDateTime = recievedDateTime;
        }

        public string Id { get => id; set => id = value; }
        public string LID1 { get => LID; set => LID = value; }
        public string Description { get => description; set => description = value; }
        public DateTime RecievedDateTime { get => recievedDateTime; set => recievedDateTime = value; }
    }
}
