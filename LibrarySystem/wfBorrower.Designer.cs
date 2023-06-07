namespace LibrarySystem
{
    partial class wfBorrower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBorrower));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bnPrint = new System.Windows.Forms.ToolStripButton();
            this.bnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbResult = new System.Windows.Forms.ToolStripLabel();
            this.bnAdd = new System.Windows.Forms.ToolStripButton();
            this.bnClose = new System.Windows.Forms.ToolStripButton();
            this.dgBorrower = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.cbCategory = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // bnEdit
            // 
            this.bnEdit.ForeColor = System.Drawing.Color.White;
            this.bnEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnEdit.Image")));
            this.bnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(47, 22);
            this.bnEdit.Text = "Edit";
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripContainer1.BottomToolStripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.BottomToolStripPanel.BackgroundImage")));
            this.toolStripContainer1.BottomToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgBorrower);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1046, 339);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(1046, 389);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripContainer1.TopToolStripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripContainer1.TopToolStripPanel.BackgroundImage")));
            this.toolStripContainer1.TopToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbResult,
            this.bnAdd,
            this.bnEdit,
            this.bnClose});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(196, 25);
            this.toolStrip2.TabIndex = 1;
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
            // bnAdd
            // 
            this.bnAdd.ForeColor = System.Drawing.Color.White;
            this.bnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnAdd.Image")));
            this.bnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(49, 22);
            this.bnAdd.Text = "Add";
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnClose
            // 
            this.bnClose.ForeColor = System.Drawing.Color.White;
            this.bnClose.Image = ((System.Drawing.Image)(resources.GetObject("bnClose.Image")));
            this.bnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(56, 22);
            this.bnClose.Text = "Close";
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // dgBorrower
            // 
            this.dgBorrower.AllowUserToAddRows = false;
            this.dgBorrower.AllowUserToDeleteRows = false;
            this.dgBorrower.AllowUserToResizeColumns = false;
            this.dgBorrower.AllowUserToResizeRows = false;
            this.dgBorrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrower.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBorrower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBorrower.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBorrower.Location = new System.Drawing.Point(0, 25);
            this.dgBorrower.Name = "dgBorrower";
            this.dgBorrower.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBorrower.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgBorrower.RowHeadersVisible = false;
            this.dgBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBorrower.Size = new System.Drawing.Size(1046, 314);
            this.dgBorrower.TabIndex = 2;
            this.dgBorrower.SelectionChanged += new System.EventHandler(this.dgUser_SelectionChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnPrint,
            this.txtSearch,
            this.toolStripLabel2,
            this.cbCategory,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1046, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 25);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            "Borrower ID",
            "Firstname",
            "Middlename",
            "Lastname",
            "Address"});
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 40);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower Information";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // wfBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 429);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "wfBorrower";
            this.Text = "wfBorrower";
            this.Load += new System.EventHandler(this.wfBorrower_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bnPrint;
        private System.Windows.Forms.ToolStripButton bnEdit;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbResult;
        private System.Windows.Forms.ToolStripButton bnAdd;
        private System.Windows.Forms.DataGridView dgBorrower;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton bnClose;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox cbCategory;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}