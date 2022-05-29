using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v1._1.Controller
{
   
    class LoginController
    {
        public static String currentUserId;
        public static String currentEmpType;
        
        [Obsolete]
        public void onLoggedIn(MySqlDataReader sdr , String password , Form form) {


            if (sdr.HasRows)
            {

                if (sdr["Password"].ToString() == password)
                {
                    String emp_id = sdr["Emp_Id"].ToString();
                    String emp_type = sdr["Emp_Type"].ToString();


                    int line = new Model.DatabaseService().updateData("Update AppUser SET IsLoggedIn = 1 Where Emp_Id = '" + emp_id + "'");
                    if (line > 0)
                    {

                        form.Hide();
                        form.Closed += (s, args) => form.Close();
                        if (emp_type == "Admin")
                        {
                            currentUserId = emp_id;
                            currentEmpType = emp_type;
                            Controller.CommonController.setActivity("Logged In ");
                            View.AdminDashboard frm = new View.AdminDashboard();
                            
                            frm.Show();
                            

                        }
                        else
                        {
                            currentUserId = emp_id;
                            currentEmpType = emp_type;
                            Controller.CommonController.setActivity("Logged In ");
                            View.LibrariyanHome frm = new View.LibrariyanHome();
                            
                            frm.Show();
                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong please try again");
                    }   
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }

            }
            else
            {
                MessageBox.Show("This user doesn't exists. please check again");
            }
        }
    }
}
