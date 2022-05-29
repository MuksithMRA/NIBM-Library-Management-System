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
using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework.Forms;


namespace Library_Management_System_v1._1
{
    
    public partial class Login : MetroForm
    {
        Controller.LoginController loginController = new Controller.LoginController();
        Model.DatabaseService database = new Model.DatabaseService();
        QRlogin qr = new QRlogin();

        
       

        [Obsolete]
        public Login()
        {
            InitializeComponent();
            btnretry.Hide();
           
        }


        //==============Switch between  Login with Credentials and QR=========
        public void Loadform(object Form)
        {
            if (this.metroPanel1.Controls.Count > 0)
                this.metroPanel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = Dock;
            metroPanel1.Controls.Clear();
            metroPanel1.Controls.Add(f);
            metroPanel1.Tag = f;
            f.Show();
            
        }


        //============Open Reset Window ======================
        private void resetBtn_Click(object sender, EventArgs e)
        {
            new View.ResetPassword().ShowDialog();
        }




        //====================Login Button Event=======================================================
        [Obsolete]
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtmail.Text == "") 
            {
                MessageBox.Show("Please Enter Employee Id");
            }else if(txtPass.Text == "")
            {
                MessageBox.Show("Please Enter Password");
            }
            else {
                try
                {
                    

                    progressBar_LoginProgress.Value += 20;
                    database.Con.Open();
                    progressBar_LoginProgress.Value += 20;
                    MySqlDataReader sdr = database.readData("Select * From AppUser where Emp_Id = '" + txtmail.Text + "'");
                    progressBar_LoginProgress.Value += 20;
                    sdr.Read();
                    progressBar_LoginProgress.Value += 20;
                    loginController.onLoggedIn(sdr, txtPass.Text, this);
                    progressBar_LoginProgress.Value += 20;
                    database.Con.Close();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    progressBar_LoginProgress.Value = 0;
                    database.Con.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    progressBar_LoginProgress.Value = 0;
                    database.Con.Close();
                }
                finally
                {
                    progressBar_LoginProgress.Value = 0;
                    database.Con.Close();
                }

            }
      
            
        }
        //=================Login With QR ===========================
        private void btnQR_Click(object sender, EventArgs e)
        {
            txtPass.Hide();
            txtmail.Hide();
            btnlogin.Hide();
            btnretry.Show();
            label1.Hide();
            label2.Hide();
            passwordHide.Hide();
            passwordShow.Hide();
            Loadform(new QRlogin());  
        }


        //===========Login page onload =================================
        private void Login_Load(object sender, EventArgs e)
        {
            txtmail.Focus();
        }

        //===========focus keys =======================================
        private void txtmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                txtPass.Focus();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnlogin.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //================ remove dock panel ===========
        public void remove(object Form)
        {
            if (this.metroPanel1.Controls.Count > 0)
                this.metroPanel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = Dock;
            metroPanel1.Controls.Clear();
            metroPanel1.Controls.Add(f);
            metroPanel1.Tag = f;
            f.Hide();
        }

        private void btnretry_Click(object sender, EventArgs e)
        {

            remove(new QRlogin());
            txtPass.Show();
            txtmail.Show();
            btnlogin.Show();
            label1.Show();
            label2.Show();
            passwordHide.Show();
            passwordShow.Show();
            btnretry.Hide();

        }

        private void passwordShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar)
            {
                passwordHide.BringToFront();
                txtPass.PasswordChar = false;
            }
            
        }

        private void passwordHide_Click(object sender, EventArgs e)
        {
            if (!txtPass.PasswordChar)
            {
                passwordShow.BringToFront();
                txtPass.PasswordChar = true;
            }
            
        }
    }
}
