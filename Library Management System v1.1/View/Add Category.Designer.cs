
namespace Library_Management_System_v1._1.View
{
    partial class Add_Category
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
            this.txt_categoryId = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_addCategory = new MaterialSkin.Controls.MaterialButton();
            this.btn_clearCategory = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_categoryName = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Category ID";
            // 
            // txt_categoryId
            // 
            this.txt_categoryId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_categoryId.Depth = 0;
            this.txt_categoryId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_categoryId.Location = new System.Drawing.Point(162, 91);
            this.txt_categoryId.MaxLength = 50;
            this.txt_categoryId.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_categoryId.Multiline = false;
            this.txt_categoryId.Name = "txt_categoryId";
            this.txt_categoryId.ReadOnly = true;
            this.txt_categoryId.Size = new System.Drawing.Size(100, 36);
            this.txt_categoryId.TabIndex = 2;
            this.txt_categoryId.Text = "";
            this.txt_categoryId.UseTallSize = false;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addCategory.Depth = 0;
            this.btn_addCategory.DrawShadows = true;
            this.btn_addCategory.HighEmphasis = true;
            this.btn_addCategory.Icon = null;
            this.btn_addCategory.Location = new System.Drawing.Point(247, 205);
            this.btn_addCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(50, 36);
            this.btn_addCategory.TabIndex = 4;
            this.btn_addCategory.Text = "Add";
            this.btn_addCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_addCategory.UseAccentColor = false;
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.btn_addCategory_Click);
            // 
            // btn_clearCategory
            // 
            this.btn_clearCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clearCategory.Depth = 0;
            this.btn_clearCategory.DrawShadows = true;
            this.btn_clearCategory.HighEmphasis = true;
            this.btn_clearCategory.Icon = null;
            this.btn_clearCategory.Location = new System.Drawing.Point(305, 205);
            this.btn_clearCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clearCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clearCategory.Name = "btn_clearCategory";
            this.btn_clearCategory.Size = new System.Drawing.Size(66, 36);
            this.btn_clearCategory.TabIndex = 5;
            this.btn_clearCategory.Text = "Clear";
            this.btn_clearCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clearCategory.UseAccentColor = false;
            this.btn_clearCategory.UseVisualStyleBackColor = true;
            this.btn_clearCategory.Click += new System.EventHandler(this.btn_clearCategory_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(34, 150);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(64, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Category";
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_categoryName.Depth = 0;
            this.txt_categoryName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_categoryName.Location = new System.Drawing.Point(162, 146);
            this.txt_categoryName.MaxLength = 50;
            this.txt_categoryName.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_categoryName.Multiline = false;
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(208, 36);
            this.txt_categoryName.TabIndex = 7;
            this.txt_categoryName.Text = "";
            this.txt_categoryName.UseTallSize = false;
            // 
            // Add_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 256);
            this.Controls.Add(this.txt_categoryName);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btn_clearCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_categoryId);
            this.Name = "Add_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.Add_Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_categoryId;
        private MaterialSkin.Controls.MaterialButton btn_addCategory;
        private MaterialSkin.Controls.MaterialButton btn_clearCategory;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_categoryName;
    }
}