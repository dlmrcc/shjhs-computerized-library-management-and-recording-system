namespace LibrarySystem
{
    partial class wfBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbResult = new System.Windows.Forms.ToolStripLabel();
            this.bnClose = new System.Windows.Forms.ToolStripButton();
            this.bnEdit = new System.Windows.Forms.ToolStripButton();
            this.bnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bnPrint = new System.Windows.Forms.ToolStripButton();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbCategory = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 40);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Information";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgBook);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1056, 371);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 40);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripContainer1.Size = new System.Drawing.Size(1056, 396);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // dgBook
            // 
            this.dgBook.AllowUserToAddRows = false;
            this.dgBook.AllowUserToDeleteRows = false;
            this.dgBook.AllowUserToResizeColumns = false;
            this.dgBook.AllowUserToResizeRows = false;
            this.dgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBook.BackgroundColor = System.Drawing.Color.White;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBook.Location = new System.Drawing.Point(0, 25);
            this.dgBook.Name = "dgBook";
            this.dgBook.ReadOnly = true;
            this.dgBook.RowHeadersVisible = false;
            this.dgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBook.Size = new System.Drawing.Size(1056, 321);
            this.dgBook.TabIndex = 2;
            this.dgBook.SelectionChanged += new System.EventHandler(this.dgUser_SelectionChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbResult,
            this.bnClose,
            this.bnEdit,
            this.bnAdd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 346);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip2.TabIndex = 4;
            // 
            // lbResult
            // 
            this.lbResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Image = ((System.Drawing.Image)(resources.GetObject("lbResult.Image")));
            this.lbResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(32, 22);
            this.lbResult.Text = "Print";
            // 
            // bnClose
            // 
            this.bnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnClose.ForeColor = System.Drawing.Color.White;
            this.bnClose.Image = ((System.Drawing.Image)(resources.GetObject("bnClose.Image")));
            this.bnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(56, 22);
            this.bnClose.Text = "Close";
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // bnEdit
            // 
            this.bnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnEdit.ForeColor = System.Drawing.Color.White;
            this.bnEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnEdit.Image")));
            this.bnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(47, 22);
            this.bnEdit.Text = "Edit";
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // bnAdd
            // 
            this.bnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnAdd.ForeColor = System.Drawing.Color.White;
            this.bnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnAdd.Image")));
            this.bnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(49, 22);
            this.bnAdd.Text = "Add";
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnPrint,
            this.txtKeyword,
            this.toolStripLabel2,
            this.cbCategory,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 3;
            // 
            // bnPrint
            // 
            this.bnPrint.ForeColor = System.Drawing.Color.White;
            this.bnPrint.Image = ((System.Drawing.Image)(resources.GetObject("bnPrint.Image")));
            this.bnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnPrint.Name = "bnPrint";
            this.bnPrint.Size = new System.Drawing.Size(52, 22);
            this.bnPrint.Text = "Print";
            this.bnPrint.Click += new System.EventHandler(this.bnPrint_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 25);
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(53, 22);
            this.toolStripLabel2.Text = "Keyword";
            // 
            // cbCategory
            // 
            this.cbCategory.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbCategory.Items.AddRange(new object[] {
            "Accession",
            "Title",
            "Edition",
            "Copy",
            "Publisher",
            "Remarks",
            "Author"});
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Search By:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // wfBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 436);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "wfBook";
            this.Text = "wfBook";
            this.Load += new System.EventHandler(this.wfBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbResult;
        private System.Windows.Forms.ToolStripButton bnClose;
        private System.Windows.Forms.ToolStripButton bnEdit;
        private System.Windows.Forms.ToolStripButton bnAdd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbCategory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}