using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Controller
{
    class CategoryController
    {
        public Boolean addCategory(Model.Category category)
        {
            Model.DatabaseService db = new Model.DatabaseService();

            int row = db.insertData("INSERT INTO Category VALUES('" + category.Id + "','" + category.Name + "','"+0+"','" + category.DateAdded.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            return row > 0;
        }
    }
}
