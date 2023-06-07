namespace LibrarySystem
{
    partial class wfBorrowerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfBorrowerType));
            this.dgBorrower = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bnClose = new System.Windows.Forms.ToolStripButton();
            this.lbResult = new System.Windows.Forms.ToolStripLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.bnEdit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBorrower
            // 
            this.dgBorrower.AllowUserToAddRows = false;
            this.dgBorrower.AllowUserToDeleteRows = false;
            this.dgBorrower.AllowUserToResizeColumns = false;
            this.dgBorrower.AllowUserToResizeRows = false;
            this.dgBorrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBorrower.BackgroundColor = System.Drawing.Color.White;
            this.dgBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBorrower.Location = new System.Drawing.Point(0, 0);
            this.dgBorrower.Name = "dgBorrower";
            this.dgBorrower.ReadOnly = true;
            this.dgBorrower.RowHeadersVisible = false;
            this.dgBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBorrower.Size = new System.Drawing.Size(1050, 328);
            this.dgBorrower.TabIndex = 2;
            this.dgBorrower.SelectionChanged += new System.EventHandler(this.dgUser_SelectionChanged);
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
            this.label1.Text = "Borrower Type";
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
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgBorrower);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1050, 353);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(1050, 378);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
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
            this.bnEdit});
            this.toolStrip2.Location = new System.Drawing.Point(0, 328);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip2.TabIndex = 4;
            // 
            // bnEdit
            // 
            this.bnEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnEdit.ForeColor = System.Drawing.Color.White;
            this.bnEdit.Image = ((System.Drawing.Image)(resources.GetObject("bnEdit.Image")));
            this.bnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnEdit.Name = "bnEdit";
            this.bnEdit.Size = new System.Drawing.Size(47, 22);
            this.bnEdit.Text = "Edit";
            this.bnEdit.Click += new System.EventHandler(this.bnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 40);
            this.panel1.TabIndex = 9;
            // 
            // wfBorrowerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 418);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "wfBorrowerType";
            this.Text = "Borrower Type";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBorrower)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBorrower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton bnClose;
        private System.Windows.Forms.ToolStripLabel lbResult;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton bnEdit;
    }
}