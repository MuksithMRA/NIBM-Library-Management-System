
namespace Library_Management_System_v1._1.View
{
    partial class AdminNotifications
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
        private void InitializeComponent()
        {
            this.notificationList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // notificationList
            // 
            this.notificationList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notificationList.Location = new System.Drawing.Point(11, 71);
            this.notificationList.Name = "notificationList";
            this.notificationList.Size = new System.Drawing.Size(662, 372);
            this.notificationList.TabIndex = 0;
            // 
            // AdminNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.notificationList);
            this.Name = "AdminNotifications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notifications";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel notificationList;
    }
}