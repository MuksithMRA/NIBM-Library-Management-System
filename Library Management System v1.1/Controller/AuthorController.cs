using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Management_System_v1._1.Controller
{
    class AuthorController
    {
        public Boolean addauthor(Model.Author author)
        {
            Model.DatabaseService db = new Model.DatabaseService();

            int row = db.insertData("INSERT INTO Author VALUES('" + author.Id + "','" + author.Name + "','" + author.AddedDate.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            return row > 0;
        }
    }
}
