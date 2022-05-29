 using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v1._1.View
{
    public partial class ResetPassword : MaterialForm
    {

        Model.DatabaseService database = new Model.DatabaseService();
        public ResetPassword()
        {
            InitializeComponent();
            new Controller.MaterialController().addStyle(this);
            loadLibrariyanIds();
            
        }


        public void loadLibrariyanIds()
        {
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("SELECT Librarian_Id FROM Librarian");
                while (sdr.Read())
                {

                    cmb_libID.Items.Add(sdr["Librarian_Id"]);
                }
                database.Con.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public int generateNotificationID()
        {
            int id;
            try {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("SELECT notification_id FROM Notification ORDER BY notification_id DESC LIMIT 1");
                if (sdr.HasRows)
                {
                    sdr.Read();
                    id = Convert.ToInt32(sdr["notification_id"])+1;
                    database.Con.Close();

                }
                else
                {
                    id = 1;
                    database.Con.Close();
                }
                return id; 

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                database.Con.Close();
            }
            return 0;
        }


        //==============================Request Button=============================
        private void requestBtn_Click(object sender, EventArgs e)
        {
            if (cmb_libID.SelectedItem == null)
            {
                MessageBox.Show("Please Select you Employee Id");
            }else if(txt_reason.Text == "")
            {
                MessageBox.Show("Please enter reason for Reset");
            }
            else
            {
                try
                {
                    int line = database.insertData("INSERT INTO Notification VALUES ('" + generateNotificationID() + "','" + "A1" + "','" + cmb_libID.SelectedItem.ToString() + "','" + txt_reason.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','')");
                    if (line > 0)
                    {
                        MessageBox.Show("Request Sent Successfully");
                        this.Hide();
                        this.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong. Try Again Later");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    database.Con.Close();
                }
            }
            
        }
    }
}
