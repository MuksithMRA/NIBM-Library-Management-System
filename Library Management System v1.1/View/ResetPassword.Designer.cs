
namespace Library_Management_System_v1._1.View
{
    partial class ResetPassword
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmb_libID = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.requestBtn = new MaterialSkin.Controls.MaterialButton();
            this.txt_reason = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel1.Location = new System.Drawing.Point(39, 115);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 17);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Librariyan ID";
            // 
            // cmb_libID
            // 
            this.cmb_libID.AutoResize = false;
            this.cmb_libID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_libID.Depth = 0;
            this.cmb_libID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_libID.DropDownHeight = 118;
            this.cmb_libID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_libID.DropDownWidth = 121;
            this.cmb_libID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_libID.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_libID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_libID.FormattingEnabled = true;
            this.cmb_libID.Hint = "Select ID";
            this.cmb_libID.IntegralHeight = false;
            this.cmb_libID.ItemHeight = 29;
            this.cmb_libID.Location = new System.Drawing.Point(42, 144);
            this.cmb_libID.MaxDropDownItems = 4;
            this.cmb_libID.MaximumSize = new System.Drawing.Size(121, 0);
            this.cmb_libID.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_libID.Name = "cmb_libID";
            this.cmb_libID.Size = new System.Drawing.Size(121, 35);
            this.cmb_libID.TabIndex = 7;
            this.cmb_libID.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel2.Location = new System.Drawing.Point(38, 205);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 17);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Reason";
            // 
            // requestBtn
            // 
            this.requestBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.requestBtn.Depth = 0;
            this.requestBtn.DrawShadows = true;
            this.requestBtn.HighEmphasis = true;
            this.requestBtn.Icon = null;
            this.requestBtn.Location = new System.Drawing.Point(187, 293);
            this.requestBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.requestBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(146, 36);
            this.requestBtn.TabIndex = 10;
            this.requestBtn.Text = "Request a Reset";
            this.requestBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.requestBtn.UseAccentColor = false;
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_reason.Depth = 0;
            this.txt_reason.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_reason.Location = new System.Drawing.Point(39, 225);
            this.txt_reason.MaximumSize = new System.Drawing.Size(291, 35);
            this.txt_reason.MaxLength = 50;
            this.txt_reason.MinimumSize = new System.Drawing.Size(291, 35);
            this.txt_reason.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_reason.Multiline = false;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(291, 35);
            this.txt_reason.TabIndex = 11;
            this.txt_reason.Text = "";
            this.txt_reason.UseTallSize = false;
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(375, 344);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.requestBtn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cmb_libID);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox cmb_libID;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton requestBtn;
        private MaterialSkin.Controls.MaterialTextBox txt_reason;
    }
}