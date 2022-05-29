using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_v1._1.Controller
{
    
    class MemberController
    {

        public static  void memberSearchFunction(MaterialListView list, int itemIndex, MaterialTextBox inputBox)
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

                    if (item.SubItems[2].Text.ToLower().Contains(inputBox.Text.ToLower()))
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

        //=====================Add Member =================================================
        public Boolean addMember(Model.Member member , Model.Guardian guardian)
        {
            Model.DatabaseService database = new Model.DatabaseService();

            int row = database.insertData("INSERT INTO Member VALUES('" + member.MemberId + "','" + member.Name + "','" + member.Address + "'," +
                                "'" + member.PhoneNo + "','" + member.NIC1 + "','" + member.GuardianId + "','" + member.Updated_date.ToString("yyyy-MM-dd HH:mm:ss") + "','" + member.Added_date.ToString("yyyy-MM-dd HH:mm:ss") + "')");

            int row2 = database.insertData("INSERT INTO Guardian VALUES('" + guardian.Id + "','" + guardian.Name + "','" + guardian.NIC1 + "','" + guardian.Address + "'," +
                "'" + guardian.Phone + "','" + guardian.UpdateDate.ToString("yyyy-MM-dd HH:mm:ss") + "')");
           
            return row > 0 && row2>0;
        }


        //=============================Update Member ===========================================
        public Boolean updateMember(Model.Member member ,  Model.Guardian guardian)
        {
            Model.DatabaseService database = new Model.DatabaseService();
            int row = database.updateData("UPDATE Member SET Name = '" + member.Name + "', Address= '" + member.Address + "'," +
                                "Phone_NO = '" + member.PhoneNo + "',NIC = '" + member.NIC1 + "',Guardian_id ='" + member.GuardianId + "',updated_date = '" + member.Updated_date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE MID = '" + member.MemberId + "'");

            int row2 = database.updateData("UPDATE Guardian SET Name = '" + guardian.Name + "' , NIC = '" + guardian.NIC1 + "' ," +
                "Address ='" + guardian.Address + "',Phone ='"+guardian.Phone+"', updated_date = '"+guardian.UpdateDate.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE GID = '"+guardian.Id+"'");
            
            return row > 0 && row2>0;
        }
    }
}
