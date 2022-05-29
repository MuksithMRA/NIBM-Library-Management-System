
namespace Library_Management_System_v1._1.View
{
    partial class notificationTile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notification = new MaterialSkin.Controls.MaterialCard();
            this.lbl_recievedTime = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Reason = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_LibId = new MaterialSkin.Controls.MaterialLabel();
            this.notification.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification
            // 
            this.notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notification.Controls.Add(this.lbl_recievedTime);
            this.notification.Controls.Add(this.lbl_Reason);
            this.notification.Controls.Add(this.materialLabel2);
            this.notification.Controls.Add(this.lbl_LibId);
            this.notification.Depth = 0;
            this.notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notification.Location = new System.Drawing.Point(0, 0);
            this.notification.Margin = new System.Windows.Forms.Padding(14);
            this.notification.MouseState = MaterialSkin.MouseState.HOVER;
            this.notification.Name = "notification";
            this.notification.Padding = new System.Windows.Forms.Padding(14);
            this.notification.Size = new System.Drawing.Size(617, 74);
            this.notification.TabIndex = 2;
            this.notification.Click += new System.EventHandler(this.notification_Click);
            // 
            // lbl_recievedTime
            // 
            this.lbl_recievedTime.AutoSize = true;
            this.lbl_recievedTime.Depth = 0;
            this.lbl_recievedTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_recievedTime.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_recievedTime.Location = new System.Drawing.Point(441, 33);
            this.lbl_recievedTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_recievedTime.Name = "lbl_recievedTime";
            this.lbl_recievedTime.Size = new System.Drawing.Size(135, 17);
            this.lbl_recievedTime.TabIndex = 3;
            this.lbl_recievedTime.Text = "2021-07-05 07:05 AM";
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.AutoSize = true;
            this.lbl_Reason.Depth = 0;
            this.lbl_Reason.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Reason.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_Reason.Location = new System.Drawing.Point(151, 43);
            this.lbl_Reason.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(145, 17);
            this.lbl_Reason.TabIndex = 2;
            this.lbl_Reason.Text = "None Secure Password";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(151, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(159, 17);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Password Reset Request";
            // 
            // lbl_LibId
            // 
            this.lbl_LibId.AutoSize = true;
            this.lbl_LibId.Depth = 0;
            this.lbl_LibId.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_LibId.Location = new System.Drawing.Point(17, 31);
            this.lbl_LibId.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_LibId.Name = "lbl_LibId";
            this.lbl_LibId.Size = new System.Drawing.Size(28, 19);
            this.lbl_LibId.TabIndex = 0;
            this.lbl_LibId.Text = "L01";
            // 
            // notificationTile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notification);
            this.Name = "notificationTile";
            this.Size = new System.Drawing.Size(617, 74);
            this.notification.ResumeLayout(false);
            this.notification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard notification;
        private MaterialSkin.Controls.MaterialLabel lbl_recievedTime;
        private MaterialSkin.Controls.MaterialLabel lbl_Reason;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lbl_LibId;
    }
}
