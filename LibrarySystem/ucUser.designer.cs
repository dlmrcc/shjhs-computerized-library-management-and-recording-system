namespace LibrarySystem
{
    partial class ucUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUser));
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.bnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lbResult = new System.Windows.Forms.ToolStripLabel();
            this.cbUstatus = new System.Windows.Forms.ToolStripComboBox();
            this.bnAdd = new System.Windows.Forms.ToolStripButton();
            this.bnApply = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgUser
            // 
            this.dgUser.AllowUserToAddRows = false;
            this.dgUser.AllowUserToDeleteRows = false;
            this.dgUser.AllowUserToResizeColumns = false;
            this.dgUser.AllowUserToResizeRows = false;
            this.dgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUser.BackgroundColor = System.Drawing.Color.White;
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUser.Location = new System.Drawing.Point(0, 25);
            this.dgUser.Name = "dgUser";
            this.dgUser.ReadOnly = true;
            this.dgUser.RowHeadersVisible = false;
            this.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUser.Size = new System.Drawing.Size(710, 315);
            this.dgUser.TabIndex = 1;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgUser);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(710, 365);
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
            this.toolStripContainer1.Size = new System.Drawing.Size(710, 365);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.Color.SteelBlue;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtSearch,
            this.bnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 25);
            this.toolStrip1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 25);
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
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbResult,
            this.cbUstatus,
            this.bnAdd,
            this.bnApply});
            this.toolStrip2.Location = new System.Drawing.Point(0, 340);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(710, 25);
            this.toolStrip2.TabIndex = 2;
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
            // cbUstatus
            // 
            this.cbUstatus.BackColor = System.Drawing.Color.White;
            this.cbUstatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbUstatus.Name = "cbUstatus";
            this.cbUstatus.Size = new System.Drawing.Size(121, 25);
            this.cbUstatus.Text = "User Status";
            // 
            // bnAdd
            // 
            this.bnAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnAdd.ForeColor = System.Drawing.Color.White;
            this.bnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnAdd.Image")));
            this.bnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(75, 22);
            this.bnAdd.Text = "Add User";
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnApply
            // 
            this.bnApply.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bnApply.ForeColor = System.Drawing.Color.White;
            this.bnApply.Image = ((System.Drawing.Image)(resources.GetObject("bnApply.Image")));
            this.bnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnApply.Name = "bnApply";
            this.bnApply.Size = new System.Drawing.Size(107, 22);
            this.bnApply.Text = "Apply Changes";
            this.bnApply.Click += new System.EventHandler(this.bnApply_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 40);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configure User";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(710, 405);
            this.Load += new System.EventHandler(this.ucUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripButton bnSearch;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lbResult;
        private System.Windows.Forms.ToolStripComboBox cbUstatus;
        private System.Windows.Forms.ToolStripButton bnAdd;
        private System.Windows.Forms.ToolStripButton bnApply;
    }
}
