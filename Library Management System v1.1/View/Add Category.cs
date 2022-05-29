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
    public partial class Add_Category : MaterialForm
    {
        Controller.CategoryController category = new Controller.CategoryController();
        MaterialComboBox cmb_bookCategories;
        public Add_Category(MaterialComboBox cmb_bookCategories = null)
        {
            InitializeComponent();
            
            this.cmb_bookCategories = cmb_bookCategories;

        }

        

        private void btn_addCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_categoryName.Text))
            {
                Model.DatabaseService database = new Model.DatabaseService();
                try
                {
                    Boolean isAdded = category.addCategory(new Model.Category(txt_categoryId.Text, txt_categoryName.Text, DateTime.Now));
                    if (isAdded)
                    {
                        this.Hide();
                        Controller.CommonController.setActivity("Added " + txt_categoryId.Text + " Category Data");
                        MessageBox.Show("Category Added Successfully");
                        if (cmb_bookCategories != null)
                        {
                            Controller.BookController.loadComboBoxes(cmb_bookCategories, "Category", "Category_Name", AddBook.categories);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter category name");
            }
            
        }

        private void Add_Category_Load(object sender, EventArgs e)
        {
            new Controller.MaterialController().addStyle(this);
            new Controller.CommonController().setId(txt_categoryId, "Category_Id", "Category", "C", "Date_Added");
            txt_categoryName.Focus();
        }

        private void btn_clearCategory_Click(object sender, EventArgs e)
        {
            txt_categoryName.Clear();
        }
    }
}
