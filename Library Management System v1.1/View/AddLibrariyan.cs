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
    public partial class AddLibrariyan : MaterialForm
    {
        Controller.AddLibrarianController addLibrarianObj = new Controller.AddLibrarianController();
        Controller.CommonController commonController = new Controller.CommonController();
        Boolean isUpdate;
        String selectedRowID;
        MaterialLabel lblLastUpdate;
  
        public AddLibrariyan(Boolean isUpdate = false  , String selectedRowID = "", MaterialLabel lblLastUpdate = null)
        {
            InitializeComponent();
            new Controller.MaterialController().addStyle(this);
            commonController.setId(txt_LibID, "Librarian_Id", "Librarian", "L", "date_added");
            this.isUpdate = isUpdate;
            this.selectedRowID = selectedRowID;
            cmb_countrycodes.SelectedIndex = 1;
            this.lblLastUpdate = lblLastUpdate;
        }


        //===================Adding / Updating Librarian to Database==================
        private void addLibrariyanDialogBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_LibName.Text) || string.IsNullOrEmpty(txt_LibNIC.Text) || string.IsNullOrEmpty(txt_LibAddress.Text))
                {
                    MessageBox.Show("Please fill All fields");
                }
                else if(!commonController.isPhoneNumberValid(txt_LibPhone.Text))
                {
                    MessageBox.Show("Please Enter valid Phone number");
                }
                else if (!commonController.isEmailValid(txt_LibEmail.Text))
                {
                    MessageBox.Show("Please Enter valid Email");
                }
                else
                {
                    //Bind Phone number
                    String phone = commonController.BindNumber(cmb_countrycodes.SelectedItem.ToString(), Convert.ToInt32(txt_LibPhone.Text));
                    Model.Librarian librarian = new Model.Librarian(txt_LibID.Text, txt_LibName.Text, txt_LibAddress.Text, txt_LibEmail.Text,
                            txt_LibNIC.Text, phone, DateTime.Now, DateTime.Now);

                    //Generating Credentials to user
                    Model.User appUser = new Model.User(txt_LibID.Text, commonController.RandomPassword(8, true), "Librarian", false);


                    Boolean isAdded;
                    if (!isUpdate)
                    {
                        isAdded = addLibrarianObj.addLibrarian(librarian, appUser);
                    }
                    else
                    {
                        isAdded = addLibrarianObj.updateLibrarian(librarian);
                    }

                    if (isAdded)
                    {
                        this.Hide();
                        if (isUpdate)
                        {
                            
                            MessageBox.Show("Record Updated");
                            Controller.CommonController.setActivity("Updated Librarian " + librarian.Id + " Data");
                            lblLastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        }
                        else
                        {
                            MessageBox.Show("Record Added");
                            Controller.CommonController.setActivity("Added New Librarian " + librarian.Id + " Data");
                            lblLastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong try again");
                    }
                }
                
            }catch(MySqlException ex)
            {
                MessageBox.Show("Please check your internet connection \n"+ex.Message);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //===================Clear Fields in  Add/Update Dialog==================
        private void clearLibrarianBtnDialog_Click(object sender, EventArgs e)
        {
            
            txt_LibName.Clear();
            txt_LibAddress.Clear();
            txt_LibEmail.Clear();
            txt_LibNIC.Clear();
            txt_LibPhone.Clear();
        }


        //===================Load Existing data when Open Update Dialog==================
        private void AddLibrariyan_Load(object sender, EventArgs e)
        {
            txt_LibName.Focus();
            if (isUpdate)
            {
                Model.DatabaseService database = new Model.DatabaseService();
                this.Text = "Update Librarian";
                addLibrariyanDialogBtn.Text = "Update";
                try
                {
                    database.Con.Open();
                    MySqlDataReader sdr = database.readData("SELECT * FROM Librarian WHERE Librarian_Id = '" + selectedRowID + "'");
                    sdr.Read();
                    if (sdr.HasRows)
                    {
                        txt_LibID.Text = selectedRowID;
                        txt_LibName.Text = sdr["Name"].ToString();
                        txt_LibNIC.Text = sdr["NIC"].ToString();
                        txt_LibAddress.Text = sdr["Address"].ToString();
                        txt_LibEmail.Text = sdr["Email"].ToString();
                        commonController.extractNumber(cmb_countrycodes, txt_LibPhone, sdr["Phone"].ToString());
                    }
                    database.Con.Close();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Please check your internet connection \n" + ex.Message);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
