using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Author
    {
        String id;
        String name;
        DateTime addedDateTime;

        public Author(string id, string name, DateTime addedDateTime)
        {
            this.id = id;
            this.name = name;
            this.addedDateTime = addedDateTime;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime AddedDate { get => addedDateTime; set => addedDateTime = value; }
    }
}
