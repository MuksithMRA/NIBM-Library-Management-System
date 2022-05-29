using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using MySql.Data.MySqlClient;

namespace Library_Management_System_v1._1
{
    public partial class QRlogin : Form
    {

     
        FilterInfoCollection getdata;
        VideoCaptureDevice camera;
        Model.DatabaseService database = new Model.DatabaseService();
        Controller.LoginController loginController = new Controller.LoginController();


        public QRlogin()
        {
            InitializeComponent();
            getdata = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in getdata)
            {
                comboBox1.Items.Add(info.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRlogin_Load(object sender, EventArgs e)
        {
            try
            {
                camera = new VideoCaptureDevice(getdata[comboBox1.SelectedIndex].MonikerString);
                camera.NewFrame += Camera_NewFrame;
                timer1.Start();
                camera.Start();
            }
            catch (Exception ex)
            {
                timer1.Stop();
                camera.Stop();
                MessageBox.Show(ex.Message);
            }

        }

        private void load(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (f1 != null)
            {
                f1.Hide();
            }
        }

        [Obsolete]
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader br = new BarcodeReader();

                Result ans = br.Decode((Bitmap)pictureBox1.Image);

                if (ans != null)
                {
                    try
                    {
                        String emp_id;
                        database.Con.Open();
                        emp_id = ans.ToString();
                        MySqlDataReader sdr = database.readData("Select * From AppUser where Emp_Id = '" + ans.ToString() + "'");
                        sdr.Read();
                        if (sdr.HasRows)
                        {
                            String emp_type = sdr["Emp_Type"].ToString();
                            int line = new Model.DatabaseService().updateData("Update AppUser SET IsLoggedIn = 1 WHERE Emp_Id= '" + emp_id + "'");
                            if (line > 0)
                            {
                                if (emp_type == "Admin")
                                {
                                    Controller.LoginController.currentUserId = emp_id;
                                    timer1.Stop();
                                    camera.Stop();
                                    Controller.LoginController.currentEmpType = emp_type;
                                    database.Con.Close();
                                    var lg = new View.AdminDashboard();
                                    lg.Shown += load;
                                    lg.Show();
                                    Controller.CommonController.setActivity("Logged In ");
                                }
                                else
                                {
                                    Controller.LoginController.currentUserId = emp_id;
                                    timer1.Stop();
                                    camera.Stop();
                                    database.Con.Close();
                                    Controller.LoginController.currentEmpType = emp_type;
                                    var lg = new View.LibrariyanHome();
                                    lg.Shown += load;
                                    lg.Show();
                                    Controller.CommonController.setActivity("Logged In ");
                                }
                            }
                            database.Con.Close();

                        }
                        else
                        {
                            database.Con.Close();
                            camera.Stop();
                            timer1.Stop();
                            MessageBox.Show("user Does not exist ", MessageBoxIcon.Warning.ToString());
                        }

                    }
                    catch (MySqlException ex)
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
}