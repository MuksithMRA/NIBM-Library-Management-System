using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v1._1.View
{
    public partial class notificationTile : UserControl
    {
        int notification_id;
        public notificationTile(String LibId , String reason , String dateTime , int notification_id)
        {
            InitializeComponent();
            lbl_LibId.Text = LibId;
            lbl_Reason.Text = reason;
            lbl_recievedTime.Text = dateTime;
            this.notification_id = notification_id;
        }

       
        public void acceptOrReject(String isAccepted, int id)
        {
            try
            {
                int line =new Model.DatabaseService().insertData("UPDATE Notification SET Status = '" + isAccepted + "' WHERE notification_id = '" + id + "'");
                Console.WriteLine(line);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notification_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Approve Request", "", MessageBoxButtons.YesNoCancel);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                MessageBox.Show("Approved");
                acceptOrReject("Approved", notification_id);
                Controller.CommonController.setActivity("Approved Id = " + notification_id + " Password Reset Request");
                this.Click -= notification_Click;
            }
            else if (dialogResult.Equals(DialogResult.No))
            {
                MessageBox.Show("Rejected");
                acceptOrReject("Rejected", notification_id);
                Controller.CommonController.setActivity("Rejected Id = " + notification_id + " Password Reset Request");
                this.Click -= notification_Click;


            }
            else
            {
                MessageBox.Show("Cancelled");
            }
        }
    }
}
