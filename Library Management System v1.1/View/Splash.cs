using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management_System_v1._1
{
    public partial class Splash : MetroFramework.Forms.MetroForm
    {
       
        private int borderSize = 2;
        

        [Obsolete]
        public Splash()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        [Obsolete]
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 1;
            if (progressBar1.Value > 30)
            {
                this.Hide();
                var frm = new Login();
                timer1.Enabled = false;
                frm.Closed += (s, args) => this.Close();
                frm.TopMost = true;
                frm.ShowDialog();
            }
        }
    }
}
