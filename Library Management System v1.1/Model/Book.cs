using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Model
{
    class Book
    {
        String id;
        String name;
        String category;
        String author;
        String isbn;
        String availibility;
        String rackNo;
        DateTime addedDate;
        DateTime updatedDate;

        

        public Book(string id, string name, string category, string author, string isbn, string availibility, string rackNo, DateTime addedDate, DateTime updatedDate)
        {
            this.id = id;
            this.name = name;
            this.category = category;
            this.author = author;
            this.isbn = isbn;
            this.availibility = availibility;
            this.rackNo = rackNo;
            this.addedDate = addedDate;
            this.updatedDate = updatedDate;
        }

        public Book(string name, string category, string author)
        {
            this.name = name;
            this.category = category;
            this.author = author;
        }

        public Book(String isbn, String name, String category, String author, String rackNo)
        {
            this.isbn = isbn;
            this.name = name;
            this.category = category;
            this.author = author;
            this.rackNo = rackNo;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Author { get => author; set => author = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Availibility { get => availibility; set => availibility = value; }
        public string RackNo { get => rackNo; set => rackNo = value; }
        public DateTime AddedDate { get => addedDate; set => addedDate = value; }
        public DateTime UpdatedDate { get => updatedDate; set => updatedDate = value; }
    }
}
       

       
