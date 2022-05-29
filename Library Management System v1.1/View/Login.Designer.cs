namespace Library_Management_System_v1._1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bluebackround = new System.Windows.Forms.Panel();
            this.lbl_LoginProgress = new System.Windows.Forms.Label();
            this.lbl_LoginMessage = new System.Windows.Forms.Label();
            this.progressBar_LoginProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordHide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnretry = new System.Windows.Forms.Button();
            this.passwordShow = new System.Windows.Forms.PictureBox();
            this.btnlogin = new Library_Management_System_v1._1.View.Custom_Controls.RJButton();
            this.btnQR = new Library_Management_System_v1._1.View.Custom_Controls.RJButton();
            this.txtmail = new CustomControls.RJControls.RJTextBox();
            this.txtPass = new CustomControls.RJControls.RJTextBox();
            this.bluebackround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).BeginInit();
            this.SuspendLayout();
            // 
            // bluebackround
            // 
            this.bluebackround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.bluebackround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bluebackround.Controls.Add(this.lbl_LoginProgress);
            this.bluebackround.Controls.Add(this.lbl_LoginMessage);
            this.bluebackround.Controls.Add(this.progressBar_LoginProgress);
            this.bluebackround.Controls.Add(this.label5);
            this.bluebackround.Controls.Add(this.label4);
            this.bluebackround.Controls.Add(this.label3);
            this.bluebackround.Controls.Add(this.piclogo);
            this.bluebackround.Location = new System.Drawing.Point(0, 23);
            this.bluebackround.Name = "bluebackround";
            this.bluebackround.Size = new System.Drawing.Size(300, 450);
            this.bluebackround.TabIndex = 10;
            // 
            // lbl_LoginProgress
            // 
            this.lbl_LoginProgress.AutoSize = true;
            this.lbl_LoginProgress.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginProgress.Location = new System.Drawing.Point(217, 391);
            this.lbl_LoginProgress.Name = "lbl_LoginProgress";
            this.lbl_LoginProgress.Size = new System.Drawing.Size(0, 13);
            this.lbl_LoginProgress.TabIndex = 17;
            // 
            // lbl_LoginMessage
            // 
            this.lbl_LoginMessage.AutoSize = true;
            this.lbl_LoginMessage.ForeColor = System.Drawing.Color.White;
            this.lbl_LoginMessage.Location = new System.Drawing.Point(23, 394);
            this.lbl_LoginMessage.Name = "lbl_LoginMessage";
            this.lbl_LoginMessage.Size = new System.Drawing.Size(0, 13);
            this.lbl_LoginMessage.TabIndex = 16;
            // 
            // progressBar_LoginProgress
            // 
            this.progressBar_LoginProgress.BackColor = System.Drawing.Color.White;
            this.progressBar_LoginProgress.Depth = 0;
            this.progressBar_LoginProgress.Location = new System.Drawing.Point(21, 410);
            this.progressBar_LoginProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar_LoginProgress.Name = "progressBar_LoginProgress";
            this.progressBar_LoginProgress.Size = new System.Drawing.Size(232, 5);
            this.progressBar_LoginProgress.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "LIBRARY MANAGEMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "NIBM";
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(21, 32);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(72, 70);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 11;
            this.piclogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(345, 130);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(251, 220);
            this.metroPanel1.TabIndex = 22;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(342, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password";
            // 
            // resetBtn
            // 
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(412, 429);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(109, 23);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset Password";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(399, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Hello Welcome Again !";
            // 
            // passwordHide
            // 
            this.passwordHide.Image = ((System.Drawing.Image)(resources.GetObject("passwordHide.Image")));
            this.passwordHide.Location = new System.Drawing.Point(573, 259);
            this.passwordHide.Name = "passwordHide";
            this.passwordHide.Size = new System.Drawing.Size(20, 20);
            this.passwordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordHide.TabIndex = 29;
            this.passwordHide.TabStop = false;
            this.passwordHide.Click += new System.EventHandler(this.passwordHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(348, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnretry
            // 
            this.btnretry.FlatAppearance.BorderSize = 0;
            this.btnretry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretry.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretry.Location = new System.Drawing.Point(412, 407);
            this.btnretry.Name = "btnretry";
            this.btnretry.Size = new System.Drawing.Size(109, 23);
            this.btnretry.TabIndex = 30;
            this.btnretry.Text = "Retry Login";
            this.btnretry.UseVisualStyleBackColor = true;
            this.btnretry.Click += new System.EventHandler(this.btnretry_Click);
            // 
            // passwordShow
            // 
            this.passwordShow.Image = ((System.Drawing.Image)(resources.GetObject("passwordShow.Image")));
            this.passwordShow.Location = new System.Drawing.Point(573, 259);
            this.passwordShow.Name = "passwordShow";
            this.passwordShow.Size = new System.Drawing.Size(20, 20);
            this.passwordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passwordShow.TabIndex = 31;
            this.passwordShow.TabStop = false;
            this.passwordShow.Click += new System.EventHandler(this.passwordShow_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnlogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnlogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnlogin.BorderRadius = 8;
            this.btnlogin.BorderSize = 0;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Image = ((System.Drawing.Image)(resources.GetObject("btnlogin.Image")));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(345, 308);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(251, 40);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.White;
            this.btnQR.BackgroundColor = System.Drawing.Color.White;
            this.btnQR.BorderColor = System.Drawing.Color.Black;
            this.btnQR.BorderRadius = 8;
            this.btnQR.BorderSize = 1;
            this.btnQR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQR.FlatAppearance.BorderSize = 0;
            this.btnQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQR.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQR.ForeColor = System.Drawing.Color.Black;
            this.btnQR.Image = ((System.Drawing.Image)(resources.GetObject("btnQR.Image")));
            this.btnQR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQR.Location = new System.Drawing.Point(345, 361);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(251, 40);
            this.btnQR.TabIndex = 3;
            this.btnQR.Text = "Login with QR";
            this.btnQR.TextColor = System.Drawing.Color.Black;
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtmail.BorderColor = System.Drawing.Color.Black;
            this.txtmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtmail.BorderSize = 2;
            this.txtmail.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.ForeColor = System.Drawing.Color.Black;
            this.txtmail.Location = new System.Drawing.Point(345, 175);
            this.txtmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtmail.MaximumSize = new System.Drawing.Size(251, 33);
            this.txtmail.MinimumSize = new System.Drawing.Size(251, 33);
            this.txtmail.Multiline = false;
            this.txtmail.Name = "txtmail";
            this.txtmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtmail.PasswordChar = false;
            this.txtmail.Size = new System.Drawing.Size(251, 33);
            this.txtmail.TabIndex = 0;
            this.txtmail.UnderlinedStyle = true;
            this.txtmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmail_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtPass.BorderColor = System.Drawing.Color.Black;
            this.txtPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(345, 252);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.MaximumSize = new System.Drawing.Size(251, 33);
            this.txtPass.MinimumSize = new System.Drawing.Size(251, 33);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(7);
            this.txtPass.PasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(251, 33);
            this.txtPass.TabIndex = 1;
            this.txtPass.UnderlinedStyle = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 466);
            this.Controls.Add(this.passwordShow);
            this.Controls.Add(this.btnretry);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordHide);
            this.Controls.Add(this.bluebackround);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Tag = "hello";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.bluebackround.ResumeLayout(false);
            this.bluebackround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bluebackround;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialProgressBar progressBar_LoginProgress;
        private System.Windows.Forms.Label lbl_LoginProgress;
        private System.Windows.Forms.Label lbl_LoginMessage;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private CustomControls.RJControls.RJTextBox txtPass;
        private System.Windows.Forms.Label label6;
        private View.Custom_Controls.RJButton btnQR;
        private View.Custom_Controls.RJButton btnlogin;
        private System.Windows.Forms.PictureBox passwordHide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnretry;
        private System.Windows.Forms.PictureBox passwordShow;
    }
}