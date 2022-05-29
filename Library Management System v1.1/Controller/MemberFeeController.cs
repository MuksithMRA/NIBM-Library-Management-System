using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Controller
{
    class MemberFeeController
    {
        //============================Pay Member Fee ============================================================
        public static bool isPaid(String mID)
        {
            Console.WriteLine(mID);
            Model.DatabaseService database = new Model.DatabaseService();
            int row = database.updateData("UPDATE Accounting SET Status = 1 , Last_Updated = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE MID = '"+mID+"'");
            return row>0;
        }
        //=========================== Accounting Search Function ================================================= 
        public static void memberFeeSearchFunction(MaterialListView list, int itemIndex, MaterialTextBox inputBox)
        {

            if (itemIndex == 0)
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
            else if (itemIndex == 1)
            {
                for (int i = list.Items.Count - 1; i >= 0; i--)
                {
                    var item = list.Items[i];

                    if (item.SubItems[3].Text.ToLower().Contains(inputBox.Text.ToLower()))
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

        //=====================Add Accounting Record =======================================================
        public static void AddAccountingRecord (Model.MemberFee memberFee)
        {
            try
            {
                Model.DatabaseService database = new Model.DatabaseService();
                int row = database.insertData("INSERT INTO Accounting VALUES('" + memberFee.Id + "','" + memberFee.MID1 + "','" + memberFee.FineCount + "'," +
                    "'" + memberFee.IsPaid + "','" + memberFee.LastUpdated.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                if (row > 0)
                {
                    Console.WriteLine("Accounting record Added");
                }
                else
                {
                    Console.WriteLine("Failed to Add Accounting Record");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
