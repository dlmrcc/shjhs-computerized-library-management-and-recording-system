namespace LibrarySystem
{
    partial class wfHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfHome));
            this.tmDate = new System.Windows.Forms.Timer(this.components);
            this.ttHome = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bnBook = new System.Windows.Forms.ToolStripButton();
            this.bnBorrower = new System.Windows.Forms.ToolStripButton();
            this.bnBorrowBook = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnItem = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productConfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbDate = new System.Windows.Forms.ToolStripLabel();
            this.lbUser = new System.Windows.Forms.ToolStripLabel();
            this.bnReturnBook = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mnItem.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmDate
            // 
            this.tmDate.Interval = 1000;
            this.tmDate.Tick += new System.EventHandler(this.tmDate_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnBook,
            this.bnBorrower,
            this.bnBorrowBook,
            this.bnReturnBook});
            this.toolStrip1.Location = new System.Drawing.Point(0, 106);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bnBook
            // 
            this.bnBook.ForeColor = System.Drawing.Color.White;
            this.bnBook.Image = ((System.Drawing.Image)(resources.GetObject("bnBook.Image")));
            this.bnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBook.Name = "bnBook";
            this.bnBook.Size = new System.Drawing.Size(54, 22);
            this.bnBook.Text = "Book";
            this.bnBook.Click += new System.EventHandler(this.bnBook_Click);
            // 
            // bnBorrower
            // 
            this.bnBorrower.ForeColor = System.Drawing.Color.White;
            this.bnBorrower.Image = ((System.Drawing.Image)(resources.GetObject("bnBorrower.Image")));
            this.bnBorrower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBorrower.Name = "bnBorrower";
            this.bnBorrower.Size = new System.Drawing.Size(75, 22);
            this.bnBorrower.Text = "Borrower";
            this.bnBorrower.Click += new System.EventHandler(this.bnBorrower_Click);
            // 
            // bnBorrowBook
            // 
            this.bnBorrowBook.ForeColor = System.Drawing.Color.White;
            this.bnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("bnBorrowBook.Image")));
            this.bnBorrowBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnBorrowBook.Name = "bnBorrowBook";
            this.bnBorrowBook.Size = new System.Drawing.Size(95, 22);
            this.bnBorrowBook.Text = "Borrow Book";
            this.bnBorrowBook.Click += new System.EventHandler(this.bnBorrowBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 82);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1061, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 82);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poblacion Brooke\'s Point Palawan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1020, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sacred Heart of Jesus High School Computerized Library Management and Recording S" +
                "ystem";
            // 
            // mnItem
            // 
            this.mnItem.BackColor = System.Drawing.Color.White;
            this.mnItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnItem.BackgroundImage")));
            this.mnItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.mnItem.Location = new System.Drawing.Point(0, 0);
            this.mnItem.Name = "mnItem";
            this.mnItem.Size = new System.Drawing.Size(1162, 24);
            this.mnItem.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUsernameToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeUsernameToolStripMenuItem
            // 
            this.changeUsernameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.changeUsernameToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeUsernameToolStripMenuItem.BackgroundImage")));
            this.changeUsernameToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeUsernameToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.changeUsernameToolStripMenuItem.Name = "changeUsernameToolStripMenuItem";
            this.changeUsernameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.changeUsernameToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.changeUsernameToolStripMenuItem.Text = "&Change User Information";
            this.changeUsernameToolStripMenuItem.Click += new System.EventHandler(this.changeUsernameToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.logOutToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.BackgroundImage")));
            this.logOutToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(281, 22);
            this.logOutToolStripMenuItem.Text = "&Log - Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInformationToolStripMenuItem,
            this.productConfigureToolStripMenuItem});
            this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.informationToolStripMenuItem.Text = "Configuration";
            // 
            // userInformationToolStripMenuItem
            // 
            this.userInformationToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInformationToolStripMenuItem.BackgroundImage")));
            this.userInformationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.userInformationToolStripMenuItem.Name = "userInformationToolStripMenuItem";
            this.userInformationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.userInformationToolStripMenuItem.Text = "Configure User";
            this.userInformationToolStripMenuItem.Click += new System.EventHandler(this.userInformationToolStripMenuItem_Click);
            // 
            // productConfigureToolStripMenuItem
            // 
            this.productConfigureToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productConfigureToolStripMenuItem.BackgroundImage")));
            this.productConfigureToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productConfigureToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productConfigureToolStripMenuItem.Name = "productConfigureToolStripMenuItem";
            this.productConfigureToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.productConfigureToolStripMenuItem.Text = "Configure Borrower Type";
            this.productConfigureToolStripMenuItem.Click += new System.EventHandler(this.productConfigureToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInHistoryToolStripMenuItem});
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // logInHistoryToolStripMenuItem
            // 
            this.logInHistoryToolStripMenuItem.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.logInHistoryToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.logInHistoryToolStripMenuItem.Name = "logInHistoryToolStripMenuItem";
            this.logInHistoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.logInHistoryToolStripMenuItem.Text = "Log - In History";
            this.logInHistoryToolStripMenuItem.Click += new System.EventHandler(this.logInHistoryToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.White;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDate,
            this.lbUser});
            this.toolStrip2.Location = new System.Drawing.Point(0, 395);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1162, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lbDate
            // 
            this.lbDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 22);
            // 
            // lbUser
            // 
            this.lbUser.ForeColor = System.Drawing.Color.White;
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(0, 22);
            // 
            // bnReturnBook
            // 
            this.bnReturnBook.ForeColor = System.Drawing.Color.White;
            this.bnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("bnReturnBook.Image")));
            this.bnReturnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnReturnBook.Name = "bnReturnBook";
            this.bnReturnBook.Size = new System.Drawing.Size(92, 22);
            this.bnReturnBook.Text = "Return Book";
            this.bnReturnBook.Click += new System.EventHandler(this.bnReturnBook_Click);
            // 
            // wfHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 420);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnItem);
            this.Controls.Add(this.toolStrip2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnItem;
            this.Name = "wfHome";
            this.Text = "Sacred Heart of Jesus High School Library Management and Recording System - Home " +
                "Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wfHome_FormClosing);
            this.Load += new System.EventHandler(this.wfHome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mnItem.ResumeLayout(false);
            this.mnItem.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip mnItem;
        private System.Windows.Forms.Timer tmDate;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbDate;
        private System.Windows.Forms.ToolStripLabel lbUser;
        private System.Windows.Forms.ToolStripMenuItem changeUsernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttHome;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInformationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton bnBook;
        private System.Windows.Forms.ToolStripMenuItem productConfigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnBorrower;
        private System.Windows.Forms.ToolStripMenuItem logInHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton bnBorrowBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripButton bnReturnBook;

    }
}