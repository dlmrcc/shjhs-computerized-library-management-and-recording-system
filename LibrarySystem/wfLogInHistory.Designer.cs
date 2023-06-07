namespace LibrarySystem
{
    partial class wfLogInHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfLogInHistory));
            this.dgHistory = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbResult = new System.Windows.Forms.ToolStripLabel();
            this.bnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bnSearch = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHistory
            // 
            this.dgHistory.AllowUserToAddRows = false;
            this.dgHistory.AllowUserToDeleteRows = false;
            this.dgHistory.AllowUserToResizeColumns = false;
            this.dgHistory.AllowUserToResizeRows = false;
            this.dgHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistory.Location = new System.Drawing.Point(0, 25);
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.ReadOnly = true;
            this.dgHistory.RowHeadersVisible = false;
            this.dgHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistory.Size = new System.Drawing.Size(1049, 310);
            this.dgHistory.TabIndex = 2;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dtFrom);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dtTo);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgHistory);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1049, 360);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(1049, 385);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.CustomFormat = "MMM. dd, yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(809, 2);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(104, 20);
            this.dtFrom.TabIndex = 9;
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.CustomFormat = "MMM. dd, yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(942, 2);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(104, 20);
            this.dtTo.TabIndex = 8;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbResult,
            this.bnClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 335);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1049, 25);
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
            this.bnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(56, 22);
            this.bnClose.Text = "Close";
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnPrint,
            this.toolStripLabel1,
            this.bnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1049, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(277, 22);
            this.toolStripLabel1.Text = "From                                       To                                    " +
                " ";
            // 
            // bnSearch
            // 
            this.bnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnSearch.ForeColor = System.Drawing.Color.White;
            this.bnSearch.Image = ((System.Drawing.Image)(resources.GetObject("bnSearch.Image")));
            this.bnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnSearch.Name = "bnSearch";
            this.bnSearch.Size = new System.Drawing.Size(62, 22);
            this.bnSearch.Text = "Search";
            this.bnSearch.Click += new System.EventHandler(this.bnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In - History";
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
            this.panel1.Size = new System.Drawing.Size(1049, 40);
            this.panel1.TabIndex = 7;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // wfLogInHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 425);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "wfLogInHistory";
            this.Text = "Log - In History";
            this.Load += new System.EventHandler(this.wfLogInHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistory;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbResult;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bnPrint;
        private System.Windows.Forms.ToolStripButton bnSearch;
        private System.Windows.Forms.ToolStripButton bnClose;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}