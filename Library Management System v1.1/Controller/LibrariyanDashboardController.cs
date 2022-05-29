using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Management_System_v1._1.Controller
{
    class LibrariyanDashboardController
    {
        static Model.DatabaseService db = new Model.DatabaseService();
        


        public Model.Librarian setLibrariyan(String emp_id)
        {
            Model.DatabaseService database = new Model.DatabaseService();
            Model.Librarian librarian;
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("Select * From Librarian WHERE Librarian_Id = '" + emp_id + "'");
                
                if (sdr.HasRows)
                {
                    sdr.Read();
                    librarian = new Model.Librarian(
                        emp_id, sdr["Name"].ToString(), sdr["Address"].ToString(), sdr["Email"].ToString(),
                        sdr["NIC"].ToString(), sdr["Phone"].ToString(),Convert.ToDateTime(sdr["updated_date"]),
                        Convert.ToDateTime(sdr["date_added"]));
                }
                else
                {
                    librarian = null;
                }
                database.Con.Close();
                return librarian;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Con.Close();
                return null;

            }
            finally
            {
                database.Con.Close();
            }

        }
    }
}
