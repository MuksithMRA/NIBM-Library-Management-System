using MaterialSkin.Controls;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Library_Management_System_v1._1.View
{
    public partial class AddBook : MaterialForm
    {
        Controller.CommonController commonController = new Controller.CommonController();
        Controller.BookController bookcontroller = new Controller.BookController();
        Boolean isUpdate;
        MaterialLabel lastUpdate;
        FilterInfoCollection getdata;
        VideoCaptureDevice camera;
        Model.Book selectedBook = Controller.BookController.selectedBook;
        public static List<String> categories = new List<string>();
        public static List<String> authors = new List<string>();
        public static List<String> racks = new List<string>();

        public AddBook( Boolean isUpdate, MaterialLabel lastUpdate = null)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.lastUpdate = lastUpdate;
        }


        //===============On load Add Book Dialog =====================

        private void AddBook_Load(object sender, EventArgs e)
        {
            
            new Controller.MaterialController().addStyle(this);
           
            Controller.BookController.loadComboBoxes(cmb_bookCategories, "Category", "Category_Name",categories);
            Controller.BookController.loadComboBoxes(cmb_BookAuthors, "Author", "Author_Name",authors);
            Controller.BookController.loadComboBoxes(cmb_bookRacks, "Rack", "Rack_NO" , racks);
            onUpdate();
            pictureBox2.Hide();
            lblsrc.Hide();
            comboBox1.Hide();
        }


         //==================On Update ==================================
         public void onUpdate()
        {
            if (isUpdate)
            {
                this.Text = "Update Book";
                this.btn_AddBookDialog.Text = "Update";
                txt_bookISBN.ReadOnly = true;
                
                if(selectedBook != null)
                {
                    Model.DatabaseService database = new Model.DatabaseService();
                    try
                    {
                        
                        database.Con.Open();
                        MySqlDataReader sdr = database.readData("SELECT BID FROM Book WHERE ISBN = '"+selectedBook.Isbn+"'");
                        sdr.Read();
                        if (sdr.HasRows)
                        {
                            txt_bookIdAddBook.Text = sdr["BID"].ToString();
                            txt_BookName.Text = selectedBook.Name.ToString();
                            txt_bookISBN.Text = selectedBook.Isbn.ToString();
                            cmb_BookAuthors.SelectedIndex = authors.IndexOf(selectedBook.Author.ToString());
                            cmb_bookCategories.SelectedIndex = categories.IndexOf(selectedBook.Category.ToString());
                            cmb_bookRacks.SelectedIndex = racks.IndexOf(selectedBook.RackNo.ToString());
                        }
                        
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        database.Con.Close();
                    }
                }
            }
            else
            {
                commonController.setId(txt_bookIdAddBook, "BID", "Book", "B", "Date_added");
            }
        }

        //==================Set Value to combo box ======================
        public int setValuestoCombo(String value , MaterialComboBox cmb)
        {
            int index = 0;
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                if (cmb.Items[i].ToString() == value) {
                    index = i;           
                }
            }
            return index;
        }
        //================Add New Rack No ===============================
        private void addRackNoBtnAddBook_Click(object sender, EventArgs e)
        {
            new Add_RackNo(cmb_bookRacks).ShowDialog();
        }

        //================Add New Author ================================
        private void addAuthorBtnAddBook_Click(object sender, EventArgs e)
        {
            new Add_Author(cmb_BookAuthors).ShowDialog();
        }

        //================Add New Category ===============================
        private void addCategoryBtnAddBook_Click(object sender, EventArgs e)
        {
            new Add_Category(cmb_bookCategories).ShowDialog();
        }

        //=============Show ISBN QR Scanner ===========================
        private void isbnQrBtnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                lblsrc.Show();
                pictureBox2.Show();
                comboBox1.Show();
                pictureBox1.Hide();

                getdata = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo info in getdata)
                {
                    comboBox1.Items.Add(info.Name);
                    comboBox1.SelectedIndex = 0;

                }

                camera = new VideoCaptureDevice(getdata[comboBox1.SelectedIndex].MonikerString);
                camera.NewFrame += Camera_NewFrame;
                camera.Start();
                timer1.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Camera_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_AddBookDialog_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrEmpty(txt_bookISBN.Text))
                {
                    MessageBox.Show("Please Scan or type ISBN Code");

                }
                
                else if (string.IsNullOrEmpty(txt_BookName.Text))
                {
                    MessageBox.Show("Please Enter Book Name");
                }
                else if (cmb_bookCategories.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category");
                }
                else if (cmb_BookAuthors.SelectedItem == null)
                {
                    MessageBox.Show("Please select a author");
                }
                else if (cmb_bookRacks.SelectedItem == null)
                {
                    MessageBox.Show("Please select a book rack");
                }
                else
                {
                    Model.Book book = new Model.Book(txt_bookIdAddBook.Text,txt_BookName.Text,cmb_bookCategories.SelectedItem.ToString(),
                        cmb_BookAuthors.SelectedItem.ToString(),txt_bookISBN.Text,1.ToString(),cmb_bookRacks.SelectedItem.ToString(), DateTime.Now,DateTime.Now);
                    

                    Boolean isAdded;
                    if (!isUpdate)
                    {
                        isAdded = bookcontroller.addBook(book);
                    }
                    else
                    {
                        isAdded = bookcontroller.updateBook(book);
                    }

                    if (isAdded)
                    {
                        this.Hide();
                        if (isUpdate)
                        {
                         
                            
                            Controller.CommonController.setActivity("Updated " + book.Id + " Data");
                            lastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            MessageBox.Show("Record Updated");

                        }
                        else
                        {
                            
                            Controller.CommonController.setActivity("Added New Book " + book.Id + " Data");
                            lastUpdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                            new Model.DatabaseService().updateData("UPDATE Category SET Book_Count = Book_Count+1 WHERE Category_Name = '" + cmb_bookCategories.SelectedItem + "'");
                            MessageBox.Show("Record Added");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong try again");
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Please check your internet connection \n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void clearBtnAddBook_Click(object sender, EventArgs e)
        {
            txt_bookISBN.Clear();
            txt_BookName.Clear();
            cmb_BookAuthors.SelectedIndex = -1;
            cmb_bookCategories.SelectedIndex = -1;
            cmb_bookRacks.SelectedIndex = -1;
            cmb_BookAuthors.Focus();
            cmb_bookCategories.Focus();
            cmb_bookRacks.Focus();
            txt_bookISBN.Focus();
            pictureBox2.Hide();
            lblsrc.Hide();
            comboBox1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                BarcodeReader br = new BarcodeReader();
                Result ans = br.Decode((Bitmap)pictureBox2.Image);
                if (ans != null)
                {
                    txt_bookISBN.Text = ans.ToString();
                    timer1.Stop();
                    if (camera.IsRunning)
                    {
                        camera.Stop();
                        pictureBox2.Hide();
                        lblsrc.Hide();
                        comboBox1.Hide();
                    }

                }

            }
        }
    }
}
