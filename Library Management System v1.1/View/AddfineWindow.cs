using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v1._1.View
{
    public partial class AddfineWindow : MaterialForm
    {
        String MID;
        String BID;
        String Emp_Id;
        String ID;
        MaterialLabel lbl_IssueBookLastUpdate;
        public AddfineWindow(String BID, String MID,String Emp_Id , String ID , MaterialLabel lbl_IssueBookLastUpdate)
        {
            InitializeComponent();
            new Controller.MaterialController().addStyle(this);
            this.BID = BID;
            this.MID = MID;
            this.Emp_Id = Emp_Id;
            this.ID = ID;
            this.lbl_IssueBookLastUpdate = lbl_IssueBookLastUpdate;
        }

        //================On load Add Fine Window =========================================
        private void AddfineWindow_Load(object sender, EventArgs e)
        {
            txt_BIDAddFine.Text = BID;
            txt_MIDAddFine.Text = MID;
            new Controller.CommonController().setId(txt_fineId, "Fine_Id", "Fine", "F", "Added_Date");
        }

        //============================Pay fine==================== 
     

        private void btn_PayFine_Click(object sender, EventArgs e)
        {
            int val;
            if (string.IsNullOrEmpty(txt_fineAmount.Text))
            {
                MessageBox.Show("Please enter fine amount");
            }else if (string.IsNullOrEmpty(txt_FineReason.Text))
            {
                MessageBox.Show("Please enter reason to fine");
            }else if(!int.TryParse(txt_fineAmount.Text ,  out val))
            {
                MessageBox.Show("Please enter valid amount");
            }
            else
            {
                try
                {
                    Model.DatabaseService database = new Model.DatabaseService();
                    int row = database.insertData("INSERT INTO Fine VALUES ('" + txt_fineId.Text + "','" + txt_MIDAddFine.Text + "','" + txt_BIDAddFine.Text + "','" + Emp_Id + "','" + txt_FineReason.Text + "','" + txt_fineAmount.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                    int row1 = database.updateData("UPDATE Accounting SET Fine_Count = Fine_Count + 1 WHERE MID = '" + MID + "'");
                    if (row > 0 && row1 > 0)
                    {
                        this.Hide();
                        Controller.CommonController.setActivity("Recieved fine from " + MID + " For " + BID + " Book");
                        if (Controller.BookIssueReturnController.returnBook(ID, BID))
                        {
                            Controller.CommonController.setActivity("Handeled book returning from Book issue Id =" + ID);
                            MessageBox.Show("Fine paid & Book Returned successfully");
                            lbl_IssueBookLastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        }
                        else
                        {
                            MessageBox.Show("Book_issue status update failed");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Something went Wrong");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }

        private void btn_clearBtnAddFine_Click(object sender, EventArgs e)
        {
            txt_fineAmount.Clear();
            txt_FineReason.Clear();
            txt_fineAmount.Focus();
        }
    }
}
