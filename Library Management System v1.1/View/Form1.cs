using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System_v1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Loadform(object UserForm)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            UserControl f = UserForm as UserControl;
            f.Dock = Dock;
            panel1.Controls.Add(f);
            panel1.Tag = f;
            f.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Loadform(new ManageBookAdmin());
        }
    }
}
