using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Management_System_v1._1.Controller
{
    class AddLibrarianController
    {
        
        public Boolean addLibrarian(Model.Librarian librarian , Model.User appUser)
        {
            Model.DatabaseService database = new Model.DatabaseService();
            
            int row = database.insertData("INSERT INTO Librarian VALUES('" + librarian.Id + "','" + librarian.Name + "','" + librarian.NIC1 + "'," +
                                "'" + librarian.Address + "','" + librarian.Email + "','"+librarian.Phone+"','" + librarian.UpdatedDate.ToString("yyyy-MM-dd HH:mm:ss") + "','" + librarian.AddedDate.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            int row2 = database.insertData("INSERT INTO AppUser VALUES('" + appUser.EmpID + "','" + appUser.Password + "','" + appUser.EmpType + "','" + 0 + "')");
            return  row > 0 && row2>0;
        }


        public Boolean updateLibrarian(Model.Librarian librarian) {
            Model.DatabaseService database = new Model.DatabaseService();
            int row = database.updateData("UPDATE Librarian SET Name = '" + librarian.Name + "',NIC = '" + librarian.NIC1 + "'" +
                ", Address = '" + librarian.Address + "', Email = '" + librarian.Email + "' , Phone = '" + librarian.Phone + "',updated_date = '"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  WHERE Librarian_Id = '" + librarian.Id + "'");
            return row > 0;
        }
    }
}
