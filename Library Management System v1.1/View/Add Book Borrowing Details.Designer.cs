
namespace Library_Management_System_v1._1.View
{
    partial class Add_Book_Borrowing_Details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book_Borrowing_Details));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_issueId = new MaterialSkin.Controls.MaterialTextBox();
            this.lbl_bookName = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_bookCategory = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_BookAuthor = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_MemberName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_LibName = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_issueBookDialog = new MaterialSkin.Controls.MaterialButton();
            this.btn_clearissueBookDialog = new MaterialSkin.Controls.MaterialButton();
            this.cmb_ISBN = new MaterialSkin.Controls.MaterialComboBox();
            this.cmb_MemberId = new MaterialSkin.Controls.MaterialComboBox();
            this.isbnQrBtnissueBook = new MaterialSkin.Controls.MaterialButton();
            this.txt_issuingLibId = new MaterialSkin.Controls.MaterialTextBox();
            this.memberIdbtnIssueBook = new MaterialSkin.Controls.MaterialButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.qrPanelBookBorrow = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblsrc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.qrPanelBookBorrow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(28, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "ISBN";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(28, 271);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Member ID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(28, 350);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Librariyan ID";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel4.Location = new System.Drawing.Point(59, 190);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 17);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Book Name :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(28, 98);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(57, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Issue ID";
            // 
            // txt_issueId
            // 
            this.txt_issueId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_issueId.Depth = 0;
            this.txt_issueId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_issueId.Location = new System.Drawing.Point(156, 81);
            this.txt_issueId.MaxLength = 50;
            this.txt_issueId.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_issueId.Multiline = false;
            this.txt_issueId.Name = "txt_issueId";
            this.txt_issueId.ReadOnly = true;
            this.txt_issueId.Size = new System.Drawing.Size(121, 36);
            this.txt_issueId.TabIndex = 11;
            this.txt_issueId.Text = "";
            this.txt_issueId.UseTallSize = false;
            // 
            // lbl_bookName
            // 
            this.lbl_bookName.AutoSize = true;
            this.lbl_bookName.Depth = 0;
            this.lbl_bookName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_bookName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_bookName.Location = new System.Drawing.Point(153, 190);
            this.lbl_bookName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bookName.Name = "lbl_bookName";
            this.lbl_bookName.Size = new System.Drawing.Size(128, 17);
            this.lbl_bookName.TabIndex = 13;
            this.lbl_bookName.Text = "ex:- Sherlock Holmes";
            // 
            // lbl_bookCategory
            // 
            this.lbl_bookCategory.AutoSize = true;
            this.lbl_bookCategory.Depth = 0;
            this.lbl_bookCategory.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_bookCategory.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_bookCategory.Location = new System.Drawing.Point(153, 207);
            this.lbl_bookCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bookCategory.Name = "lbl_bookCategory";
            this.lbl_bookCategory.Size = new System.Drawing.Size(75, 17);
            this.lbl_bookCategory.TabIndex = 15;
            this.lbl_bookCategory.Text = "ex:- Mystery";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel8.Location = new System.Drawing.Point(59, 207);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(64, 17);
            this.materialLabel8.TabIndex = 14;
            this.materialLabel8.Text = "Category :";
            // 
            // lbl_BookAuthor
            // 
            this.lbl_BookAuthor.AutoSize = true;
            this.lbl_BookAuthor.Depth = 0;
            this.lbl_BookAuthor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_BookAuthor.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_BookAuthor.Location = new System.Drawing.Point(153, 224);
            this.lbl_BookAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_BookAuthor.Name = "lbl_BookAuthor";
            this.lbl_BookAuthor.Size = new System.Drawing.Size(160, 17);
            this.lbl_BookAuthor.TabIndex = 17;
            this.lbl_BookAuthor.Text = "ex:- Sir Athur Conan Doyle";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel10.Location = new System.Drawing.Point(59, 224);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(50, 17);
            this.materialLabel10.TabIndex = 16;
            this.materialLabel10.Text = "Author :";
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.Depth = 0;
            this.lbl_MemberName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_MemberName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_MemberName.Location = new System.Drawing.Point(170, 310);
            this.lbl_MemberName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(84, 17);
            this.lbl_MemberName.TabIndex = 19;
            this.lbl_MemberName.Text = "ex:- John Doe";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel16.Location = new System.Drawing.Point(59, 310);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(98, 17);
            this.materialLabel16.TabIndex = 18;
            this.materialLabel16.Text = "Member Name :";
            // 
            // lbl_LibName
            // 
            this.lbl_LibName.AutoSize = true;
            this.lbl_LibName.Depth = 0;
            this.lbl_LibName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_LibName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lbl_LibName.Location = new System.Drawing.Point(182, 397);
            this.lbl_LibName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_LibName.Name = "lbl_LibName";
            this.lbl_LibName.Size = new System.Drawing.Size(77, 17);
            this.lbl_LibName.TabIndex = 21;
            this.lbl_LibName.Text = "ex:- Carolina";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel12.Location = new System.Drawing.Point(59, 397);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(110, 17);
            this.materialLabel12.TabIndex = 20;
            this.materialLabel12.Text = "Librariyan Name :";
            // 
            // btn_issueBookDialog
            // 
            this.btn_issueBookDialog.AutoSize = false;
            this.btn_issueBookDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_issueBookDialog.Depth = 0;
            this.btn_issueBookDialog.DrawShadows = true;
            this.btn_issueBookDialog.HighEmphasis = true;
            this.btn_issueBookDialog.Icon = null;
            this.btn_issueBookDialog.Location = new System.Drawing.Point(13, 464);
            this.btn_issueBookDialog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_issueBookDialog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_issueBookDialog.Name = "btn_issueBookDialog";
            this.btn_issueBookDialog.Size = new System.Drawing.Size(158, 36);
            this.btn_issueBookDialog.TabIndex = 23;
            this.btn_issueBookDialog.Text = "Add";
            this.btn_issueBookDialog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_issueBookDialog.UseAccentColor = false;
            this.btn_issueBookDialog.UseVisualStyleBackColor = true;
            this.btn_issueBookDialog.Click += new System.EventHandler(this.btn_issueBookDialog_Click);
            // 
            // btn_clearissueBookDialog
            // 
            this.btn_clearissueBookDialog.AutoSize = false;
            this.btn_clearissueBookDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clearissueBookDialog.Depth = 0;
            this.btn_clearissueBookDialog.DrawShadows = true;
            this.btn_clearissueBookDialog.HighEmphasis = true;
            this.btn_clearissueBookDialog.Icon = null;
            this.btn_clearissueBookDialog.Location = new System.Drawing.Point(196, 464);
            this.btn_clearissueBookDialog.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_clearissueBookDialog.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clearissueBookDialog.Name = "btn_clearissueBookDialog";
            this.btn_clearissueBookDialog.Size = new System.Drawing.Size(158, 36);
            this.btn_clearissueBookDialog.TabIndex = 22;
            this.btn_clearissueBookDialog.Text = "Clear";
            this.btn_clearissueBookDialog.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_clearissueBookDialog.UseAccentColor = false;
            this.btn_clearissueBookDialog.UseVisualStyleBackColor = true;
            this.btn_clearissueBookDialog.Click += new System.EventHandler(this.btn_clearissueBookDialog_Click);
            // 
            // cmb_ISBN
            // 
            this.cmb_ISBN.AutoResize = false;
            this.cmb_ISBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_ISBN.Depth = 0;
            this.cmb_ISBN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_ISBN.DropDownHeight = 118;
            this.cmb_ISBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ISBN.DropDownWidth = 121;
            this.cmb_ISBN.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_ISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_ISBN.FormattingEnabled = true;
            this.cmb_ISBN.Hint = "Choose ISBN";
            this.cmb_ISBN.IntegralHeight = false;
            this.cmb_ISBN.ItemHeight = 29;
            this.cmb_ISBN.Location = new System.Drawing.Point(156, 140);
            this.cmb_ISBN.MaxDropDownItems = 4;
            this.cmb_ISBN.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_ISBN.Name = "cmb_ISBN";
            this.cmb_ISBN.Size = new System.Drawing.Size(140, 35);
            this.cmb_ISBN.TabIndex = 24;
            this.cmb_ISBN.UseTallSize = false;
            this.cmb_ISBN.SelectedIndexChanged += new System.EventHandler(this.cmb_ISBN_SelectedIndexChanged);
            // 
            // cmb_MemberId
            // 
            this.cmb_MemberId.AutoResize = false;
            this.cmb_MemberId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_MemberId.Depth = 0;
            this.cmb_MemberId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_MemberId.DropDownHeight = 118;
            this.cmb_MemberId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MemberId.DropDownWidth = 121;
            this.cmb_MemberId.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmb_MemberId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmb_MemberId.FormattingEnabled = true;
            this.cmb_MemberId.Hint = "Choose MID";
            this.cmb_MemberId.IntegralHeight = false;
            this.cmb_MemberId.ItemHeight = 29;
            this.cmb_MemberId.Location = new System.Drawing.Point(156, 260);
            this.cmb_MemberId.MaxDropDownItems = 4;
            this.cmb_MemberId.MouseState = MaterialSkin.MouseState.OUT;
            this.cmb_MemberId.Name = "cmb_MemberId";
            this.cmb_MemberId.Size = new System.Drawing.Size(140, 35);
            this.cmb_MemberId.TabIndex = 25;
            this.cmb_MemberId.UseTallSize = false;
            this.cmb_MemberId.SelectedIndexChanged += new System.EventHandler(this.cmb_MemberId_SelectedIndexChanged);
            // 
            // isbnQrBtnissueBook
            // 
            this.isbnQrBtnissueBook.AutoSize = false;
            this.isbnQrBtnissueBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.isbnQrBtnissueBook.Depth = 0;
            this.isbnQrBtnissueBook.DrawShadows = true;
            this.isbnQrBtnissueBook.HighEmphasis = true;
            this.isbnQrBtnissueBook.Icon = ((System.Drawing.Image)(resources.GetObject("isbnQrBtnissueBook.Icon")));
            this.isbnQrBtnissueBook.Location = new System.Drawing.Point(309, 140);
            this.isbnQrBtnissueBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.isbnQrBtnissueBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.isbnQrBtnissueBook.Name = "isbnQrBtnissueBook";
            this.isbnQrBtnissueBook.Size = new System.Drawing.Size(45, 35);
            this.isbnQrBtnissueBook.TabIndex = 36;
            this.isbnQrBtnissueBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.isbnQrBtnissueBook.UseAccentColor = false;
            this.isbnQrBtnissueBook.UseVisualStyleBackColor = true;
            this.isbnQrBtnissueBook.Click += new System.EventHandler(this.isbnQrBtnissueBook_Click);
            // 
            // txt_issuingLibId
            // 
            this.txt_issuingLibId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_issuingLibId.Depth = 0;
            this.txt_issuingLibId.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_issuingLibId.Location = new System.Drawing.Point(156, 345);
            this.txt_issuingLibId.MaxLength = 50;
            this.txt_issuingLibId.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_issuingLibId.Multiline = false;
            this.txt_issuingLibId.Name = "txt_issuingLibId";
            this.txt_issuingLibId.ReadOnly = true;
            this.txt_issuingLibId.Size = new System.Drawing.Size(121, 36);
            this.txt_issuingLibId.TabIndex = 37;
            this.txt_issuingLibId.Text = "";
            this.txt_issuingLibId.UseTallSize = false;
            // 
            // memberIdbtnIssueBook
            // 
            this.memberIdbtnIssueBook.AutoSize = false;
            this.memberIdbtnIssueBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.memberIdbtnIssueBook.Depth = 0;
            this.memberIdbtnIssueBook.DrawShadows = true;
            this.memberIdbtnIssueBook.HighEmphasis = true;
            this.memberIdbtnIssueBook.Icon = ((System.Drawing.Image)(resources.GetObject("memberIdbtnIssueBook.Icon")));
            this.memberIdbtnIssueBook.Location = new System.Drawing.Point(309, 260);
            this.memberIdbtnIssueBook.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.memberIdbtnIssueBook.MouseState = MaterialSkin.MouseState.HOVER;
            this.memberIdbtnIssueBook.Name = "memberIdbtnIssueBook";
            this.memberIdbtnIssueBook.Size = new System.Drawing.Size(45, 35);
            this.memberIdbtnIssueBook.TabIndex = 38;
            this.memberIdbtnIssueBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.memberIdbtnIssueBook.UseAccentColor = false;
            this.memberIdbtnIssueBook.UseVisualStyleBackColor = true;
            this.memberIdbtnIssueBook.Click += new System.EventHandler(this.memberIdbtnIssueBook_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(580, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 212);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // qrPanelBookBorrow
            // 
            this.qrPanelBookBorrow.BackColor = System.Drawing.SystemColors.Control;
            this.qrPanelBookBorrow.Controls.Add(this.pictureBox2);
            this.qrPanelBookBorrow.Controls.Add(this.pictureBox3);
            this.qrPanelBookBorrow.Location = new System.Drawing.Point(515, 152);
            this.qrPanelBookBorrow.Name = "qrPanelBookBorrow";
            this.qrPanelBookBorrow.Size = new System.Drawing.Size(256, 229);
            this.qrPanelBookBorrow.TabIndex = 45;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(256, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lblsrc
            // 
            this.lblsrc.AutoSize = true;
            this.lblsrc.Location = new System.Drawing.Point(522, 130);
            this.lblsrc.Name = "lblsrc";
            this.lblsrc.Size = new System.Drawing.Size(41, 13);
            this.lblsrc.TabIndex = 46;
            this.lblsrc.Text = "Source";
            // 
            // Add_Book_Borrowing_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 515);
            this.Controls.Add(this.lblsrc);
            this.Controls.Add(this.qrPanelBookBorrow);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.memberIdbtnIssueBook);
            this.Controls.Add(this.txt_issuingLibId);
            this.Controls.Add(this.isbnQrBtnissueBook);
            this.Controls.Add(this.cmb_MemberId);
            this.Controls.Add(this.cmb_ISBN);
            this.Controls.Add(this.btn_issueBookDialog);
            this.Controls.Add(this.btn_clearissueBookDialog);
            this.Controls.Add(this.lbl_LibName);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.lbl_MemberName);
            this.Controls.Add(this.materialLabel16);
            this.Controls.Add(this.lbl_BookAuthor);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.lbl_bookCategory);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.lbl_bookName);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txt_issueId);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Add_Book_Borrowing_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Book Issue";
            this.Load += new System.EventHandler(this.Add_Book_Borrowing_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.qrPanelBookBorrow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txt_issueId;
        private MaterialSkin.Controls.MaterialLabel lbl_bookName;
        private MaterialSkin.Controls.MaterialLabel lbl_bookCategory;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel lbl_BookAuthor;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel lbl_MemberName;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel lbl_LibName;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialButton btn_issueBookDialog;
        private MaterialSkin.Controls.MaterialButton btn_clearissueBookDialog;
        private MaterialSkin.Controls.MaterialComboBox cmb_ISBN;
        private MaterialSkin.Controls.MaterialComboBox cmb_MemberId;
        private MaterialSkin.Controls.MaterialButton isbnQrBtnissueBook;
        private MaterialSkin.Controls.MaterialTextBox txt_issuingLibId;
        private MaterialSkin.Controls.MaterialButton memberIdbtnIssueBook;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel qrPanelBookBorrow;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblsrc;
    }
}