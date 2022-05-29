
namespace Library_Management_System_v1._1.View
{
    partial class Add_Author
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
            this.txt_authorName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_authorId = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_reset = new MaterialSkin.Controls.MaterialButton();
            this.btn_addAuthor = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_authorName
            // 
            this.txt_authorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_authorName.Depth = 0;
            this.txt_authorName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_authorName.Location = new System.Drawing.Point(153, 149);
            this.txt_authorName.MaxLength = 50;
            this.txt_authorName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_authorName.Multiline = false;
            this.txt_authorName.Name = "txt_authorName";
            this.txt_authorName.Size = new System.Drawing.Size(235, 36);
            this.txt_authorName.TabIndex = 11;
            this.txt_authorName.Text = "";
            this.txt_authorName.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(25, 153);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Author Name";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(25, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Author ID";
            // 
            // txt_authorId
            // 
            this.txt_authorId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_authorId.Depth = 0;
            this.txt_authorId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_authorId.Location = new System.Drawing.Point(153, 94);
            this.txt_authorId.MaxLength = 50;
            this.txt_authorId.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_authorId.Multiline = false;
            this.txt_authorId.Name = "txt_authorId";
            this.txt_authorId.ReadOnly = true;
            this.txt_authorId.Size = new System.Drawing.Size(100, 36);
            this.txt_authorId.TabIndex = 8;
            this.txt_authorId.Text = "";
            this.txt_authorId.UseTallSize = false;
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reset.Depth = 0;
            this.btn_reset.DrawShadows = true;
            this.btn_reset.HighEmphasis = true;
            this.btn_reset.Icon = null;
            this.btn_reset.Location = new System.Drawing.Point(296, 205);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reset.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(65, 36);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Reset";
            this.btn_reset.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reset.UseAccentColor = false;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_addAuthor
            // 
            this.btn_addAuthor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addAuthor.Depth = 0;
            this.btn_addAuthor.DrawShadows = true;
            this.btn_addAuthor.HighEmphasis = true;
            this.btn_addAuthor.Icon = null;
            this.btn_addAuthor.Location = new System.Drawing.Point(238, 205);
            this.btn_addAuthor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addAuthor.Name = "btn_addAuthor";
            this.btn_addAuthor.Size = new System.Drawing.Size(50, 36);
            this.btn_addAuthor.TabIndex = 12;
            this.btn_addAuthor.Text = "Add";
            this.btn_addAuthor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_addAuthor.UseAccentColor = false;
            this.btn_addAuthor.UseVisualStyleBackColor = true;
            this.btn_addAuthor.Click += new System.EventHandler(this.btn_addAuthor_Click);
            // 
            // Add_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 256);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_addAuthor);
            this.Controls.Add(this.txt_authorName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_authorId);
            this.Name = "Add_Author";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_authorName;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_authorId;
        private MaterialSkin.Controls.MaterialButton btn_reset;
        private MaterialSkin.Controls.MaterialButton btn_addAuthor;
    }
}