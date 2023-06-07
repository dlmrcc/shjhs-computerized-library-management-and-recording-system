namespace LibrarySystem
{
    partial class wfBorrowerSet
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
            this.bnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBorrowerID = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBorrowerType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(391, 311);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 8;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrower Information";
            // 
            // bnSave
            // 
            this.bnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnSave.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(310, 311);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(75, 23);
            this.bnSave.TabIndex = 7;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID No.";
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.AcceptsReturn = true;
            this.txtBorrowerID.Location = new System.Drawing.Point(109, 59);
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.Size = new System.Drawing.Size(344, 20);
            this.txtBorrowerID.TabIndex = 0;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(109, 87);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(344, 20);
            this.txtFname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Firstname";
            // 
            // txtMname
            // 
            this.txtMname.Location = new System.Drawing.Point(109, 115);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(344, 20);
            this.txtMname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Middlename";
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(109, 143);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(344, 20);
            this.txtLname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lastname";
            // 
            // txtContactNum
            // 
            this.txtContactNum.Location = new System.Drawing.Point(109, 200);
            this.txtContactNum.Name = "txtContactNum";
            this.txtContactNum.Size = new System.Drawing.Size(344, 20);
            this.txtContactNum.TabIndex = 5;
            this.txtContactNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contact Number";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(109, 228);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(344, 72);
            this.txtAddress.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(52, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Borrower Type";
            // 
            // cbBorrowerType
            // 
            this.cbBorrowerType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBorrowerType.FormattingEnabled = true;
            this.cbBorrowerType.Location = new System.Drawing.Point(109, 171);
            this.cbBorrowerType.Name = "cbBorrowerType";
            this.cbBorrowerType.Size = new System.Drawing.Size(344, 21);
            this.cbBorrowerType.TabIndex = 4;
            // 
            // wfBorrowerSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibrarySystem.Properties.Resources.LibrarySystem__25__;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 346);
            this.Controls.Add(this.cbBorrowerType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtContactNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBorrowerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wfBorrowerSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrower Information";
            this.Load += new System.EventHandler(this.wfBorrowerSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBorrowerID;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbBorrowerType;
    }
}