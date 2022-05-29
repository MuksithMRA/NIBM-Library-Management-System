using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Library_Management_System_v1._1.Controller
{
    class BookIssueReturnController
    {
        //=============================Last update ===================================

        public static String  getLastUpdateDateTime (String tableName, String columnName){
            String date = DateTime.Now.ToString();
            Model.DatabaseService database = new Model.DatabaseService();
            try
            {
                database.Con.Open();
                MySqlDataReader sdr = database.readData("SELECT " + columnName + " FROM " + tableName + " ORDER BY " + columnName + " DESC LIMIT 1");
                sdr.Read();
                date = sdr[columnName].ToString();
                database.Con.Close();
                return date;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return date;
            
        }

        //=========================Return Book ============================================================

        public static Boolean returnBook(String ID , String BID )
        {
            Model.DatabaseService DB = new Model.DatabaseService();
            int row = DB.updateData("UPDATE Book_Issue SET Status = 0 WHERE ID = '" + ID + "'");
            if (row > 0)
            {

                int row1 = DB.updateData("UPDATE Book SET Availability = 1 WHERE BID = '" + BID + "'");
                if (row1 > 0)
                {
                    return true;
                    
                }
                
            }
            return false;
        }
        //===========================Search Function ==================================================
        public static void bookIssueSearchFunction(MaterialListView list, int itemIndex, MaterialTextBox inputBox)
        {

            if (itemIndex == 0)
            {

                for (int i = list.Items.Count - 1; i >= 0; i--)
                {
                    var item = list.Items[i];

                    if (item.Text.ToLower().Contains(inputBox.Text.ToLower()))
                    {

                    }
                    else
                    {
                        list.Items.Remove(item);
                    }
                }
                if (list.SelectedItems.Count == 1)
                {
                    list.Focus();
                }
            }
            else if (itemIndex == 1)
            {
                for (int i = list.Items.Count - 1; i >= 0; i--)
                {
                    var item = list.Items[i];

                    if (item.SubItems[1].Text.ToLower().Contains(inputBox.Text.ToLower()))
                    {

                    }
                    else
                    {
                        list.Items.Remove(item);
                    }
                }
                if (list.SelectedItems.Count == 1)
                {
                    list.Focus();
                }

            }
            else if (itemIndex == 2)
            {
                for (int i = list.Items.Count - 1; i >= 0; i--)
                {
                    var item = list.Items[i];

                    if (item.SubItems[5].Text.ToLower().Contains(inputBox.Text.ToLower()))
                    {

                    }
                    else
                    {
                        list.Items.Remove(item);
                    }
                }
                if (list.SelectedItems.Count == 1)
                {
                    list.Focus();
                }

            }
            else
            {

            }

        }
    }
}
