using LiveCharts;
using LiveCharts.Wpf;
using MaterialSkin;
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
    public partial class LibrariyanHome : MaterialForm
    {

        Controller.MaterialController material = new Controller.MaterialController();
        Controller.LibrariyanDashboardController librariyandash = new Controller.LibrariyanDashboardController();
        Controller.CommonController commonController = new Controller.CommonController();
        Model.DatabaseService DB = new Model.DatabaseService();
        Model.Librarian librarian;
        String emp_Id = Controller.LoginController.currentUserId;
        int avCount = 0;

        [Obsolete]
        public LibrariyanHome()
        {
            InitializeComponent();

            material.addStyle(this);
            cmb_FilterBookAvailability.SelectedIndex = 0;
            timer1.Start();
            this.FormClosing += Form_FormClosing;
        }
        
       //=========================On Load Librarian Home ==========================================
        private void LibrariyanHome_Load(object sender, EventArgs e)
        {
            librarian = librariyandash.setLibrariyan(emp_Id);
            lbl_librariyan_name.Text = librarian.Name.Split(' ')[0] + " " + librarian.Name.Split(' ')[1];
            lbl_welcome_note.Text = "Hello " + librarian.Name.Split(' ')[0] + ", How're you today?";
            loadDashboardTileCounts();
            loadMembers();
            loadBooks();
            loadBookIssues();
            profileDetailUpdate();
            loadAccounting();
            loadBookAvailability();
            commonController.loadActivities(listview_librarianActivities, emp_Id);
            cmb_MemberFilter.SelectedIndex = 0;
            cmb_filterBooks.SelectedIndex = 0;
            cmb_bookIssueFilter.SelectedIndex = 0;
            cmb_filterAccounting.SelectedIndex = 0;
            cmb_FilterBookAvailability.SelectedIndex = 0;
            lbl_totalBookIssueCount.Text = getTotalBookIssueCount().ToString();
            lbl_IssueBookLastUpdate.Text = Controller.BookIssueReturnController.getLastUpdateDateTime("Book_Issue", "Updated_Date");
            lbl_BooksLastUpdate.Text = Controller.BookIssueReturnController.getLastUpdateDateTime("Book", "Date_updated");
            lbl_AccountingLastUpdate.Text = Controller.BookIssueReturnController.getLastUpdateDateTime("Accounting", "Last_Updated");
            


        }
        
        //========================load Book Availability ====================================

        public void loadBookAvailability()
        {
            listview_BookAvailability.Items.Clear();
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData("Select * From Book ORDER BY Date_added ASC");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["BID"].ToString());
                        item.SubItems.Add(sdr["Name"].ToString());
                        item.SubItems.Add(sdr["Author"].ToString());
                        if (Convert.ToBoolean(sdr["Availability"]))
                        {
                            item.SubItems.Add("Available");
                        }
                        else
                        {
                            item.SubItems.Add("Unavailable");
                        }
                        item.SubItems.Add(sdr["Rack_No"].ToString());

                        listview_BookAvailability.Items.Add(item);
                    }
                    DB.Con.Close();
                    
                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    DB.Con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {
                DB.Con.Close();
            }
        }

        //========================load Dashboard Tile Counts ===============================
        public void loadDashboardTileCounts()
        {
            lbl_members_count.Text = tile_count("SELECT * FROM Member").ToString();
            lbl_books_count.Text = tile_count("SELECT * FROM Book").ToString();
            lbl_BookIssuedCount.Text = tile_count("SELECT * FROM Book_Issue WHERE DATE(Updated_date) = '" +DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND Status='" + 1 + "'").ToString();
            lbl_BooksReturnedCount.Text = tile_count("SELECT * FROM Book_Issue WHERE DATE(Updated_date) = '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "' AND Status='" + 0 + "'").ToString();
            
        }

        //============ form x or F4 click logout user ================================
        [Obsolete]
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    int line = new Model.DatabaseService().updateData("Update AppUser SET IsLoggedIn = 0 WHERE Emp_Id= '" + emp_Id + "'");
                    if (line > 0)
                    {
                        this.Hide();
                        Login lg = new Login();
                        lg.Closed += (s, args) => this.Close();
                        Controller.CommonController.setActivity("Logged out ");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Application Cannot Logout ", emp_Id);
                    }
                }
                if (e.CloseReason == CloseReason.WindowsShutDown)
                {
                    int line = new Model.DatabaseService().updateData("Update AppUser SET IsLoggedIn = 0 WHERE Emp_Id= '" + emp_Id + "'");
                    if (line > 0)
                    {
                        this.Hide();
                        Login lg = new Login();
                        lg.Closed += (s, args) => this.Close();
                        Controller.CommonController.setActivity("Logged out ");
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Application Cannot Logout ", emp_Id);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        //=====================Load Member Fee table to Accounting List view =====================================
        public void loadAccounting()
        {
            accountingListview.Items.Clear();
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData("Select * From Accounting");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["Fee_Id"].ToString());
                        item.SubItems.Add(sdr["MID"].ToString());
                        item.SubItems.Add(sdr["Fine_Count"].ToString());
                        if (Convert.ToBoolean(sdr["Status"]))
                        {
                            item.SubItems.Add("Paid");
                        }
                        else
                        {
                            item.SubItems.Add("Not Paid");
                        }
                        item.SubItems.Add(sdr["Last_Updated"].ToString());

                        accountingListview.Items.Add(item);
                    }
                    DB.Con.Close();
                    lbl_AccountingLastUpdate.Text = commonController.setUpdatedTime("Last_Updated", "Accounting", "Fee_Id", "");
                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    DB.Con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();
            }
        }
        //=====================Load Members to Member List view =====================================
        public void loadMembers()
        {
            memberListview.Items.Clear();
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData("SELECT * FROM Member ORDER BY Date_Added ASC");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["MID"].ToString());
                        item.SubItems.Add(sdr["Guardian_Id"].ToString());
                        item.SubItems.Add(sdr["Name"].ToString());
                        item.SubItems.Add(sdr["Address"].ToString());
                        item.SubItems.Add(sdr["Phone_No"].ToString());
                        item.SubItems.Add(sdr["NIC"].ToString());
                        item.SubItems.Add(sdr["Updated_date"].ToString());

                        memberListview.Items.Add(item);
                    }
                    DB.Con.Close();
                    lbl_members_tot.Text = memberListview.Items.Count.ToString();
                    lbl_membersLastUpdate.Text = commonController.setUpdatedTime("Updated_Date", "Member", "MID", "");
                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    DB.Con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();
            }
        }

        //=====================Load Books to Book List view =====================================
        public void loadBooks()
        {
            LibBookList.Items.Clear();
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData("Select * From Book ORDER BY Date_added ASC");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["ISBN"].ToString());
                        item.SubItems.Add(sdr["Name"].ToString());
                        item.SubItems.Add(sdr["Category"].ToString());
                        item.SubItems.Add(sdr["Author"].ToString());
                        if (Convert.ToBoolean(sdr["Availability"]))
                        {
                            item.SubItems.Add("Available");
                            avCount = avCount + 1;
                        }
                        else
                        {
                            item.SubItems.Add("Unavailable");
                        }
                        
                        item.SubItems.Add(sdr["Rack_No"].ToString());
                        item.SubItems.Add(sdr["Date_Updated"].ToString());

                        LibBookList.Items.Add(item);
                    }
                    DB.Con.Close();
                    lbl_totalBookCount.Text = LibBookList.Items.Count.ToString();
                    

                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    DB.Con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();
            }
            finally
            {
                DB.Con.Close();
            }
        }

        //=====================Load Book_Issues to Book Issue List view =====================================
        public void loadBookIssues()
        {
            listView_issueBooks.Items.Clear();
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData("Select * From Book_Issue ORDER BY Issued_dateTime ASC");
                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        ListViewItem item = new ListViewItem(sdr["BID"].ToString());
                        item.SubItems.Add(sdr["MID"].ToString());
                        item.SubItems.Add(sdr["LID"].ToString());
                        item.SubItems.Add(sdr["issued_dateTime"].ToString());
                        item.SubItems.Add(sdr["Return_date"].ToString());
                        if(Convert.ToBoolean(sdr["Status"]))
                        {
                            item.SubItems.Add("Issued");
                        }
                        else
                        {
                            item.SubItems.Add("Returned");
                        }
                        listView_issueBooks.Items.Add(item);
                    }
                    DB.Con.Close();
                    lbl_totalBookIssueCount.Text = getTotalBookIssueCount().ToString();

                }
                else
                {
                    Console.WriteLine("No Data to Show");
                    DB.Con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                DB.Con.Close();
            }
            finally
            {
                DB.Con.Close();
            }
        }
        //=======================total book issue count ===========================================
        private int getTotalBookIssueCount()
        {
            
            int count = 0;
            if (listView_issueBooks.Items.Count > 0)
            {
                for(int i = 0; i < listView_issueBooks.Items.Count; i++)
                {
                    if(listView_issueBooks.Items[i].SubItems[5].Text == "Issued")
                    {
                        count = count + 1;
                    }
                }

                return count;
            }
            return count;
        }
        //=======================set Dashboard tile Counts ========================================
        public int tile_count(String query)
        {
            int count = 0;
            try
            {
                DB.Con.Open();
                MySqlDataReader sdr = DB.readData(query);
              
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        count = count + 1;
                    }
                }
                DB.Con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                DB.Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB.Con.Close();
            }
            finally
            {
                DB.Con.Close();
            }
            return count;
        }

        //===============Switch Dark Theme Light Theme ===========================
        private void swtSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (swtSwitchTheme.Checked) {
                swtSwitchTheme.Text = "Light Mode";
                material.Thememode = MaterialSkinManager.Themes.DARK;
                listview_BookAvailability.GridLines = false;
                memberListview.GridLines = false;
                LibBookList.GridLines = false;
                listView_issueBooks.GridLines = false;
                accountingListview.GridLines = false;
                listview_librarianActivities.GridLines = false;
            }
            else
            {
                swtSwitchTheme.Text = "Dark Mode";
                material.Thememode = MaterialSkinManager.Themes.LIGHT;
                listview_BookAvailability.GridLines = true;
                memberListview.GridLines = true;
                LibBookList.GridLines = true;
                listView_issueBooks.GridLines = true;
                accountingListview.GridLines = true;
                listview_librarianActivities.GridLines = true;
            }
            material.MaterialSkinManager.Theme = material.Thememode;

        }

        //=================Add Book Btn =======================
        private void LibAddBook_Click(object sender, EventArgs e)
        {
            new View.AddBook(false ,lbl_BooksLastUpdate).ShowDialog();
        }

        //=================Add Members Btn =======================
        private void LibaddMemberBtn_Click(object sender, EventArgs e)
        {
            new AddMember().ShowDialog();
        }

        //=================Add Member Dashboard Btn =======================
        private void addMemberDashboard_Click(object sender, EventArgs e)
        {
            new AddMember().ShowDialog();
        }

        //=================Add Book Issue Dashboard Btn =======================
        private void addBorrowDashBoardBtn_Click(object sender, EventArgs e)
        {
            if(avCount > 0)
            {
                new Add_Book_Borrowing_Details(librarian, lbl_IssueBookLastUpdate).ShowDialog();
            }
            else
            {
                MessageBox.Show("No Books Available");
            }
            
        }

        //================Add Book Issue Btn =============================
        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            if (avCount > 0)
            {
                new Add_Book_Borrowing_Details(librarian, lbl_IssueBookLastUpdate).ShowDialog();
            }
            else
            {
                MessageBox.Show("No Books Available");
            }
        }

        //=================Return Book Btn ==============================
        private void returnBookBtn_Click(object sender, EventArgs e)
        {
             if (listView_issueBooks.SelectedItems.Count > 0)
             {
                String BID = listView_issueBooks.SelectedItems[0].SubItems[0].Text;
                String MID = listView_issueBooks.SelectedItems[0].SubItems[1].Text;
                String ID = (listView_issueBooks.SelectedItems[0].Index + 1).ToString();

                if (listView_issueBooks.SelectedItems[0].SubItems[5].Text != "Returned")
                {
                        DialogResult dialogresult = MessageBox.Show("Have any Damages/Late return in Book ?", "", MessageBoxButtons.YesNoCancel);
                        if (dialogresult.Equals(DialogResult.Yes))
                        {

                                new AddfineWindow(BID, MID, emp_Id,ID , lbl_IssueBookLastUpdate).ShowDialog();

                        }
                        else if (dialogresult.Equals(DialogResult.No))
                        {
                                
                            DialogResult dialogresult1 = MessageBox.Show("Are you sure that member retured Book?", "", MessageBoxButtons.YesNo);
                            if (dialogresult1.Equals(DialogResult.Yes))
                            {
                                    try
                                    {

                                        if (Controller.BookIssueReturnController.returnBook(ID , BID))
                                        {
                                            Controller.CommonController.setActivity("Handeled book returning from Book issue Id =" + ID);
                                            MessageBox.Show("Book Returned successfully");
                                            lbl_IssueBookLastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                        }
                                        else
                                        {
                                            MessageBox.Show("Book_issue status update failed");
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }
                            }
                            
                        }
                        
                }
                else
                {
                    MessageBox.Show("Book Already Returned");
                }
                    
             }
             else
             {
                MessageBox.Show("Please Select a record");
             } 
        }

        //============Pay Member Fee =================================================
        private void PayMemberFee_Click(object sender, EventArgs e)
        {
            if (accountingListview.SelectedItems.Count > 0)
            {
                DialogResult dialogresult = MessageBox.Show("Are you sure That Member Paid Fee ?", "", MessageBoxButtons.YesNo);
                if (dialogresult.Equals(DialogResult.Yes))
                {
                    if (Controller.MemberFeeController.isPaid(accountingListview.SelectedItems[0].SubItems[1].Text))
                    {
                        Controller.CommonController.setActivity("Recieved monthly fee from " + accountingListview.SelectedItems[0].SubItems[1].Text);
                        MessageBox.Show("Member Fee Updated");
                        lbl_AccountingLastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        loadAccounting();
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong");
                    }      
                }
                else
                {
                    MessageBox.Show("Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Record");
            }
            
        }

        //============Add Book  Dashboard Btn ======================================
        private void addBookDashBoard_Click(object sender, EventArgs e)
        {
            new View.AddBook(false ,lbl_BooksLastUpdate).ShowDialog();
        }

        //===========Add Category Dashboard Btn ====================================
        private void addCategoryDashboard_Click(object sender, EventArgs e)
        {
            new Add_Category().Show();
        }

        //==============Add Author Dashboard Btn ====================================
        private void addAuthorDashboard_Click(object sender, EventArgs e)
        {
            new Add_Author().Show();
        }

        //========Librarian Profile Detail Update ================================

        public void profileDetailUpdate()
        {
            lbl_librarianProfileName.Text = librarian.Name;
            lbl_librarianProfileId.Text = librarian.Id;
            lbl_librarianProfileNIC.Text = librarian.NIC1;
            lbl_librarianProfileAddress.Text = librarian.Address;
            lbl_librarianProfilePhone.Text = librarian.Phone;
            
        }

        //=============================Librarian Logout ==============================================
        [Obsolete]
        private void btn_librariyanLogout_Click(object sender, EventArgs e)
        {
            int line = new Model.DatabaseService().updateData("Update AppUser SET IsLoggedIn = 0 WHERE Emp_Id= '" + emp_Id + "'");
            if (line > 0)
            {
                this.Hide();
                Login lg = new Login();
                lg.Closed += (s, args) => this.Close();
                lg.Show();
                Controller.CommonController.setActivity("Logout");
                swtSwitchTheme.Text = "Dark Mode";
                material.Thememode = MaterialSkinManager.Themes.LIGHT;
                material.MaterialSkinManager.Theme = material.Thememode;
                Controller.LoginController.currentEmpType = null;
                Controller.LoginController.currentUserId = null;

            }
            else
            {
                MessageBox.Show("Logout Failed");
            }
        }

        //============================Refresh every second =======================================
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_librarianDateTime.Text = DateTime.Now.ToString("yyy-MM-dd ") + DateTime.Now.ToString("h:mm:ss tt");
        }

       


        //============================Update Member Btn===================================================
        private void btn_updateMember_Click(object sender, EventArgs e)
        {
            if (memberListview.SelectedIndices.Count > 0)
            {
                try
                {
                    String selectedRowId = memberListview.SelectedItems[0].SubItems[0].Text;
                    new AddMember(true, selectedRowId).Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update");
            }
            
        }

        //===================Delete Member Btn ========================================
        private void btn_deleteMember_Click(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection selectedIndex = memberListview.SelectedIndices;
            if (selectedIndex.Count > 0)
            {
                Model.DatabaseService database = new Model.DatabaseService();
                DialogResult res = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (res.Equals(DialogResult.Yes))
                {

                    String selectedRowId = memberListview.SelectedItems[0].SubItems[0].Text;
                    String GID = memberListview.SelectedItems[0].SubItems[1].Text;

                    try
                    {
                        int line3 = database.deleteData("DELETE FROM Accounting WHERE MID = '" + selectedRowId + "'");
                        int line1 = database.deleteData("DELETE FROM Guardian WHERE GID = '" + GID + "'");
                        int line = database.deleteData("DELETE FROM Member WHERE MID = '" + selectedRowId + "'");


                        Console.WriteLine(line + " " + line1 + " " + line3);

                        if (line > 0 && line1 > 0 && line3 > 0)
                        {
                            Controller.CommonController.setActivity("Deleted " + selectedRowId + " Member Data");
                            MessageBox.Show("Member Removed Successfully");
                            loadMembers();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong");
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Deletation Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete");
            }
            
        }

        //====================Update Books Button ====================================
        private void btn_updateBook_Click(object sender, EventArgs e)
        {
            if (LibBookList.SelectedItems.Count > 0)
            {
                try
                {
                    Model.Book book = new Model.Book(
                            LibBookList.SelectedItems[0].SubItems[0].Text,
                            LibBookList.SelectedItems[0].SubItems[1].Text,
                            LibBookList.SelectedItems[0].SubItems[2].Text,
                            LibBookList.SelectedItems[0].SubItems[3].Text,
                            LibBookList.SelectedItems[0].SubItems[5].Text
                        );

                    Controller.BookController.selectedBook = book;
                  
                    new AddBook(true ,lbl_BooksLastUpdate).Show();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Book to update");
            }
        }

        //========================Delete Book ================================================
        private void btn_DeleteBook_Click(object sender, EventArgs e)
        {
            if (LibBookList.SelectedIndices.Count > 0)
            {
                Model.DatabaseService database = new Model.DatabaseService();
                DialogResult res = MessageBox.Show("Are you sure ?", "", MessageBoxButtons.YesNo);
                if (res.Equals(DialogResult.Yes))
                {
                    try
                    {
                        String selectedRowId = LibBookList.SelectedItems[0].SubItems[0].Text;
                        int line = database.deleteData("DELETE FROM Book WHERE ISBN = '" + selectedRowId + "'");

                        if (line > 0)
                        {
                            Controller.CommonController.setActivity("Deleted " + selectedRowId + " Book Data");
                            MessageBox.Show("Book Removed Successfully");
                            loadBooks();
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong");
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                else
                {
                    MessageBox.Show("Deletation Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete");
            }
            
        }

        //=================Refresh books =================================
        private void btn_refreshBooks_Click(object sender, EventArgs e)
        {
            loadBooks();
        }


        //===================Search Members ======================================
        private void txt_memberSearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_memberSearch.Text != "")
            {
                Controller.MemberController.memberSearchFunction(memberListview, cmb_MemberFilter.SelectedIndex, txt_memberSearch);
            }
            else
            {
                loadMembers();
            }
        }


        //============== Search Books ============================================
        private void txt_bookSearch_TextChanged(object sender, EventArgs e)
        {
            if (txt_bookSearch.Text != "")
            {
                Controller.BookController.bookSearchFunction(LibBookList, cmb_filterBooks.SelectedIndex, txt_bookSearch);
            }
            else
            {
                loadBooks();
            }
        }

        //================== Search Books ======================================

        private void txt_searchBookIssue_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBookIssue.Text != "")
            {
                Controller.BookIssueReturnController.bookIssueSearchFunction(listView_issueBooks, cmb_bookIssueFilter.SelectedIndex, txt_searchBookIssue);
            }
            else
            {
                loadBookIssues();
            }
        }

        //==========Refresh Members ===================================
        private void btn_refreshMember_Click(object sender, EventArgs e)
        {
            loadMembers();
        }

        //=======Refresh Book Issues ======================================
        private void btn_refreshBookIssues_Click(object sender, EventArgs e)
        {
            loadBookIssues();
        }

        //=======Refresh Accounting ========================================
        private void btn_refreshAccounting_Click(object sender, EventArgs e)
        {
            loadAccounting();
        }

        //================Search Accounting ==============================
        private void txt_searchAccounting_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchAccounting.Text != "")
            {
                Controller.MemberFeeController.memberFeeSearchFunction(accountingListview, cmb_filterAccounting.SelectedIndex, txt_searchAccounting);
            }
            else
            {
                loadAccounting();
            }
        }

        //=============Filter Activity By date ========================================
        private void datetime_activityFilter_ValueChanged(object sender, EventArgs e)
        {
            commonController.loadActivities(listview_librarianActivities, emp_Id);

            for (int i = listview_librarianActivities.Items.Count - 1; i >= 0; i--)
            {
                var item = listview_librarianActivities.Items[i];

                if (Convert.ToDateTime(item.SubItems[1].Text).Date.ToString().ToLower().Contains(datetime_activityFilter.Value.Date.ToString().ToLower()))
                {

                }
                else
                {
                    listview_librarianActivities.Items.Remove(item);
                }
            }
            if (listview_librarianActivities.SelectedItems.Count == 1)
            {
                listview_librarianActivities.Focus();
            }
        }

        //==================Refresh Librarian Activities =================================
        private void btn_refreshLibrarianActivities_Click(object sender, EventArgs e)
        {
            commonController.loadActivities(listview_librarianActivities, emp_Id);
        }

        //==================Refresh Book Availibility =================================
        private void btn_refreshDashboard_Click(object sender, EventArgs e)
        {
            loadBookAvailability();
            loadDashboardTileCounts();
            
        }

        //================Search Book Availibility
        private void txt_searchBookAvailability_TextChanged(object sender, EventArgs e)
        {
            if (txt_searchBookAvailability.Text != "")
            {
                Controller.BookController.bookAvailibilitySearchFunction(listview_BookAvailability, cmb_FilterBookAvailability.SelectedIndex, txt_searchBookAvailability);
            }
            else
            {
                loadBookAvailability();
            }
        }
    }
}
